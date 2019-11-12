import React, { Component } from 'react';
import { BootstrapTable, TableHeaderColumn } from 'react-bootstrap-table';
import '../../../node_modules/react-bootstrap-table/dist/react-bootstrap-table-all.min.css';

class WorkingDaysTable extends Component {
    onClickProductSelected(cell, row, rowIndex) {
        console.log('Product #', rowIndex);
    }

    cellButton(cell, row, enumObject, rowIndex) {
        return (
            <button
                type="button"
                onClick={() =>
                    this.onClickProductSelected(cell, row, rowIndex)}
            >
                Click me {rowIndex}
            </button>
        )
    }
    render() {
        return (
            <div>
                <BootstrapTable data={this.props.workingDaysCollection} striped={true} hover={true}>
                    <TableHeaderColumn isKey dataField='date'>
                        Date
          </TableHeaderColumn>
                    <TableHeaderColumn dataField='button' dataFormat={this.cellButton.bind(this)}>
                        Workers
          </TableHeaderColumn>
                    <TableHeaderColumn dataField='button' dataFormat={this.cellButton.bind(this)}>
                        Services
          </TableHeaderColumn>
                    <TableHeaderColumn dataField='button' dataFormat={this.cellButton.bind(this)}>
                        Materials
          </TableHeaderColumn>
                </BootstrapTable>
            </div>
        );
    }
}

export default WorkingDaysTable;