const { app, BrowserWindow, ipcMain, dialog, protocol } = require('electron');
import { autoUpdater } from "electron-updater";

const path = require('path');
const fs = require("fs");
const fontList = require('font-list');
const isInProdMode = false;
const settingsFilePath = path.join(app.getPath("userData"), "settings.json");
const mime = require('mime-types');

// Handle creating/removing shortcuts on Windows when installing/uninstalling.
if (require('electron-squirrel-startup')) {
  app.quit();
}

const createWindow = () => {
  // Create the browser window.
  const mainWindow = new BrowserWindow({
    width: 1280,
    height: 720,
    'minWidth': 1280,
    'minHeight': 720,
    'maxWidth': 1920,
    'maxHeight': 1080,
    icon: path.join(app.getAppPath(), "icon.png"),
    title: 'Générateur de planning de stream',
    titleBarStyle: 'hidden',
    frame: false,
    backgroundColor: "#010a13",
    center: true,
    show: false,
    webPreferences: {
      preload: MAIN_WINDOW_PRELOAD_WEBPACK_ENTRY
    }
  });

  mainWindow.loadURL(MAIN_WINDOW_WEBPACK_ENTRY);

  mainWindow.on('restore', function (event) {
    mainWindow.webContents.setAudioMuted(false);
  })

  if (!isInProdMode) {
    mainWindow.webContents.openDevTools();
  }

  mainWindow.webContents.on('did-finish-load', function() {
    mainWindow.show();

    if (fs.existsSync(settingsFilePath)) {
      mainWindow.webContents.send('updateSettings', fs.readFileSync(settingsFilePath, { encoding: "utf-8" }));
    } else {
      mainWindow.webContents.send('noSettingsFile');
    }

    fontList.getFonts().then(fonts => {
      mainWindow.webContents.send('fontsList', fonts);
    });

    if (isInProdMode) {
      autoUpdater.checkForUpdates();
    } else {
      mainWindow.webContents.send('update-not-available', null);
    }
  });

  if (isInProdMode) {
    autoUpdater.setFeedURL({
      provider: "github",
      repo: "StreamScheduleGenerator",
      owner: "InFinity54",
      private: false,
      releaseType: "release"
    });
    autoUpdater.forceDevUpdateConfig = true;

    // Updater's main events
    autoUpdater
      .on('update-not-available', m => {
        mainWindow.webContents.send('update-not-available', m);
      })
      .on('update-available', m => {
        mainWindow.webContents.send('update-available', m);
      })
      .on('download-progress', m => {
        mainWindow.webContents.send('update-download-progress', m);
      })
      .on('update-downloaded', m => {
        mainWindow.webContents.send('update-downloaded', m);

        setTimeout(() => {
          autoUpdater.quitAndInstall();
        }, 3000);
      });
  } else {
    mainWindow.webContents.send('update-not-available', null);
  }

  ipcMain.handle('getAppVersion', (event) => {
    return app.getVersion();
  });

  ipcMain.handle('windowReduce', (event) => {
    mainWindow.minimize();
    mainWindow.webContents.setAudioMuted(true);
  });

  ipcMain.handle('windowClose', (event) => {
    app.exit();
  });

  ipcMain.handle('saveSettings', (event, args) => {
    fs.writeFileSync(settingsFilePath, args, { encoding: "utf-8" });
  });

  ipcMain.handle('dialog', (event, method, params) => {
    return dialog[method](params);
  });

  ipcMain.handle("openImage", (event, imagePath) => {
    return `data:${mime.lookup(imagePath)};base64,${fs.readFileSync(imagePath).toString('base64')}`;
  });

  ipcMain.handle("takeScreenshot", (event, savePath) => {
    return mainWindow.webContents.capturePage().then(image => {
      try {
        fs.writeFileSync(savePath, image.toJPEG(100));
        return fs.existsSync(savePath);
      }
      catch (err) {
        return false;
      }
    });
  });
};

// This method will be called when Electron has finished
// initialization and is ready to create browser windows.
// Some APIs can only be used after this event occurs.
app.on('ready', () => {
  createWindow();
});

// Quit when all windows are closed.
app.on('window-all-closed', () => {
  app.quit();
});

app.on('activate', () => {
  // On OS X it's common to re-create a window in the app when the
  // dock icon is clicked and there are no other windows open.
  if (BrowserWindow.getAllWindows().length === 0) {
    createWindow();
  }
});
