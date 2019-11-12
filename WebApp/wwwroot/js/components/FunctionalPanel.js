import React, { Component } from "react";
import regeneratorRuntime, { async } from "regenerator-runtime";
import "../../css/bootstrap.css";
import { Switch, BrowserRouter as Router, Route } from "react-router-dom";
import { Button, ButtonGroup } from 'react-bootstrap';

export class FunctionalPanel extends Component {

    render() {
       
        return (
            <div className="functionalPanel">
                <ButtonGroup size="lg">
                    <Button>Left</Button>
                    <Button>Middle</Button>
                    <Button>Right</Button>
                </ButtonGroup>
            </div>
        );
    }
}

export default FunctionalPanel;
