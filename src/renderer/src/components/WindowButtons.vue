<script setup>
function windowReduce() {
  window.electron.ipcRenderer.send('windowReduce')
}

function windowExit() {
  window.electron.ipcRenderer.send('windowClose')
}
</script>

<template>
  <div id="windowButtons">
    <div id="windowButton_reduce" @click="windowReduce">
      <img src="./../assets/window_reduce.svg" alt="Réduire" />
    </div>

    <div id="windowButton_exit" @click="windowExit">
      <img src="./../assets/window_close.svg" alt="Quitter" />
    </div>
  </div>
</template>

<style scoped lang="scss">
#windowButtons {
  position: fixed;
  top: 2px;
  right: 0;
  display: flex;
  width: 68px;
  height: 26px;
  z-index: 997;

  #windowButton_reduce,
  #windowButton_exit {
    width: 16px;
    height: 16px;
    margin-top: 5px;
    opacity: 0.5;
    transition: opacity 0.25s;

    img {
      width: 150%;
    }
  }

  #windowButton_reduce {
    margin-right: 22px;
  }

  #windowButton_exit {
    margin-right: 22px;
  }

  #windowButton_reduce:hover,
  #windowButton_exit:hover {
    opacity: 1;
  }
}
</style>
