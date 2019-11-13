import React, { Component } from 'react';
import WorkerTable from './WorkerTable'
import FunctionalPanel from "./FunctionalPanel";

class WorkerContainer extends Component {

  render() {
    return (
      <div className="workerContainer">
        <FunctionalPanel />
        <WorkerTable workersCollection={this.props.workersCollection} />
      </div>
    );
  }
}

export default WorkerContainer;