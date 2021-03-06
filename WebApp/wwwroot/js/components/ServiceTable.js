import React, { Component } from 'react';
import { BootstrapTable, TableHeaderColumn } from 'react-bootstrap-table';
import '../../../node_modules/react-bootstrap-table/dist/react-bootstrap-table-all.min.css';

class ServiceTable extends Component {
    render() {
        return (
            <div>
          <BootstrapTable data={this.props.servicesCollection} striped={true} hover={true}>
          <TableHeaderColumn isKey dataField='name'>
            Название
          </TableHeaderColumn>
          <TableHeaderColumn dataField='shop'>
            Цех
          </TableHeaderColumn>
          </BootstrapTable>
            </div>
        );
    }
}

export default ServiceTable;