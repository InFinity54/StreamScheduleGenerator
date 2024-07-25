import { initAppValues } from "./steps/identity";

window.appSettings = {
  identity: {
    platform: 'twitch',
    platformColor: 'default',
    channelName: '',
    fullChannelLink: false,
    fontName: '',
    backgroundImagePath: '',
    colors: {
      titles: '#FFFFFF',
      dayOn: '#FFFFFF',
      dayOff: '#FF0000'
    }
  }
};

window.appAPI.noSettingsFile((event) => {
  window.appAPI.saveSettings(JSON.stringify(window.appSettings));
  initAppValues();
});

window.appAPI.updateSettings((event, args) => {
  window.appSettings = JSON.parse(args);
  initAppValues();
});

window.updaterAPI.noUpdateAvailable((event) => {
  // todo
});

window.updaterAPI.updateAvailable((event, args) => {
  // todo
});

window.updaterAPI.updateDownloading((event, args) => {
  // todo
});

window.updaterAPI.updateDownloaded((event) => {
  // todo
});

window.resizeTo(1280, 720);