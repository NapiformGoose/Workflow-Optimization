import React, { Component } from "react";
import regeneratorRuntime, { async } from "regenerator-runtime";

import { Switch, BrowserRouter as Router, Route } from "react-router-dom";
import { Button } from 'react-bootstrap';

export class FunctionalPanel extends Component {

    render() {
       
        return (
            
            <div className="functionalPanel">
                <Button variant="outline-success" bsSize="large" block>Create</Button>
                <Button variant="outline-warning" bsSize="large" block>Update</Button>
                <Button variant="outline-danger" bsSize="large" block>Delete</Button>
            </div>
        );
    }
}

export default FunctionalPanel;
