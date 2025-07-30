import './css/app.css'
import 'vue-toastification/dist/index.css'

import { createApp } from 'vue'
import Toast from 'vue-toastification'
import App from './App.vue'

createApp(App).use(Toast, {
  transition: "Vue-Toastification__fade",
  maxToasts: 3,
  newestOnTop: true,
  position: "bottom-left",
  timeout: 5000,
  closeOnClick: true,
  pauseOnFocusLoss: false,
  pauseOnHover: true,
  draggable: false,
  showCloseButtonOnHover: true,
  hideProgressBar: true,
  closeButton: "button",
  icon: true,
  rtl: false
}).mount('#app')
