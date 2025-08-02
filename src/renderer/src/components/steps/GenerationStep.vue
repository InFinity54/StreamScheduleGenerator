<script setup>
function previousStep() {
  document.getElementById('readyforgeneration').animate([{ opacity: 1 }, { opacity: 0 }], 500)

  setTimeout(() => {
    document.getElementById('readyforgeneration').style.display = 'none'
    document.getElementById('planning').style.display = 'block'
    document.getElementById('planning').animate([{ opacity: 0 }, { opacity: 1 }], 500)
  }, 500)
}

function generatePlanning() {
  document.getElementById('readyforgeneration').animate([{ opacity: 1 }, { opacity: 0 }], 500)

  setTimeout(async () => {
    let planning = {
      date: document.getElementById('planning_desiredmonth').value,
      destFile: document.getElementById('identity_savepath').value,
      streams: {}
    }

    document.getElementById('readyforgeneration').style.display = 'none'
    document.getElementById('generationinprogress').style.display = 'block'
    document.getElementById('generationinprogress').animate([{ opacity: 0 }, { opacity: 1 }], 500)

    Array.from(document.getElementById('planning_eventlist').children).forEach((stream) => {
      planning.streams[stream.dataset.streamDate] = {
        date: stream.dataset.streamDate,
        hour: stream.dataset.streamHour,
        games: stream.dataset.streamGames.split(',')
      }
    })

    const generationSuccess = await window.api.generatePlanning(planning)
    document.getElementById('generationinprogress').animate([{ opacity: 1 }, { opacity: 0 }], 500)

    if (!generationSuccess) {
      setTimeout(() => {
        document.getElementById('generationinprogress').style.display = 'none'
        document.getElementById('generationerror').style.display = 'block'
        document.getElementById('generationerror').animate([{ opacity: 0 }, { opacity: 1 }], 500)
      }, 500)
    } else {
      setTimeout(() => {
        document.getElementById('generationinprogress').style.display = 'none'
        document.getElementById('generationsuccess').style.display = 'block'
        document.getElementById('generationsuccess').animate([{ opacity: 0 }, { opacity: 1 }], 500)
      }, 500)
    }
  }, 500)
}

function exitApp() {
  window.electron.ipcRenderer.send('windowClose')
}
</script>

<template>
  <div id="readyforgeneration" class="vw-100 vh-100">
    <div class="position-absolute top-50 start-50 translate-middle text-center w-100">
      <div id="readyforgeneration_icon"></div>

      <p>
        Tout est prêt pour générer le planning ! 🥳
        <br />
        Dès que tu le souhaites, clique sur le bouton pour lancer la création du planning.
        <br />
        Tu peux également revenir en arrière si tu souhaites effectuer des modifications.
      </p>

      <p>
        Si le fichier de destination du planning existe déjà, veille à ce qu'il ne soit pas utilisé pendant la génération. Sinon, elle échouera.
        <br />
        La génération ne prend généralement que quelques secondes.
        <br />
        <b><u>Ne quitte pas l'application pendant ce temps.</u></b>
      </p>
    </div>

    <div class="position-absolute" style="bottom: 10px; right: 10px">
      <button class="btn btn-secondary mr-5" type="button" id="readyforgeneration_button_previous" @click="previousStep">Revenir en arrière</button>
      <button class="btn btn-primary" type="button" id="readyforgeneration_button_next" @click="generatePlanning">Générer le planning</button>
    </div>
  </div>

  <div id="generationinprogress" class="vw-100 vh-100">
    <div class="position-absolute top-50 start-50 translate-middle text-center w-100">
      <div class="spinner-border" role="status">
        <span class="visually-hidden">Loading...</span>
      </div>
      <p>Génération du planning...</p>
    </div>
  </div>

  <div id="generationsuccess" class="vw-100 vh-100">
    <div class="position-absolute top-50 start-50 translate-middle text-center w-100">
      <div id="generationsuccess_icon"></div>

      <p>Le planning a été généré et exporté avec succès ! ✅</p>

      <p>
        Il a été enregistré à l'emplacement que tu as demandé, c'est-à-dire :
        <br />
        <span id="generationsuccess_savepath"></span>
      </p>
    </div>

    <div class="position-absolute" style="bottom: 10px; right: 10px">
      <button class="btn btn-primary" type="button" id="generationsuccess_button_quit" @click="exitApp">Quitter l'application</button>
    </div>
  </div>

  <div id="generationerror" class="vw-100 vh-100">
    <div class="position-absolute top-50 start-50 translate-middle text-center w-100">
      <div id="generationerror_icon"></div>

      <p>
        On dirait que tout ne s'est pas passé comme prévu. 😭
        <br />
        Le programme n'a pas réussi à exporter le planning...
      </p>

      <p>Tu peux réessayer, ou quitter le programme, grâce aux boutons ci-dessous.</p>
    </div>

    <div class="position-absolute" style="bottom: 10px; right: 10px">
      <button class="btn btn-secondary mr-5" type="button" id="generationerror_button_quit" @click="exitApp">Quitter</button>
      <button class="btn btn-primary" type="button" id="generationerror_button_retry" @click="generatePlanning">Réessayer</button>
    </div>
  </div>
</template>

<style scoped lang="scss">
#readyforgeneration {
  display: none;

  #readyforgeneration_icon {
    width: 350px;
    height: 350px;
    margin-left: auto;
    margin-right: auto;
    margin-bottom: 15px;
    background-image: url('../../assets/generation_ready.png');
    background-repeat: no-repeat;
    background-size: cover;
    background-position: center center;
    background-attachment: fixed;
  }
}

#generationinprogress {
  display: none;

  .spinner-border {
    width: 6rem;
    height: 6rem;
    margin-bottom: 15px;
  }
}

#generationsuccess {
  display: none;

  #generationsuccess_icon {
    width: 350px;
    height: 350px;
    margin-left: auto;
    margin-right: auto;
    margin-bottom: 15px;
    background-image: url('../../assets/generation_success.png');
    background-repeat: no-repeat;
    background-size: cover;
    background-position: center center;
    background-attachment: fixed;
  }
}

#generationerror {
  display: none;

  #generationerror_icon {
    width: 350px;
    height: 350px;
    margin-left: auto;
    margin-right: auto;
    margin-bottom: 15px;
    background-image: url('../../assets/generation_error.png');
    background-repeat: no-repeat;
    background-size: cover;
    background-position: center center;
    background-attachment: fixed;
  }
}
</style>
