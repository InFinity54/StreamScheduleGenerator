<script setup>
import { useToast } from 'vue-toastification'
import * as bootstrap from 'bootstrap'
import { onMounted } from 'vue'
import { addMonths, format, isFirstDayOfMonth, parseISO } from 'date-fns'
import { fr } from 'date-fns/locale'

const toast = useToast()
let newStreamModalElement
let newStreamModal

onMounted(() => {
  newStreamModalElement = document.getElementById('planning_newstream_modal')
  newStreamModal = new bootstrap.Modal(newStreamModalElement, {})

  let date = Date.now()
  date = addMonths(date, 1)
  document.getElementById('planning_desiredmonth').value = format(date, 'yyyy-MM')
  planningMonthChange()
})

function previousStep() {
  document.getElementById('planning').animate([{ opacity: 1 }, { opacity: 0 }], 500)

  setTimeout(() => {
    document.getElementById('planning').style.display = 'none'
    document.getElementById('identity').style.display = 'block'
    document.getElementById('identity').animate([{ opacity: 0 }, { opacity: 1 }], 500)
  }, 500)
}

function nextStep() {
  if (
    document.getElementById('planning_desiredmonth').value !== '' &&
    document.querySelectorAll('#planning_eventlist .col-sm-4').length >= 1
  ) {
    document.getElementById('planning').animate([{ opacity: 1 }, { opacity: 0 }], 500)

    setTimeout(() => {
      document.getElementById('planning').style.display = 'none'
      //document.getElementById('readyforgeneration').style.display = 'block'
      //document.getElementById('readyforgeneration').animate([{ opacity: 0 }, { opacity: 1 }], 500)
    }, 500)
  } else {
    if (document.getElementById('planning_desiredmonth').value === '') {
      toast.error("Aucun mois n'a été sélectionné pour le planning de stream.")
    } else {
      toast.error('Le planning doit comporter au moins un stream !')
    }
  }
}

function planningMonthChange() {
  if (document.getElementById('planning_desiredmonth').value !== '') {
    const splitted = document.getElementById('planning_desiredmonth').value.split('-')
    const month = splitted[1]
    const year = splitted[0]
    const firstDayDate = `${year}-${month}-01`
    const lastDayDate = `${year}-${month}-${new Date(year, month, 0).getDate()}`

    document.getElementById('planning_button_addstream').style.display = 'block'
    document.getElementById('planning_newstream_date').setAttribute('min', firstDayDate)
    document.getElementById('planning_newstream_date').setAttribute('max', lastDayDate)
    document.getElementById('planning_eventlist').innerHTML = ''
  } else {
    document.getElementById('planning_button_addstream').style.display = 'hidden'
  }
}

function resetModal() {
  document.getElementById('planning_newstream_date').value = ''
  document.getElementById('planning_newstream_date').classList.remove('is-valid')
  document.getElementById('planning_newstream_date').classList.add('is-invalid')
  document.getElementById('planning_newstream_hour').value = ''
  document.getElementById('planning_newstream_hour').classList.remove('is-valid')
  document.getElementById('planning_newstream_hour').classList.add('is-invalid')
  document.getElementById('planning_newstream_game_genshin').checked = false
  document.getElementById('planning_newstream_game_hunt').checked = false
  document.getElementById('planning_newstream_game_lol').checked = false
  document.getElementById('planning_newstream_game_valorant').checked = false
  document.getElementById('planning_newstream_game_wakfu').checked = false
}

function newStream() {
  newStreamModal.show()
}

function addNewStream() {
  if (checkModalForm()) {
    const gameList = getStreamGameList()

    const streamDiv = document.createElement('div')
    streamDiv.className = 'col-sm-4'
    streamDiv.dataset.streamDate = document.getElementById('planning_newstream_date').value
    streamDiv.dataset.streamHour = document.getElementById('planning_newstream_hour').value
    streamDiv.dataset.streamGames = gameList

    const cardDiv = document.createElement('div')
    cardDiv.className = 'card mb-2'
    streamDiv.appendChild(cardDiv)

    const cardBodyDiv = document.createElement('div')
    cardBodyDiv.className = 'card-body'
    cardDiv.appendChild(cardBodyDiv)

    const cardTitle = document.createElement('h5')
    cardTitle.className = 'card-title'
    cardTitle.innerHTML = formatDateToText(document.getElementById('planning_newstream_date').value) + '<br />' + document.getElementById('planning_newstream_hour').value.replace(':', 'h')
    cardBodyDiv.appendChild(cardTitle)

    const cardTextDiv = document.createElement('div')
    cardTextDiv.className = 'card-text'
    cardTextDiv.innerHTML = 'Jeu(x) prévu(s) : '
    cardBodyDiv.appendChild(cardTextDiv)

    gameList.split(',').forEach((game) => {
      const gameIcon = document.createElement('div')
      gameIcon.className = `planning_game_icon planning_game_icon_${game}`
      cardTextDiv.appendChild(gameIcon)
    })

    const deleteButton = document.createElement('button')
    deleteButton.className = 'btn btn-danger'
    deleteButton.type = 'button'
    deleteButton.textContent = 'Supprimer ce stream'
    deleteButton.addEventListener('click', () => { streamDiv.remove() })
    cardBodyDiv.appendChild(deleteButton)

    newStreamModal.toggle()
    document.getElementById('planning_eventlist').appendChild(streamDiv)
    resetModal()
  } else {
    toast.error("Un stream doit comporter au moins un jeu, une date et une heure de début.")
  }
}

