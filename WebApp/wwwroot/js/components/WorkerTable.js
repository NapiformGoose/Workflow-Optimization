import React, { Component } from 'react';
import { BootstrapTable, TableHeaderColumn } from 'react-bootstrap-table';
import '../../../node_modules/react-bootstrap-table/dist/react-bootstrap-table-all.min.css';

class WorkerTable extends Component {
    render() {
        return (
            <div>
          <BootstrapTable data={this.props.workersCollection} striped={true} hover={true}>
          <TableHeaderColumn isKey dataField='name'>
            Имя
          </TableHeaderColumn>
          <TableHeaderColumn dataField='position'>
            Должность
          </TableHeaderColumn>
          </BootstrapTable>
            </div>
        );
    }
}

export default WorkerTable;