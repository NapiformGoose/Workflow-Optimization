import React, { Component } from "react";
import Home from "./Home";
import MainMenu from "./MainMenu";
import MaterialContainer from "./MaterialContainer"
//import { store } from "../index"
import regeneratorRuntime, { async } from "regenerator-runtime";
//import { request } from "http";

export class App extends Component {

    constructor(props) {
        super(props);

        this.state = {
            // selected: "",
            materialsCollection: null
        };

        var xhr = new XMLHttpRequest();
        xhr.open("GET", "Materials/Get", true);
        xhr.responseType = "text";
        xhr.onload = function () {
            var data = xhr.responseText;
            var data1 = JSON.parse(data);
            this.setState({ materialsCollection: data1 });
            this.a;
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
        return (
            <div className="app">
                <div className='home' >
                <Home />
                </div>
                <div className='materialContainer'>
                   <MaterialContainer materialsCollection={this.state.materialsCollection} />
                </div>
                
            </div>
        );
    }
}
