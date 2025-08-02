<script setup>
window.api.noUpdateAvailable(() => {
  document.getElementById('update').animate([{ opacity: 1 }, { opacity: 0 }], 500)

  setTimeout(() => {
    document.getElementById('update').style.display = 'none'
    document.getElementById('introduction').style.display = 'block'
    document.getElementById('introduction').animate([{ opacity: 0 }, { opacity: 1 }], 500)
  }, 500)
})

window.api.updateAvailable(() => {
  document.getElementById('update_progresstext').innerHTML =
    "Téléchargement de la dernière version de l'application..."
})

window.api.updateDownloading((event, args) => {
  document.getElementById('update_progressbarvalue').style.width = args.percent + '%'
})

window.api.updateDownloaded(() => {
  document.getElementById('update_progresstext').innerHTML =
    "Préparation de l'installation de la mise à jour..."
})
</script>

<template>
  <div id="update" class="vw-100 vh-100">
    <div class="position-absolute top-50 start-50 translate-middle text-center w-100">
      <div id="update_appicon"></div>

      <p id="update_progresstext">Vérification des mises à jour de l'application...</p>

      <div id="update_progressbar" class="progress w-50 mx-auto">
        <div
          id="update_progressbarvalue"
          class="progress-bar progress-bar-striped progress-bar-animated"
          role="progressbar"
        ></div>
      </div>
    </div>
  </div>
</template>

<style scoped lang="scss"></style>
