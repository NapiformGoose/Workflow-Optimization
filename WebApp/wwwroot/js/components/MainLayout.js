import React, { Component } from "react";
import regeneratorRuntime, { async } from "regenerator-runtime";
import "../../css/bootstrap.css";
import { Switch, BrowserRouter as Router, Route } from "react-router-dom";

import Home from "./Home";
import MaterialContainer from "./MaterialContainer";
import WorkingDayContainer from "./WorkingDayContainer";
import ServiceContainer from "./ServiceContainer";
import WorkerContainer from "./WorkerContainer";

export class MainLayout extends Component {

    render() {
        return (
            <div className="mainLayout">
                <Switch>
                    <Route exact path="/" component={Home} />
                    <Route path="/materials" render={()=><MaterialContainer materialsCollection={ this.props.materialsCollection }/>}></Route>
                    <Route path="/workingdays" render={()=><WorkingDayContainer workingDaysCollection={ this.props.workingDaysCollection }/>}></Route>
                    <Route path="/services" render={()=><ServiceContainer servicesCollection={ this.props.servicesCollection }/>}></Route>
                    <Route path="/workers" render={()=><WorkerContainer workersCollection={this.props.workersCollection}/>}></Route>
                </Switch>
            </div>
        );
    }
}

export default MainLayout;
