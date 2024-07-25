import { addMonths, format } from "date-fns";

jQuery("#identity_button_previous").click(function () {
    jQuery("#identity").fadeOut("500");
    jQuery("#introduction").delay(500).fadeIn("500");
});

jQuery("#identity_button_next").click(function () {
    if (jQuery('#identity_form')[0].checkValidity()) {
        window.appSettings = {
            identity: {
                platform: 'twitch',
                platformColor: jQuery("#identity_twitchlogocolor").val(),
                channelName: jQuery("#identity_twitchusername").val(),
                fullChannelLink: jQuery("#identity_twitchfulllink")[0].checked,
                fontName: jQuery("#identity_font").val(),
                backgroundImagePath: jQuery("#identity_custombgimage").val(),
                colors: {
                    titles: jQuery("#identity_titlescolor").val(),
                    dayOn: jQuery("#identity_dayoncolor").val(),
                    dayOff: jQuery("#identity_dayoffcolor").val()
                }
            }
        };
        window.appAPI.saveSettings(JSON.stringify(window.appSettings));

        jQuery("#identity_error").addClass("d-none");
        jQuery("#identity").fadeOut("500");
        jQuery("#planning").delay(500).fadeIn("500");
    } else {
        var errorMessage = ``;
        jQuery("#identity_error").removeClass("d-none");

        if (!jQuery("#identity_twitchusername")[0].validity.valid) {
            errorMessage += `Le nom d'utilisateur Twitch n'a pas été renseigné.`;
        }

        if (!jQuery("#identity_twitchlogocolor")[0].validity.valid) {
            if (errorMessage.length > 0) errorMessage += `<br />`;
            errorMessage += `La couleur du logo de Twitch n'a pas été renseignée.`;
        }

        if (!jQuery("#identity_font")[0].validity.valid) {
            if (errorMessage.length > 0) errorMessage += `<br />`;
            errorMessage += `La police d'écriture n'a pas été renseignée.`;
        }

        if (!jQuery("#identity_custombgimage")[0].validity.valid) {
            if (errorMessage.length > 0) errorMessage += `<br />`;
            errorMessage += `Aucune image de fond n'a été choisie.`;
        }

        if (!jQuery("#identity_titlescolor")[0].validity.valid) {
            if (errorMessage.length > 0) errorMessage += `<br />`;
            errorMessage += `La couleur des titres n'a pas été renseignée.`;
        }

        if (!jQuery("#identity_dayoncolor")[0].validity.valid) {
            if (errorMessage.length > 0) errorMessage += `<br />`;
            errorMessage += `La couleur des jours ON n'a pas été renseignée.`;
        }

        if (!jQuery("#identity_dayoffcolor")[0].validity.valid) {
            if (errorMessage.length > 0) errorMessage += `<br />`;
            errorMessage += `La couleur des jours OFF n'a pas été renseignée.`;
        }

        jQuery("#identity_error").html(errorMessage);
    }
});

jQuery("#identity_custombgimagebrowse").click(() => {
    const dialogConfig = {
        properties: ['openFile'],
        filters: [
            {
                name: "Images",
                extensions: ['jpg','jpeg','png'],
            }
        ]
    };

    window.electron.openDialog('showOpenDialog', dialogConfig)
        .then(result => {
            if (!result.canceled) {
                jQuery("#identity_custombgimage").val(result.filePaths[0]);
            } else {
                jQuery("#identity_custombgimage").val("");
            }
        });
});

jQuery("#identity_savepathbrowse").click(() => {
    const dialogConfig = {
        properties: ['openFile'],
        filters: [
            {
                name: "Image JPG",
                extensions: ['jpg'],
            }
        ]
    };

    window.electron.openDialog('showSaveDialog', dialogConfig)
        .then(result => {
            if (!result.canceled) {
                jQuery("#identity_savepath").val(result.filePath);
            } else {
                jQuery("#identity_savepath").val("");
            }
        });
});

function initAppValues() {
    window.appAPI.fontsList((event, fonts) => {
        for (var font in fonts) {
            jQuery('#identity_font').append(
                jQuery('<option>', {
                    value: fonts[font].replaceAll("\"", ""),
                    text: fonts[font].replaceAll("\"", ""),
                    selected: fonts[font].replaceAll("\"", "") === window.appSettings.identity.fontName
                })
            );
        }
    });

    jQuery("#identity_twitchlogocolor").val(window.appSettings.identity.platformColor);
    jQuery("#identity_twitchusername").val(window.appSettings.identity.channelName);
    jQuery("#identity_twitchfulllink")[0].checked = window.appSettings.identity.fullChannelLink;
    jQuery("#identity_custombgimage").val(window.appSettings.identity.backgroundImagePath);
    jQuery("#identity_titlescolor").val(window.appSettings.identity.colors.titles);
    jQuery("#identity_dayoncolor").val(window.appSettings.identity.colors.dayOn);
    jQuery("#identity_dayoffcolor").val(window.appSettings.identity.colors.dayOff);


    let date = Date.now();
    date = addMonths(date, 1);
    let formattedDate = format(date, 'yyyy-MM');
    jQuery('#planning_desiredmonth').val(formattedDate).change();
}

export { initAppValues }