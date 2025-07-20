<script setup lang="ts">
function previousStep() {
  document.getElementById('identity').animate([{ opacity: 1 }, { opacity: 0 }], 500)

  setTimeout(() => {
    document.getElementById('identity').style.display = 'none'
    document.getElementById('introduction').style.display = 'block'
    document.getElementById('introduction').animate([{ opacity: 0 }, { opacity: 1 }], 500)
  }, 500)
}

function nextStep() {
  document.getElementById('identity').animate([{ opacity: 1 }, { opacity: 0 }], 500)

  setTimeout(() => {
    document.getElementById('identity').style.display = 'none'
    //document.getElementById('planning').style.display = 'block'
    //document.getElementById('planning').animate([{ opacity: 0 }, { opacity: 1 }], 500)
  }, 500)
}

function usernameChange() {
  window.settings.set('channelName', document.getElementById('identity_twitchusername').value)
}

function platformLogoColorChange() {
  window.settings.set('platformColor', document.getElementById('identity_twitchlogocolor').value)
}

function fullLinkChange() {
  window.settings.set('fullChannelLink', document.getElementById('identity_twitchfulllink').checked)
}

function fontChange() {
  window.settings.set('fontName', document.getElementById('identity_font').value)
}

function newBgImg() {
  window.api.openDialog('showOpenDialog', {
    properties: ['openFile'],
    filters: [
      {
        name: "Images",
        extensions: ['jpg','jpeg','png'],
      }
    ]
  })
    .then(result => {
      if (!result.canceled) {
        document.getElementById("identity_custombgimage").value = result.filePaths[0];
        bgImgChange()
      } else {
        document.getElementById("identity_custombgimage").value = '';
      }
    });
}

function bgImgChange() {
  window.settings.set('backgroundImagePath', document.getElementById('identity_custombgimage').value)
}

function titlesColorChange() {
  window.settings.set('titlesColor', document.getElementById('identity_titlescolor').value)
}

function dayOnColorChange() {
  window.settings.set('dayOnColor', document.getElementById('identity_dayoncolor').value)
}

function dayOffColorChange() {
  window.settings.set('dayOffColor', document.getElementById('identity_dayoffcolor').value)
}

function newDestFile() {
  window.api.openDialog('showSaveDialog', {
    properties: ['openFile'],
    filters: [
      {
        name: "Image JPG",
        extensions: ['jpg'],
      }
    ]
  })
    .then(result => {
      if (!result.canceled) {
        document.getElementById("identity_savepath").value = result.filePath;
      } else {
        document.getElementById("identity_savepath").value = '';
      }
    });
}
</script>

<template>
  <div id="identity" class="step">
    <div class="step_title">
      <h1>Identité et apparence</h1>
    </div>

    <div class="step_content">
      <p>Commençons par les informations essentielles : pour générer ton planning, il faut que tu définisses ta chaîne Twitch (et comment tu veux qu'elle apparaisse), et l'apparence globale du planning. Son contenu sera déterminé plus tard.</p>

      <div id="identity_error" class="d-none alert alert-danger"></div>

      <form id="identity_form">
        <div class="row">
          <div class="col-sm-6">
            <div class="form-floating">
              <input id="identity_twitchusername" type="text" class="form-control" required @change="usernameChange">
              <label for="identity_twitchusername">Nom d'utilisateur Twitch</label>
            </div>
          </div>

          <div class="col-sm-6">
            <div class="form-floating">
              <select id="identity_twitchlogocolor" required class="form-select" @change="platformLogoColorChange">
                <option value="purple" selected>Violet</option>
                <option value="white">Blanc</option>
                <option value="black">Noir</option>
              </select>
              <label for="identity_twitchlogocolor">Couleur du logo de Twitch</label>
            </div>
          </div>
        </div>

        <div class="row mt-3">
          <div class="col-sm-12">
            <div class="form-check form-switch">
              <input id="identity_twitchfulllink" class="form-check-input" type="checkbox" role="switch" @change="fullLinkChange">
              <label for="identity_twitchfulllink" class="form-check-label">Afficher le lien complet vers la chaîne Twitch</label>
            </div>
          </div>
        </div>

        <div class="row mt-3">
          <div class="col-sm-12">
            <div class="form-floating">
              <select id="identity_font" class="form-select" required @change="fontChange">
                <option hidden selected></option>
              </select>
              <label for="identity_font">Police d'écriture</label>
            </div>
          </div>
        </div>

        <div class="row mt-3">
          <div class="col-sm-12">
            <label for="identity_custombgimage" class="form-label">Image de fond du planning</label>
            <div class="input-group">
              <button id="identity_custombgimagebrowse" class="btn btn-outline-secondary" type="button" @click="newBgImg">Choisir un fichier</button>
              <input id="identity_custombgimage" class="form-control" type="text" required @change="bgImgChange">
            </div>
          </div>
        </div>

        <div class="row mt-3">
          <div class="col-sm-4">
            <label for="identity_titlescolor">Couleur des titres</label> : <input id="identity_titlescolor" type="color" class="align-middle" required @change="titlesColorChange">
          </div>

          <div class="col-sm-4">
            <label for="identity_dayoncolor">Couleur des jours ON</label> : <input id="identity_dayoncolor" type="color" class="align-middle" required @change="dayOnColorChange">
          </div>

          <div class="col-sm-4">
            <label for="identity_dayoffcolor">Couleur des jours OFF</label> : <input id="identity_dayoffcolor" type="color" class="align-middle" required @change="dayOffColorChange">
          </div>
        </div>

        <div class="row mt-3">
          <div class="col-sm-12">
            <label for="identity_savepath" class="form-label">Fichier de destination du planning généré</label>
            <div class="input-group">
              <button id="identity_savepathbrowse" class="btn btn-outline-secondary" type="button" @click="newDestFile">Choisir un fichier</button>
              <input id="identity_savepath" class="form-control" type="text" required>
            </div>
          </div>
        </div>
      </form>
    </div>

    <div class="step_menu">
      <button id="identity_button_previous" class="btn btn-secondary mr-5" type="button" @click="previousStep">&laquo; Précédent</button>
      <button id="identity_button_next" class="btn btn-primary" type="button" @click="nextStep">Suivant &raquo;</button>
    </div>
  </div>
</template>

<style scoped lang="scss">
#identity {
  display: none;
}
</style>
