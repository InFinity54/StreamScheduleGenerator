import { format, getWeeksInMonth, parseISO, startOfWeek, endOfWeek, addDays, isSameMonth } from 'date-fns';
import { fr } from 'date-fns/locale';

jQuery("#readyforgeneration_button_previous").click(function () {
    jQuery("#readyforgeneration").fadeOut("500");
    jQuery("#planning").delay(500).fadeIn("500");
});

jQuery("#readyforgeneration_button_next").click(function () {
    jQuery("#readyforgeneration").hide();
    generatePlanning();
});

function generatePlanning() {
    var planningHtml = generatePlanningTitle();
    planningHtml += generateChannelLink();
    planningHtml += generatePlanningTable();

    jQuery("#windowButtons").hide();
    window.resizeTo(1920, 1080);
    jQuery("#generatedplanning").html(planningHtml);

    window.electron.openImage(window.appSettings.identity.backgroundImagePath)
        .then(image => jQuery("#generatedplanning").css("background-image", `url('${image}')`));

    jQuery("#generatedplanning").show();

    setTimeout(() => {
        window.electron.takeScreenshot(jQuery("#identity_savepath").val()).then(success => {
            window.resizeTo(1280, 720);
            window.windowAPI.windowRecenter();
            jQuery("#generatedplanning").hide();

            if (success) {
                jQuery("#generationsuccess_savepath").html(jQuery("#identity_savepath").val());
                jQuery("#generationsuccess").show();
            } else {
                jQuery("#windowButtons").show();
                jQuery("#generationerror").show();
            }
        })
    }, 5000);
}

function generatePlanningTitle() {
    const date = parseISO(jQuery("#planning_desiredmonth").val() + "-01");
    let formattedDate = format(date, 'MMMM yyyy', { locale: fr });

    return `<div id="generatedplanning_title" style="font-family: '${jQuery("#identity_font").val()}'; color: ${jQuery("#identity_titlescolor").val()};">PLANNING - ${formattedDate.toUpperCase()}</div>`;
}

function generateChannelLink() {
    var channelLink = `<div id="generatedplanning_channellink" class="platform_twitch ${jQuery("#identity_twitchlogocolor").val()}">`;
    channelLink += `<div id="generatedplanning_channellink_platformicon"></div>`;
    channelLink += `<div id="generatedplanning_channellink_text" style="font-size: '${jQuery("#identity_font").val()}';">`;

    if (jQuery("#identity_twitchfulllink").checked) {
        channelLink += `twitch.tv/${jQuery("#identity_twitchusername").val()}</div>`;
    } else {
        channelLink += `${jQuery("#identity_twitchusername").val()}</div>`;
    }

    channelLink += `</div>`;

    return channelLink;
}

