import React, { Component } from "react";
import regeneratorRuntime, { async } from "regenerator-runtime";
import "../../css/bootstrap.css";
import Router from "./Router";
import { Nav, Navbar, Button, FormControl, Form } from "react-bootstrap";
export class MainLayout extends Component {

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

    render() {
        return (
            <div className="app">
                <div className='home' >
                    <Navbar bg="dark" variant="dark">
                        <Navbar.Brand>Workflow Optimization</Navbar.Brand>
                        <Nav className="mr-auto">
                            <Nav.Link href="/home">Home</Nav.Link>
                        </Nav>
                        <Nav className="mr-auto">
                            <Nav.Link href="/materials">Materials</Nav.Link>
                        </Nav>
                    </Navbar>
                </div>
                <div>
                    {Router}
                </div>
            </div>
        );
    }
}

export default MainLayout;
