jQuery("#identity_button_previous").click(function () {
    jQuery("#identity").fadeOut("500");
    jQuery("#introduction").delay(500).fadeIn("500");
});

jQuery("#identity_button_next").click(function () {
    if (jQuery('#identity_form')[0].checkValidity()) {
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

        if (!jQuery("#identity_dayoffcontrastcolor")[0].validity.valid) {
            if (errorMessage.length > 0) errorMessage += `<br />`;
            errorMessage += `La couleur contrastée des jours OFF n'a pas été renseignée.`;
        }

        jQuery("#identity_error").html(errorMessage);
    }
});

window.appAPI.fontsList((event, fonts) => {
    for (var font in fonts) {
        jQuery('#identity_font').append(
            jQuery('<option>', {
                value: fonts[font].replaceAll("\"", ""),
                text: fonts[font].replaceAll("\"", "")
            })
        );
    }
});