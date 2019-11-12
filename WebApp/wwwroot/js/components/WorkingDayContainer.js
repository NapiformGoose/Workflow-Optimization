import React, { Component } from 'react';
import WorkingDaysTable from './WorkingDaysTable'
 
class WorkingDayContainer extends Component {
  
  render() {
    return (
      <div className="WorkingDaysContainer">
            <WorkingDaysTable workingDaysCollection={this.props.workingDaysCollection} />
      </div>
    );
  }
}
 
export default WorkingDayContainer;