import React, { Component } from 'react';
import { BootstrapTable, TableHeaderColumn } from 'react-bootstrap-table';
import '../../../node_modules/react-bootstrap-table/dist/react-bootstrap-table-all.min.css';

class ServiceTable extends Component {
    render() {
    console.log(this.props.servicesCollection);

        return (
            <div>
          <BootstrapTable data={this.props.servicesCollection} striped={true} hover={true}>
          <TableHeaderColumn isKey dataField='name'>
            Name
          </TableHeaderColumn>
          <TableHeaderColumn dataField='shop'>
            Shop
          </TableHeaderColumn>
          </BootstrapTable>
            </div>
        );
    }
}

export default ServiceTable;