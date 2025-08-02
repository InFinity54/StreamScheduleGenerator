import { contextBridge, ipcRenderer } from 'electron'
import { electronAPI } from '@electron-toolkit/preload'

// Custom APIs for renderer
const api = {
  noUpdateAvailable: (callback) => ipcRenderer.on('update-not-available', callback),
  updateAvailable: (callback) => ipcRenderer.on('update-available', callback),
  updateDownloading: (callback) => ipcRenderer.on('update-download-progress', callback),
  updateDownloaded: (callback) => ipcRenderer.on('update-downloaded', callback),
  fontsList: (response) => ipcRenderer.on('fontsList', response),
  appInitialized: (callback) => ipcRenderer.on('appInitialized', callback),
  openDialog: (method, config) => ipcRenderer.invoke('dialog', method, config),
  generatePlanning: (config) => ipcRenderer.invoke('generatePlanning', config)
}

const settings = {
  has: (key) => ipcRenderer.invoke('settings', { method: 'has', key }),
  get: (key) => ipcRenderer.invoke('settings', { method: 'get', key }),
  set: (key, value) => ipcRenderer.invoke('settings', { method: 'set', key, value }),
  reset: (key) => ipcRenderer.invoke('settings', { method: 'reset', key }),
  delete: (key) => ipcRenderer.invoke('settings', { method: 'delete', key })
}

// Use `contextBridge` APIs to expose Electron APIs to
// renderer only if context isolation is enabled, otherwise
// just add to the DOM global.
if (process.contextIsolated) {
  try {
    contextBridge.exposeInMainWorld('electron', electronAPI)
    contextBridge.exposeInMainWorld('api', api)
    contextBridge.exposeInMainWorld('settings', settings)
  } catch (error) {
    console.error(error)
  }
} else {
  window.electron = electronAPI
  window.api = api
  window.settings = settings
}
