import React, { Component } from "react";
import MainMenu from "./MainMenu";
import MaterialContainer from "./MaterialContainer"
//import { store } from "../index"
import regeneratorRuntime, { async } from "regenerator-runtime";

export class App extends Component {
    constructor(props) {
        super(props);

        this.state = {
            // selected: "",
            // diagramBase64: null
        };

        // var xhr = new XMLHttpRequest();
        // xhr.open("GET", this.props.getUrl, true);
        // xhr.responseType = "text";
        // xhr.onload = function () {
        //     var data = JSON.parse(xhr.responseText);
        //     this.setState({ diagramBase64: data });

        // }.bind(this);
        // xhr.send();
    }

    // componentDidMount() { //обновление выбранного элемента
    //     store.subscribe(() => {
    //         this.setState({
    //             selected: store.getState().selected
    //         });
    //     });

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
                <div className='mainMenu' >
                    <MainMenu />
                </div>
                <div className='materialContainer'>
                    <MaterialContainer  />
                </div>
            </div>
        );
    }
}
