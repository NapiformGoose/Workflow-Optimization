import React, { Component } from 'react';
//import './App.css';
import MaterialsTable from './MaterialsTable'
 
var data = [
  {id: 1, name: 'Gob', value: '2'},
  {id: 2, name: 'Buster', value: '5'},
  {id: 3, name: 'George Michael', value: '4'}
];
 
 
class MaterialContainer extends Component {
  render() {
    return (
      <div className="Materials">
            <MaterialsTable materialsCollection={this.props.materialsCollection} />
      </div>
    );
  }
}
 
export default MaterialContainer;