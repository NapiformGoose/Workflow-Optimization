import React, { Component } from 'react';
import {BootstrapTable, TableHeaderColumn} from 'react-bootstrap-table';
//import '../css/Table.css';
import '../../css/react-bootstrap-table.css'
 
 
class MaterialsTable extends Component {
    render() {
        var a = this.props.materialsCollection;
        return (
            <div defaultValue={this.props.materialsCollection}>
          
      </div>
    );
  }
}
 
export default MaterialsTable;