jQuery("#generationerror_button_quit").click(function () {
    window.windowAPI.windowClose();
});

jQuery("#generationerror_button_retry").click(function () {
    jQuery("#generationerror").fadeOut("500");
    jQuery("#identity").delay(500).fadeIn("500");
});