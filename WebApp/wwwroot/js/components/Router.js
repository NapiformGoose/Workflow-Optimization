import React from 'react';
import { Switch, BrowserRouter as Router, Route } from "react-router-dom";


import Home from "./Home";
import MaterialContainer from "./MaterialContainer"

export default (
  <Router>
      <Switch>
            <Route path="/home" component={Home}></Route>
            <Route path="/materials" component={MaterialContainer}></Route>
        </Switch>

  </Router>
);