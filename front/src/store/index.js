import Vue from 'vue';
import Vuex from 'vuex';
import registration from './modules/registration.store.js';
import сelebrities from './modules/celebrities.store.js';

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    baseUrl: 'https://localhost:5001'
  },
  mutations: {
  },
  actions: {
  },
  modules: {
    сelebrities, registration
  }
});
