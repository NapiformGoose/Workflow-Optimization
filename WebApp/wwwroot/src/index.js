
import React from "react";
import ReactDOM from "react-dom";
import { Provider } from "react-redux";
import { createStore, combineReducers } from 'redux';
import { BrowserRouter, Route } from 'react-router-dom';
//import { App } from "../js/components/App";
import MainLayout from '../js/components/MainLayout';
//redux
const selectedObjectReducer = function (state = "", action) {
    switch (action.type) {
        case 'selectedObject_CHANGED':
            {
                return Object.assign({}, state, { selected: action.selected });
            }
    }
    return state;
}

export const store = createStore(selectedObjectReducer);

ReactDOM.render(
    <Provider store={store}>
        <MainLayout/>
      </Provider>,

    document.getElementById("root")
);









