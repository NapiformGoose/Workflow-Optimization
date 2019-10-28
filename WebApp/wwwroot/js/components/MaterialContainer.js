import React, { Component } from 'react';
import MaterialsTable from './MaterialsTable'
 
class MaterialContainer extends Component {
  
  render() {
    console.log(this.props.materialsCollection);
    return (
      <div className="Materials">
            <MaterialsTable materialsCollection={this.props.materialsCollection} />
      </div>
    );
  }
}
 
export default MaterialContainer;