function generatePlanningTable() {
    const firstDay = parseISO(jQuery("#planning_desiredmonth").val() + "-01");
    const weeksInMonth = getWeeksInMonth(jQuery("#planning_desiredmonth").val());
    var planningTable = `<div id="generatedplanning_table">`;

    planningTable += `<div class="row">`;
    planningTable += `<div class="col-sm-3" style="padding: 0 !important; margin: 0 10px 0 0 !important;"> </div>`;
    planningTable += `<div class="col text-center" style="font-family: '${jQuery("#identity_font").val()}'; width: 150px !important; max-width: 150px; padding: 0 !important; margin: 0 10px 0 0 !important; color: ${jQuery("#identity_titlescolor").val()};">Lundi</div>`;
    planningTable += `<div class="col text-center" style="font-family: '${jQuery("#identity_font").val()}'; width: 150px !important; max-width: 150px; padding: 0 !important; margin: 0 10px 0 0 !important; color: ${jQuery("#identity_titlescolor").val()};">Mardi</div>`;
    planningTable += `<div class="col text-center" style="font-family: '${jQuery("#identity_font").val()}'; width: 150px !important; max-width: 150px; padding: 0 !important; margin: 0 10px 0 0 !important; color: ${jQuery("#identity_titlescolor").val()};">Mercredi</div>`;
    planningTable += `<div class="col text-center" style="font-family: '${jQuery("#identity_font").val()}'; width: 150px !important; max-width: 150px; padding: 0 !important; margin: 0 10px 0 0 !important; color: ${jQuery("#identity_titlescolor").val()};">Jeudi</div>`;
    planningTable += `<div class="col text-center" style="font-family: '${jQuery("#identity_font").val()}'; width: 150px !important; max-width: 150px; padding: 0 !important; margin: 0 10px 0 0 !important; color: ${jQuery("#identity_titlescolor").val()};">Vendredi</div>`;
    planningTable += `<div class="col text-center" style="font-family: '${jQuery("#identity_font").val()}'; width: 150px !important; max-width: 150px; padding: 0 !important; margin: 0 10px 0 0 !important; color: ${jQuery("#identity_titlescolor").val()};">Samedi</div>`;
    planningTable += `<div class="col text-center" style="font-family: '${jQuery("#identity_font").val()}'; width: 150px !important; max-width: 150px; padding: 0 !important; margin: 0 10px 0 0 !important; color: ${jQuery("#identity_titlescolor").val()};">Dimanche</div>`;
    planningTable += `</div>`;

    for (var week = 0; week < weeksInMonth; week++) {
        const firstDayOfWeek = startOfWeek(addDays(firstDay, week * 7), { weekStartsOn: 1 });
        const lastDayOfWeek = endOfWeek(addDays(firstDay, week * 7), { weekStartsOn: 1 });

        planningTable += `<div class="row mt-2">`;
        planningTable += `<div class="col-sm-3 text-right lh-150" style="font-family: '${jQuery("#identity_font").val()}'; padding: 0 !important; margin: 0 10px 0 0 !important; color: ${jQuery("#identity_titlescolor").val()};">Semaine du ${format(firstDayOfWeek, 'd MMMM', { locale: fr })} au ${format(lastDayOfWeek, 'd MMMM', { locale: fr })}</div>`;

        for (var day = 1; day <= 7; day++) {
            const currentDay = addDays(firstDayOfWeek, day - 1);

            if (isSameMonth(currentDay, jQuery("#planning_desiredmonth").val() + "-01")) {
                planningTable += generateDay(currentDay);
            } else {
                planningTable += `<div class="col text-center" style="width: 150px !important; max-width: 150px; padding: 0 !important; margin: 0 10px 0 0 !important;"></div>`;
            }
        }

        planningTable += `</div>`;
    }

    return planningTable;
}

function generateDay(targetedDay) {
    const currentDay = format(targetedDay, 'u-MM-dd');
    const streamOfTheDay = jQuery('#planning_eventlist').find('div[data-stream-date="' + currentDay + '"]');
    let dayContent = `<div class="col text-center" style="font-family: '${jQuery("#identity_font").val()}'; width: 150px !important; max-width: 150px; padding: 0 !important; margin: 0 10px 0 0 !important;`;

    if (streamOfTheDay.length > 0) {
        const games = streamOfTheDay.data("stream-games").split(",");

        dayContent += ` color: ${jQuery("#identity_dayoncolor").val()};">`;

        if (games.length === 3) {
            dayContent += `<div class="stream_triple">`;
                dayContent += `<div class="game game_${games[0]}">`;
                    dayContent += `<div class="game_background"></div>`;
                    dayContent += `<div class="game_icon"></div>`;
                dayContent += `</div>`;
                dayContent += `<div class="game game_${games[1]}">`;
                    dayContent += `<div class="game_background"></div>`;
                    dayContent += `<div class="game_icon"></div>`;
                dayContent += `</div>`;
                dayContent += `<div class="game game_${games[2]}">`;
                    dayContent += `<div class="game_background"></div>`;
                    dayContent += `<div class="game_icon"></div>`;
                dayContent += `</div>`;
                dayContent += `<div class="stream_hour">${streamOfTheDay.data("stream-hour")}</div>`;
            dayContent += `</div>`;
        } else if (games.length === 2) {
            dayContent += `<div class="stream_double">`;
                dayContent += `<div class="game game_${games[0]}">`;
                    dayContent += `<div class="game_background"></div>`;
                    dayContent += `<div class="game_icon"></div>`;
                dayContent += `</div>`;
                dayContent += `<div class="game game_${games[1]}">`;
                    dayContent += `<div class="game_background"></div>`;
                    dayContent += `<div class="game_icon"></div>`;
                dayContent += `</div>`;
                dayContent += `<div class="stream_hour">${streamOfTheDay.data("stream-hour")}</div>`;
            dayContent += `</div>`;
        } else {
            dayContent += `<div class="stream_single">`;
                dayContent += `<div class="game_${games[0]}">`;
                    dayContent += `<div class="game_background"></div>`;
                    dayContent += `<div class="game_icon"></div>`;
                dayContent += `</div>`;
                dayContent += `<div class="stream_hour">${streamOfTheDay.data("stream-hour")}</div>`;
            dayContent += `</div>`;
        }

        dayContent += `</div>`;
    } else {
        dayContent += ` color: ${jQuery("#identity_dayoffcolor").val()};">OFF</div>`;
    }

    return dayContent;
}