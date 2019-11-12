import React, { Component } from 'react';
import MaterialsTable from './MaterialsTable';
import FunctionalPanel from "./FunctionalPanel";
 
class MaterialContainer extends Component {
  
  render() {
    return (
      <div className="Materials">
                <FunctionalPanel />
            <MaterialsTable materialsCollection={this.props.materialsCollection} />
      </div>
    );
  }
}
 
export default MaterialContainer;