function formatDateToText(dateString) {
  const date = parseISO(dateString)
  let formattedDate = format(date, 'EEEE d MMMM yyyy', { locale: fr })

  if (isFirstDayOfMonth(date)) {
    formattedDate = formattedDate.replace(' 1 ', ' 1er ')
  }

  return formattedDate.charAt(0).toUpperCase() + formattedDate.slice(1)
}

function getStreamGameList() {
  var gameList = ''

  if (document.getElementById('planning_newstream_game_genshin').checked) {
    gameList += 'genshin'
  }

  if (document.getElementById('planning_newstream_game_hunt').checked) {
    if (gameList.length > 0) gameList += `,`
    gameList += 'hunt'
  }

  if (document.getElementById('planning_newstream_game_lol').checked) {
    if (gameList.length > 0) gameList += `,`
    gameList += 'lol'
  }

  if (document.getElementById('planning_newstream_game_valorant').checked) {
    if (gameList.length > 0) gameList += `,`
    gameList += 'valorant'
  }

  if (document.getElementById('planning_newstream_game_wakfu').checked) {
    if (gameList.length > 0) gameList += `,`
    gameList += 'wakfu'
  }

  return gameList
}

function checkModalForm() {
  if (document.getElementById('planning_newstream_date').value !== '') {
    document.getElementById('planning_newstream_date').classList.add('is-valid')
    document.getElementById('planning_newstream_date').classList.remove('is-invalid')
  } else {
    document.getElementById('planning_newstream_date').classList.add('is-invalid')
    document.getElementById('planning_newstream_date').classList.remove('is-valid')
  }

  if (document.getElementById('planning_newstream_hour').value !== '') {
    document.getElementById('planning_newstream_hour').classList.add('is-valid')
    document.getElementById('planning_newstream_hour').classList.remove('is-invalid')
  } else {
    document.getElementById('planning_newstream_hour').classList.add('is-invalid')
    document.getElementById('planning_newstream_hour').classList.remove('is-valid')
  }

  if (document.querySelectorAll('#planning_newstream_modal input[type="checkbox"]:checked').length >= 1) {
    document.getElementById('planning_newstream_game_genshin').classList.remove('is-invalid')
    document.getElementById('planning_newstream_game_hunt').classList.remove('is-invalid')
    document.getElementById('planning_newstream_game_lol').classList.remove('is-invalid')
    document.getElementById('planning_newstream_game_valorant').classList.remove('is-invalid')
    document.getElementById('planning_newstream_game_wakfu').classList.remove('is-invalid')
  } else {
    document.getElementById('planning_newstream_game_genshin').classList.add('is-invalid')
    document.getElementById('planning_newstream_game_hunt').classList.add('is-invalid')
    document.getElementById('planning_newstream_game_lol').classList.add('is-invalid')
    document.getElementById('planning_newstream_game_valorant').classList.add('is-invalid')
    document.getElementById('planning_newstream_game_wakfu').classList.add('is-invalid')
  }

  return (
    document.getElementById('planning_newstream_date').value !== '' &&
    document.getElementById('planning_newstream_hour').value !== '' &&
    document.querySelectorAll('#planning_newstream_modal input[type="checkbox"]:checked').length >= 1
  )
}
</script>

