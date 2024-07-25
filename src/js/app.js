import { initIdentityValues } from "./steps/identity";

window.appSettings = {
  identity: {
    platform: 'twitch',
    platformColor: 'default',
    channelName: '',
    fullChannelLink: false,
    fontName: '',
    colors: {
      titles: '#FFFFFF',
      dayOn: '#FFFFFF',
      dayOff: '#FF0000'
    }
  }
};

window.appAPI.noSettingsFile((event) => {
  window.appAPI.saveSettings(JSON.stringify(window.appSettings));
  initIdentityValues();
});

window.appAPI.updateSettings((event, args) => {
  window.appSettings = JSON.parse(args);
  initIdentityValues();
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