<script setup>
function nextStep() {
  document.getElementById('introduction').animate([{ opacity: 1 }, { opacity: 0 }], 500)

  setTimeout(() => {
    document.getElementById('introduction').style.display = 'none'
    /*document.getElementById('identity')
      .style.display = 'block'
      .animate([{ opacity: 0 }, { opacity: 1 }], 500)*/
  }, 500)
}
</script>

<template>
  <div id="introduction" class="vw-100 vh-100">
    <div class="position-absolute top-50 start-50 translate-middle text-center w-100">
      <div id="introduction_appicon"></div>

      <p>
        Bienvenue dans le Générateur de Planning de Stream !
        <br />
        Plusieurs étapes seront nécessaires pour créer le planning, mais pas d'inquiétude, c'est très simple !
        <br />
        Certains paramètres sont sauvegardés et seront réutilisés à chaque démarrage de l'application.
        C'est le cas, par exemple, de l'image de fond du planning.
      </p>

      <p>Dès que tu souhaites commencer, clique sur le bouton ci-dessous pour démarrer la création de ton planning ! 🙂</p>
    </div>

    <div class="position-absolute" style="bottom: 10px; right: 10px;">
      <button id="introduction_button_next" class="btn btn-primary" type="button" @click="nextStep">Démarrer</button>
    </div>
  </div>
</template>

<style scoped lang="scss">
#introduction {
  //display: none;

  #introduction_appicon {
    width: 150px;
    height: 150px;
    margin-left: auto;
    margin-right: auto;
    margin-bottom: 15px;
    background-image: url('../../assets/icon.png');
    background-repeat: no-repeat;
    background-size: cover;
    background-position: center center;
    background-attachment: fixed;
  }
}
</style>