<template>
  <div id="planning" class="step">
    <div class="step_title">
      <h1>Planning</h1>
    </div>

    <div class="step_content">
      <form id="planning_form">
        <div class="row">
          <div class="col-sm-12">
            Le moment important est arrivé : il faut désormais déterminer le contenu du planning.
            <br />
            Première question : pour quel mois souhaites-tu créer un planning ?
            <input type="month" id="planning_desiredmonth" class="align-middle" required @change="planningMonthChange" />
            <br />
            Une fois le mois sélectionné, utilise le bouton en bas à gauche de la fenêtre pour créer
            des streams pour ce mois. Tous les streams créés seront ensuite listés ci-dessous. Tu
            peux ajouter les streams dans le désordre, mais tu ne peux pas ajouter plus d'un stream
            par jour !
          </div>
        </div>
      </form>

      <div id="planning_eventlist" class="row row-cols-3 p-2"></div>
    </div>

    <div class="step_leftmenu">
      <button class="btn btn-primary" type="button" id="planning_button_addstream" @click="newStream">Ajouter un nouveau stream</button>
    </div>

    <div class="step_menu">
      <button class="btn btn-secondary mr-5" type="button" id="planning_button_previous" @click="previousStep">&laquo; Précédent</button>
      <button class="btn btn-primary" type="button" id="planning_button_next" @click="nextStep">Suivant &raquo;</button>
    </div>
  </div>

  <div class="modal fade" id="planning_newstream_modal" tabindex="-1">
    <div class="modal-dialog modal-xl modal-dialog-centered">
      <div class="modal-content">
        <div class="modal-header">
          <h1 class="modal-title fs-5" id="planning_newstream_modal_title">
            Ajouter un nouveau stream
          </h1>
        </div>

        <div class="modal-body">
          <p>Pour ajouter un nouveau stream, sélectionne la date et l'heure où le stream aura lieu, ainsi que le ou les jeux qui seront diffusés. Sauvegarde ensuite le stream pour le voir apparaître dans la liste.</p>

          <div id="planning_newstream_modal_error" class="d-none alert alert-danger"></div>

          <form id="planning_newstream_modal_form">
            <div class="row">
              <div class="col-sm-6">
                <div class="form-floating">
                  <input type="date" class="form-control" required id="planning_newstream_date" @change="checkModalForm" />
                  <label for="planning_newstream_date">Date du stream</label>
                </div>
              </div>

              <div class="col-sm-6">
                <div class="form-floating">
                  <input type="time" class="form-control" required id="planning_newstream_hour" @change="checkModalForm" />
                  <label for="planning_newstream_hour">Heure du stream</label>
                </div>
              </div>
            </div>

            <div class="row mt-2">
              <div class="col-sm-12">
                Jeux

                <br />

                <div class="form-check form-check-inline">
                  <input class="form-check-input" type="checkbox" id="planning_newstream_game_genshin" value="genshin" @change="checkModalForm" />
                  <label class="form-check-label" for="planning_newstream_game_genshin">Genshin Impact</label>
                </div>

                <div class="form-check form-check-inline">
                  <input class="form-check-input" type="checkbox" id="planning_newstream_game_hunt" value="hunt" @change="checkModalForm" />
                  <label class="form-check-label" for="planning_newstream_game_hunt">Hunt: Showdown</label>
                </div>

                <div class="form-check form-check-inline">
                  <input class="form-check-input" type="checkbox" id="planning_newstream_game_lol" value="lol" @change="checkModalForm" />
                  <label class="form-check-label" for="planning_newstream_game_lol">League of Legends</label>
                </div>

                <div class="form-check form-check-inline">
                  <input class="form-check-input" type="checkbox" id="planning_newstream_game_valorant" value="valorant" @change="checkModalForm" />
                  <label class="form-check-label" for="planning_newstream_game_valorant">Valorant</label>
                </div>

                <div class="form-check form-check-inline">
                  <input class="form-check-input" type="checkbox" id="planning_newstream_game_wakfu" value="wakfu" @change="checkModalForm" />
                  <label class="form-check-label" for="planning_newstream_game_wakfu">Wakfu</label>
                </div>
              </div>
            </div>
          </form>
        </div>

        <div class="modal-footer">
          <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Annuler</button>
          <button type="button" class="btn btn-primary" id="planning_newstream_modal_add" @click="addNewStream">Ajouter le stream</button>
        </div>
      </div>
    </div>
  </div>
</template>

<style scoped lang="scss">
#planning {
  display: none;

  #planning_eventlist {
    :deep(.planning_game_icon) {
      display: inline-block;
      width: 70px;
      height: 70px;
      background-repeat: no-repeat;
      background-size: cover;
      background-position: center center;
      vertical-align: middle;
    }

    :deep(.planning_game_icon_genshin) {
      background-image: url('../../assets/games/genshin/game_genshin_icon.jpg');
    }

    :deep(.planning_game_icon_hunt) {
      background-image: url('../../assets/games/hunt/game_hunt_icon.png');
    }

    :deep(.planning_game_icon_lol) {
      background-image: url('../../assets/games/lol/game_lol_icon.png');
    }

    :deep(.planning_game_icon_valorant) {
      background-image: url('../../assets/games/valorant/game_valorant_icon.png');
    }

    :deep(.planning_game_icon_wakfu) {
      background-image: url('../../assets/games/wakfu/game_wakfu_icon.png');
    }
  }

  #planning_button_addstream {
    display: none;
  }
}
</style>
