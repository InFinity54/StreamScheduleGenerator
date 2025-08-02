import * as fs from 'fs'
const mime = require('mime-types')
import { addDays, startOfWeek, endOfWeek, format, getWeeksInMonth, parseISO, isSameMonth } from 'date-fns'
import { fr } from 'date-fns/locale'
import * as settings from 'electron-settings'
import { getAssetPath } from './index'

const twitchPurple = `${getAssetPath('platforms', 'twitch', 'platform_twitch_default.png')}`
const twitchWhite = `${getAssetPath('platforms', 'twitch', 'platform_twitch_white.png')}`
const twitchBlack = `${getAssetPath('platforms', 'twitch', 'platform_twitch_black.png')}`
const GenshinIcon = `${getAssetPath('games', 'genshin', 'game_genshin_icon.jpg')}`
const GenshinWallpaper = `${getAssetPath('games', 'genshin', 'game_genshin_wallpaper.jpg')}`
const HuntIcon = `${getAssetPath('games', 'hunt', 'game_hunt_icon.png')}`
const HuntWallpaper = `${getAssetPath('games', 'hunt', 'game_hunt_wallpaper.jpg')}`
const LoLIcon = `${getAssetPath('games', 'lol', 'game_lol_icon.png')}`
const LoLWallpaper = `${getAssetPath('games', 'lol', 'game_lol_wallpaper.png')}`
const ValorantIcon = `${getAssetPath('games', 'valorant', 'game_valorant_icon.png')}`
const ValorantWallpaper = `${getAssetPath('games', 'valorant', 'game_valorant_wallpaper.jpg')}`
const WakfuIcon = `${getAssetPath('games', 'wakfu', 'game_wakfu_icon.png')}`
const WakfuWallpaper = `${getAssetPath('games', 'wakfu', 'game_wakfu_wallpaper.jpg')}`

function base64_encode(file) {
  const bitmap = fs.readFileSync(file)
  const content = new Buffer.from(bitmap).toString('base64')
  const type = mime.lookup(file)
  return `data:${type};base64,${content}`
}

function generatePlanning(config) {
  return `
    <!DOCTYPE html>
    <html lang="fr">
      <head>
        <title>Planning</title>
        <meta charset="UTF-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1.0" />
        <style>${generateStyle(config)}</style>
      </head>
      <body>
        ${generateContent(config)}
      </body>
    </html>
  `
}

