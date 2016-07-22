import getHotReloadStore from 'systemjs-hot-reloader-store';
import { createStore, combineReducers } from 'redux';
import dataFields from './reducers/dataFields';

const consoleReducers = combineReducers({
	dataFields
});

const hotStore = getHotReloadStore('console:store');

export default function configureStore(initialState) {
	let store = hotStore.prevStore;
	if (store && store.replaceReducer) {
		store.replaceReducer(consoleReducers);
	} else {
		store = createStore(consoleReducers, initialState,
			window.devToolsExtension && window.devToolsExtension());
		hotStore.prevStore = store;
	}
	return store;
}