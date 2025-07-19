<script setup>
import { onMounted } from 'vue'
import WindowButtons from './components/WindowButtons.vue'

window.appSettings = {
  identity: {
    platform: 'twitch',
    platformColor: 'default',
    channelName: '',
    fullChannelLink: false,
    fontName: '',
    backgroundImagePath: '',
    colors: {
      titles: '#FFFFFF',
      dayOn: '#FFFFFF',
      dayOff: '#FF0000'
    }
  }
}

onMounted(() => {
  document.documentElement.setAttribute('data-bs-theme', 'dark')
})
</script>

<template>
  <WindowButtons />

  <div id="generatedplanning"></div>
</template>
