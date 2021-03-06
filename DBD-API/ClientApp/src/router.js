import Vue from 'vue';
import Router from 'vue-router';

/* Lazy loaded components */
const News = () =>            import(/* webpackChunkName: "views" */ './views/News');
const Perks = () =>           import(/* webpackChunkName: "views" */ './views/Perks');
const Shrine = () =>          import(/* webpackChunkName: "views" */ './views/Shrine');
const Offerings = () =>       import(/* webpackChunkName: "views" */ './views/Offerings');
const Characters = () =>      import(/* webpackChunkName: "views" */ './views/Characters');
const CharacterInfo = () =>   import(/* webpackChunkName: "views" */ './views/CharacterInfo');

Vue.use(Router);

const router = new Router({
  mode: 'history',
  routes: [
    { path: '/',                name: 'characters',     component: Characters, },
    { path: '/characters/:id',  name: 'character-info', component: CharacterInfo, },
    { path: '/perks',           name: 'perks',          component: Perks },
    { path: '/offerings',       name: 'offerings',      component: Offerings },
    { path: '/shrine',          name: 'shrine',         component: Shrine },
    { path: '/new',             name: 'news',           component: News },
  ]
});

export default router;