function generateStyle(config) {
  let css = `
    body {
        width: 100vw;
        height: 100vh;
        background-image: url("${base64_encode(settings.getSync('backgroundImagePath'))}");
        background-attachment: fixed;
        background-repeat: no-repeat;
        background-position: center center;
        background-size: cover;
        overflow: hidden;
    }

    .text-center {
      text-align: center;
    }

    #title {
        position: absolute;
        top: 40px;
        left: 40px;
        font-size: 45px;
        font-weight: bold;
    }

    #channellink {
        position: absolute;
        top: 40px;
        right: 40px;
    }

    #channellink #channellink_platformicon {
        display: inline-block;
        width: 50px;
        height: 50px;
        background-repeat: no-repeat;
        background-position: center center;
        background-size: auto 100%;
        vertical-align: middle;
    }
  `

  if (settings.getSync('platformColor') === "white") {
    css += `
      #channellink.platform_twitch.white * {
          color: #FFFFFF;
      }

      #channellink.platform_twitch.white #channellink_platformicon {
          background-image: url("${base64_encode(twitchWhite)}");
      }
    `
  } else if (settings.getSync('platformColor') === "black") {
    css += `
      #channellink.platform_twitch.black * {
          color: #000000;
      }

      #channellink.platform_twitch.black #channellink_platformicon {
          background-image: url("${base64_encode(twitchBlack)}");
      }
    `
  } else {
    css += `
      #channellink.platform_twitch.purple * {
          color: #8205B4;
      }

      #channellink.platform_twitch.purple #channellink_platformicon {
          background-image: url("${base64_encode(twitchPurple)}");
      }
    `
  }

  css += `
    #channellink #channellink_text {
        display: inline-block;
        margin-left: 10px;
        vertical-align: middle;
        font-weight: bold;
        font-size: 30px;
    }

    #planning {
        position: absolute;
        top: 50%;
        left: 50%;
        width: 80vw;
        transform: translate(-50%, -50%);
    }

    #planning .row {
      display: flex;
      justify-content: center;
      align-items: center;
    }

    .stream_off, .stream_single, .stream_double, .stream_triple {
        position: relative;
        top: 0;
        left: 0;
        width: 150px;
        height: 150px;
    }

    .stream_off {
        position: relative;
        top: 0;
        left: 0;
        width: 150px;
        height: 150px;
        line-height: 150px;
    }

    .stream_single .game_icon {
        top: 75px;
        left: 75px;
        width: 100px;
        height: 100px;
    }

    .stream_single .game_background {
        width: 150px;
        height: 150px;
    }

    .stream_double .game:nth-child(0) {
        position: absolute;
        top: 0;
        left: 0;
    }

    .stream_double .game:nth-child(1) {
        position: absolute;
        top: 0;
        left: 75px;
    }

    .stream_double .game_icon {
        top: 75px;
        left: 38px;
        width: 50px;
        height: 50px;
    }

    .stream_double .game_background {
        width: 75px;
        height: 150px;
    }

    .stream_triple .game:nth-child(0) {
        position: absolute;
        top: 0;
        left: 0;
    }

    .stream_triple .game:nth-child(1) {
        position: absolute;
        top: 0;
        left: 50px;
    }

    .stream_triple .game:nth-child(2) {
        position: absolute;
        top: 0;
        left: 100px;
    }

    .stream_triple .game_icon {
        top: 75px;
        left: 25px;
        width: 33px;
        height: 33px;
    }

    .stream_triple .game_background {
        width: 50px;
        height: 150px;
    }

    .stream_hour {
        position: absolute;
        bottom: 5px;
        left: 0;
        width: 100%;
        text-align: center;
    }

    .game_icon {
        position: relative;
        background-position: center center;
        background-repeat: no-repeat;
        background-size: cover;
        transform: translate(-50%, -50%);
    }

    .game_background {
        position: absolute;
        top: 0;
        left: 0;
        background-position: center center;
        background-repeat: no-repeat;
        background-size: cover;
    }
  `

  config.selectedGames.forEach((game) => {
    if (game === "genshin") {
      css += `
      .game_genshin .game_icon {
          background-image: url("${base64_encode(GenshinIcon)})");
      }

      .game_genshin .game_background {
          background-image: url("${base64_encode(GenshinWallpaper)}");
      }
    `
    } else if (game === "hunt") {
      css += `
      .game_hunt .game_icon {
          background-image: url("${base64_encode(HuntIcon)}");
      }

      .game_hunt .game_background {
          background-image: url("${base64_encode(HuntWallpaper)}");
      }
    `
    } else if (game === "lol") {
      css += `
      .game_lol .game_icon {
          background-image: url("${base64_encode(LoLIcon)}");
      }

      .game_lol .game_background {
          background-image: url("${base64_encode(LoLWallpaper)}");
      }
    `
    } else if (game === "valorant") {
      css += `
      .game_valorant .game_icon {
          background-image: url("${base64_encode(ValorantIcon)}");
      }

      .game_valorant .game_background {
          background-image: url("${base64_encode(ValorantWallpaper)}");
      }
    `
    } else if (game === "wakfu") {
      css += `
      .game_wakfu .game_icon {
          background-image: url("${base64_encode(WakfuIcon)}");
      }

      .game_wakfu .game_background {
          background-image: url("${base64_encode(WakfuWallpaper)}");
      }
    `
    }
  })

  return css
}

function generateContent(config) {
  let htmlBody = generateTitle(config.date, settings.getSync('fontName'), settings.getSync('titlesColor'))
  htmlBody += generateChannelLink(settings.getSync('platformColor'), settings.getSync('fontName'), settings.getSync('channelName'), settings.getSync('fullChannelLink'))
  htmlBody += generatePlanningTable(config)
  return htmlBody
}

function generateTitle(date, font, titleColor) {
  let formattedDate = format(parseISO(date + "-01"), 'MMMM yyyy', { locale: fr })
  return `<div id="title" style="font-family: '${font}'; color: ${titleColor};">PLANNING - ${formattedDate.toUpperCase()}</div>`
}

function generateChannelLink(platformColor, font, username, fullLink = false) {
  let channelLink = `<div id="channellink" class="platform_twitch ${platformColor}">`
  channelLink += `<div id="channellink_platformicon"></div>`
  channelLink += `<div id="channellink_text" style="font-family: '${font}';">`
  channelLink += fullLink ? `twitch.tv/${username}` : `${username}`
  channelLink += `</div></div>`
  return channelLink
}

