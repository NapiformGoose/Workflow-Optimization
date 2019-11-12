import React, { Component } from 'react';
import ServiceTable from './ServiceTable'
import FunctionalPanel from "./FunctionalPanel";

class ServiceContainer extends Component {
  render() {
    return (
      <div className="serviceContainer">
            <FunctionalPanel />
            <ServiceTable servicesCollection={this.props.servicesCollection} />
      </div>
    );
  }
}
 
export default ServiceContainer;