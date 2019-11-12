import React, { Component } from 'react';
import WorkingDaysTable from './WorkingDaysTable'
import FunctionalPanel from "./FunctionalPanel";

class WorkingDayContainer extends Component {

  render() {
    return (
      <div className="WorkingDaysContainer">
        <FunctionalPanel />
        <WorkingDaysTable workingDaysCollection={this.props.workingDaysCollection} />
      </div>
    );
  }
}

export default WorkingDayContainer;