function generatePlanningTable(config) {
  const firstDay = parseISO(config.date + "-01")
  const weeksInMonth = getWeeksInMonth(firstDay)
  let planningTable = `<div id="planning">`

  planningTable += `<div class="row">`
  planningTable += `<div class="col-sm-3" style="width: 220px; padding: 0 !important; margin: 0 10px 0 0 !important;"> </div>`
  planningTable += `<div class="col text-center" style="font-family: '${settings.getSync('fontName')}'; width: 150px !important; max-width: 150px; padding: 0 !important; margin: 0 10px 0 0 !important; color: ${settings.getSync('titlesColor')};">Lundi</div>`
  planningTable += `<div class="col text-center" style="font-family: '${settings.getSync('fontName')}'; width: 150px !important; max-width: 150px; padding: 0 !important; margin: 0 10px 0 0 !important; color: ${settings.getSync('titlesColor')};">Mardi</div>`
  planningTable += `<div class="col text-center" style="font-family: '${settings.getSync('fontName')}'; width: 150px !important; max-width: 150px; padding: 0 !important; margin: 0 10px 0 0 !important; color: ${settings.getSync('titlesColor')};">Mercredi</div>`
  planningTable += `<div class="col text-center" style="font-family: '${settings.getSync('fontName')}'; width: 150px !important; max-width: 150px; padding: 0 !important; margin: 0 10px 0 0 !important; color: ${settings.getSync('titlesColor')};">Jeudi</div>`
  planningTable += `<div class="col text-center" style="font-family: '${settings.getSync('fontName')}'; width: 150px !important; max-width: 150px; padding: 0 !important; margin: 0 10px 0 0 !important; color: ${settings.getSync('titlesColor')};">Vendredi</div>`
  planningTable += `<div class="col text-center" style="font-family: '${settings.getSync('fontName')}'; width: 150px !important; max-width: 150px; padding: 0 !important; margin: 0 10px 0 0 !important; color: ${settings.getSync('titlesColor')};">Samedi</div>`
  planningTable += `<div class="col text-center" style="font-family: '${settings.getSync('fontName')}'; width: 150px !important; max-width: 150px; padding: 0 !important; margin: 0 10px 0 0 !important; color: ${settings.getSync('titlesColor')};">Dimanche</div>`
  planningTable += `</div>`

  for (let week = 0; week < weeksInMonth; week++) {
    const firstDayOfWeek = startOfWeek(addDays(firstDay, week * 7), { weekStartsOn: 1 })
    const lastDayOfWeek = endOfWeek(addDays(firstDay, week * 7), { weekStartsOn: 1 })

    planningTable += `<div class="row mt-2">`
    planningTable += `<div class="col-sm-3 text-right lh-150" style="width: 220px; font-family: '${settings.getSync('fontName')}'; padding: 0 !important; margin: 0 10px 0 0 !important; color: ${settings.getSync('titlesColor')};">Semaine du ${format(firstDayOfWeek, 'd MMMM', { locale: fr })} au ${format(lastDayOfWeek, 'd MMMM', { locale: fr })}</div>`

    for (let day = 1; day <= 7; day++) {
      const currentDay = addDays(firstDayOfWeek, day - 1)

      if (isSameMonth(currentDay, config.date + "-01")) {
        planningTable += generateDay(currentDay, config)
      } else {
        planningTable += `<div class="col text-center" style="width: 150px !important; max-width: 150px; padding: 0 !important; margin: 0 10px 0 0 !important;"></div>`
      }
    }

    planningTable += `</div>`
  }

  planningTable += `</div>`
  return planningTable
}

function generateDay(targetedDay, config) {
  const currentDay = format(targetedDay, 'u-MM-dd')
  let dayContent = `<div class="col text-center" style="font-family: '${settings.getSync('fontName')}'; width: 150px !important; max-width: 150px; padding: 0 !important; margin: 0 10px 0 0 !important;`

  if (typeof config.streams[currentDay] !== 'undefined') {
    dayContent += ` color: ${settings.getSync('dayOnColor')};">`

    if (config.streams[currentDay].games.length === 3) {
      dayContent += `<div class="stream_triple">`
      dayContent += `<div class="game game_${config.streams[currentDay].games[0]}">`
      dayContent += `<div class="game_background"></div>`
      dayContent += `<div class="game_icon"></div>`
      dayContent += `</div>`
      dayContent += `<div class="game game_${config.streams[currentDay].games[1]}">`
      dayContent += `<div class="game_background"></div>`
      dayContent += `<div class="game_icon"></div>`
      dayContent += `</div>`
      dayContent += `<div class="game game_${config.streams[currentDay].games[2]}">`
      dayContent += `<div class="game_background"></div>`
      dayContent += `<div class="game_icon"></div>`
      dayContent += `</div>`
      dayContent += `<div class="stream_hour">${config.streams[currentDay].hour}</div>`
      dayContent += `</div>`
    } else if (config.streams[currentDay].games.length === 2) {
      dayContent += `<div class="stream_double">`
      dayContent += `<div class="game game_${config.streams[currentDay].games[0]}">`
      dayContent += `<div class="game_background"></div>`
      dayContent += `<div class="game_icon"></div>`
      dayContent += `</div>`
      dayContent += `<div class="game game_${config.streams[currentDay].games[1]}">`
      dayContent += `<div class="game_background"></div>`
      dayContent += `<div class="game_icon"></div>`
      dayContent += `</div>`
      dayContent += `<div class="stream_hour">${config.streams[currentDay].hour}</div>`
      dayContent += `</div>`
    } else {
      dayContent += `<div class="stream_single">`
      dayContent += `<div class="game_${config.streams[currentDay].games[0]}">`
      dayContent += `<div class="game_background"></div>`
      dayContent += `<div class="game_icon"></div>`
      dayContent += `</div>`
      dayContent += `<div class="stream_hour">${config.streams[currentDay].hour}</div>`
      dayContent += `</div>`
    }

    dayContent += `</div>`
  } else {
    dayContent += ` color: ${settings.getSync('dayOffColor')};"><div class="stream_off">OFF</div></div>`
  }

  return dayContent
}

export { generatePlanning }
