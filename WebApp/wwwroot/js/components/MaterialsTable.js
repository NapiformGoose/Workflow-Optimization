import React, { Component } from 'react';
import {BootstrapTable, TableHeaderColumn} from 'react-bootstrap-table';
import '../../../node_modules/react-bootstrap-table/dist/react-bootstrap-table-all.min.css';
 
class MaterialsTable extends Component {
    render() {
        return (
          <div>
          <BootstrapTable data={this.props.materialsCollection} striped={true} hover={true}>
          <TableHeaderColumn isKey dataField='name'>
            Название
          </TableHeaderColumn>
          <TableHeaderColumn dataField='quantityInStock'>
            Количество на складе
          </TableHeaderColumn>
          </BootstrapTable>
        </div>
    );
  }
}
 
export default MaterialsTable;