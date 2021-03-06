﻿import React, { Component } from "react";
import regeneratorRuntime, { async } from "regenerator-runtime";
//import { request } from "http";
import NavigationBar from "./NavigationBar";
import MainLayout from "./MainLayout";

export class App extends Component {

    constructor(props) {
        super(props);

        this.state = {
            materialsCollection: null,
            workingDaysCollection: null,
            servicesCollection: null,
            workersCollection: null
        };

        var xhr = new XMLHttpRequest();
        xhr.open("GET", "Materials/Get", true);
        xhr.responseType = "text";
        xhr.onload = function () {
            var response = xhr.responseText;
            var data = JSON.parse(response);
            this.setState({ materialsCollection: data });
        }.bind(this);
        xhr.send();

        var xhr1 = new XMLHttpRequest();
        xhr1.open("GET", "WorkingDays/Get", true);
        xhr1.responseType = "text";
        xhr1.onload = function () {
            var response = xhr1.responseText;
            var data = JSON.parse(response);
            this.setState({ workingDaysCollection: data });
        }.bind(this);
        xhr1.send();

        var xhr2 = new XMLHttpRequest();
        xhr2.open("GET", "Services/Get", true);
        xhr2.responseType = "text";
        xhr2.onload = function () {
            var response = xhr2.responseText;
            var data = JSON.parse(response);
            this.setState({ servicesCollection: data });
        }.bind(this);
        xhr2.send();

        var xhr3 = new XMLHttpRequest();
        xhr3.open("GET", "Workers/Get", true);
        xhr3.responseType = "text";
        xhr3.onload = function () {
            var response = xhr3.responseText;
            var data = JSON.parse(response);
            this.setState({ workersCollection: data });
        }.bind(this);
        xhr3.send();
    }

     //componentDidMount() { //обновление выбранного элемента
     //    store.subscribe(() => {
     //        this.setState({
     //            materialsCollection: store.getState().materialsCollection
     //        });
     //    });

    //     //var xhr1 = new XMLHttpRequest();
    //     //var url = "url";
    //     //xhr1.open("POST", this.props.postURL, true);
    //     //xhr1.setRequestHeader("Content-Type", "application/json");
        
    //     //var data = JSON.stringify({ "email": "hey@mail.com", "password": "101010" });
    //     //xhr1.send(data);
    // }
    render() {
        return (
            <div className="app">
                <NavigationBar />
                <MainLayout 
                materialsCollection = {this.state.materialsCollection} 
                workingDaysCollection = {this.state.workingDaysCollection}
                servicesCollection = {this.state.servicesCollection}
                workersCollection = {this.state.workersCollection}/>
            </div>
        );
    }
}
