jQuery("#planning_button_previous").click(function () {
    jQuery("#planning").fadeOut("500");
    jQuery("#identity").delay(500).fadeIn("500");
});

jQuery("#planning_button_next").click(function () {
    if (jQuery('#planning_form')[0].checkValidity() && jQuery("#planning_eventlist div.col-sm-4").length > 0) {
        jQuery("#planning_error").addClass("d-none");
        jQuery("#planning").fadeOut("500");
        jQuery("#readyforgeneration").delay(500).fadeIn("500");
    } else {
        var errorMessage = ``;
        jQuery("#planning_error").removeClass("d-none");

        if (!jQuery("#planning_desiredmonth")[0].validity.valid) {
            errorMessage += `Le mois désiré pour le planning n'a pas été renseigné.`;
        }

        if (jQuery("#planning_desiredmonth")[0].validity.valid && jQuery("#planning_eventlist div.col-sm-4").length === 0) {
            if (errorMessage.length > 0) errorMessage += `<br />`;
            errorMessage += `Aucun stream n'a été enregistré pour le mois ciblé.`;
        }

        jQuery("#planning_error").html(errorMessage);
    }
});

jQuery("#planning_desiredmonth").on("change", (event) => {
    if (jQuery("#planning_desiredmonth").val() !== "" && jQuery("#planning_desiredmonth").val() !== undefined) {
        jQuery("#planning_button_addstream").show();

        const splitted = jQuery("#planning_desiredmonth").val().split('-'),
            month = splitted[1],
            year = splitted[0],
            firstDayDate = `${year}-${month}-01`,
            lastDayDate = `${year}-${month}-${new Date(year, month, 0).getDate()}`;

        jQuery("#planning_newstream_date").attr({
            "min" : firstDayDate,
            "max" : lastDayDate
        });
    } else {
        jQuery("#planning_button_addstream").hide();
    }

    jQuery("#planning_eventlist").html("");
});

jQuery("#planning_button_addstream").click(() => {
    const bootstrap = require("bootstrap");
    const modal = new bootstrap.Modal(document.getElementById('planning_newstream_modal'), {
        backdrop: 'static',
        focus: true,
        keyboard: false
    });
    modal.show();
});

function getFirstDayOfMonth(month) {

}