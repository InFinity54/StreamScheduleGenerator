window.updaterAPI.noUpdateAvailable((event) => {
    jQuery("#update").fadeOut(500);
    jQuery("#introduction").delay(500).fadeIn(500);
});

window.updaterAPI.updateAvailable((event, args) => {
    jQuery("#update_progresstext").text("Téléchargement de la dernière version de l'application...");
});

window.updaterAPI.updateDownloading((event, args) => {
    jQuery("#update_progressbarvalue").css("width", args.percent + "%");
});

window.updaterAPI.updateDownloaded((event) => {
    jQuery("#update_progresstext").text("Préparation de l'installation des mises à jour...");
});