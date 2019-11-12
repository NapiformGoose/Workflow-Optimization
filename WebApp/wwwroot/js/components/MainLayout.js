import React, { Component } from "react";
import regeneratorRuntime, { async } from "regenerator-runtime";
import "../../css/bootstrap.css";
import { Switch, BrowserRouter as Router, Route } from "react-router-dom";

import Home from "./Home";
import MaterialContainer from "./MaterialContainer";
import WorkingDayContainer from "./WorkingDayContainer";
export class MainLayout extends Component {

    render() {
        const materialsCollection = this.props.materialsCollection;
        const workingDaysCollection = this.props.workingDaysCollection;
    console.log(this.props.workingDaysCollection);
        return (
            <div className="mainLayout">
                <Switch>
                    <Route exact path="/" component={Home} />
                    <Route path="/materials" render={()=><MaterialContainer materialsCollection={materialsCollection}/>}></Route>
                    <Route path="/workingdays" render={()=><WorkingDayContainer workingDaysCollection={workingDaysCollection}/>}></Route>
                </Switch>
            </div>
        );
    }
}

export default MainLayout;
