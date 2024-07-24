window.appSettings = {};

window.appAPI.noSettingsFile((event) => {
  window.appAPI.saveSettings(JSON.stringify(window.appSettings));
});

window.appAPI.updateSettings((event, args) => {
  window.appSettings = JSON.parse(args);
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