<script setup>
import { onMounted } from 'vue'

import WindowButtons from './components/WindowButtons.vue'
import UpdateStep from './components/steps/UpdateStep.vue'
import IntroductionStep from './components/steps/IntroductionStep.vue'
import IdentityStep from './components/steps/IdentityStep.vue'

onMounted(() => {
  document.documentElement.setAttribute('data-bs-theme', 'dark')
})

window.api.fontsList(async (event, fonts) => {
  for (var font in fonts) {
    let fontOption = document.createElement('option')
    fontOption.value = fonts[font].replaceAll('"', '')
    fontOption.text = fonts[font].replaceAll('"', '')
    document.getElementById('identity_font').appendChild(fontOption)
  }

  document.getElementById('identity_twitchlogocolor').value = await window.settings.get('platformColor')
  document.getElementById('identity_twitchusername').value = await window.settings.get('channelName')
  document.getElementById('identity_twitchfulllink').checked = await window.settings.get('fullChannelLink')
  document.getElementById('identity_custombgimage').value = await window.settings.get('backgroundImagePath')
  document.getElementById('identity_titlescolor').value = await window.settings.get('titlesColor')
  document.getElementById('identity_dayoncolor').value = await window.settings.get('dayOnColor')
  document.getElementById('identity_dayoffcolor').value = await window.settings.get('dayOffColor')
  document.getElementById('identity_font').value = await window.settings.get('fontName')
  window.electron.ipcRenderer.send('settingsApplied')
})
</script>

<template>
  <WindowButtons />

  <UpdateStep />
  <IntroductionStep />
  <IdentityStep />

  <div id="generatedplanning"></div>
</template>
