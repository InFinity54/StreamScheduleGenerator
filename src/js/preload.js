const { contextBridge, ipcRenderer } = require('electron');

// Updater API
contextBridge.exposeInMainWorld('updaterAPI', {
  noUpdateAvailable: (callback) => ipcRenderer.on('update-not-available', callback),
  updateAvailable: (callback) => ipcRenderer.on('update-available', callback),
  updateDownloading: (callback) => ipcRenderer.on('update-download-progress', callback),
  updateDownloaded: (callback) => ipcRenderer.on('update-downloaded', callback)
});

// Window API
contextBridge.exposeInMainWorld('windowAPI', {
  windowReduce: () => ipcRenderer.invoke('windowReduce'),
  windowClose: () => ipcRenderer.invoke('windowClose')
});

// App API
contextBridge.exposeInMainWorld('appAPI', {
  getAppVersion: () => ipcRenderer.invoke('getAppVersion'),
  noSettingsFile: (response) => ipcRenderer.on('noSettingsFile', (response)),
  updateSettings: (response) => ipcRenderer.on('updateSettings', (response)),
  fontsList: (response) => ipcRenderer.on('fontsList', (response)),
  saveSettings: (args) => ipcRenderer.invoke('saveSettings', args)
});
