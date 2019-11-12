import React, { Component } from "react";
import regeneratorRuntime, { async } from "regenerator-runtime";
//import { request } from "http";
import FunctionalPanel from "./FunctionalPanel";
import NavigationBar from "./Router";
import MainLayout from "./MainLayout";

export class App extends Component {

    constructor(props) {
        super(props);

        this.state = {
            materialsCollection: null,
            workingDaysCollection: null
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

        var xhr = new XMLHttpRequest();
        xhr.open("GET", "WorkingDay/Get", true);
        xhr.responseType = "text";
        xhr.onload = function () {
            var response = xhr.responseText;
            var data = JSON.parse(response);
            this.setState({ workingDaysCollection: data });
        }.bind(this);
        xhr.send();
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
        console.log(this.state.workingDaysCollection);
        return (
            <div className="app">
                <NavigationBar />
                <FunctionalPanel />
                <MainLayout materialsCollection = {this.state.materialsCollection} workingDaysCollection = {this.state.workingDaysCollection}/>
            </div>
        );
    }
}
