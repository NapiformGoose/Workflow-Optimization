import React, { Component } from 'react';
import { BootstrapTable, TableHeaderColumn } from 'react-bootstrap-table';
import '../../../node_modules/react-bootstrap-table/dist/react-bootstrap-table-all.min.css';
import { Button, Modal, Collapse } from 'react-bootstrap';

class WorkingDaysTable extends Component {
    constructor(props) {
        super(props);
        this.state = { 
            modalShow: false,
            object: null 
        };
    }
    cellButton(cell, row, enumObject, rowIndex) {
        return (
            <div>
                <Button
                    onClick={() => {
                        this.setState({ modalShow: true });
                        this.setState({ object: row });
                    }
                    }
                >
                    Показать
                </Button>
                <InformationCenteredModal
                    show = { this.state.modalShow }
                    onHide = { () => this.setState({ modalShow: false }) }
                    object = { this.state.object }
                />
            </div>
        )
    }
    render() {
        return (
            <div>
                <BootstrapTable data={this.props.workingDaysCollection} striped={true} hover={true}>
                    <TableHeaderColumn isKey dataField='date'>
                        Дата
                    </TableHeaderColumn>
                    <TableHeaderColumn dataField='button' dataFormat={this.cellButton.bind(this)}>
                        Информация
                    </TableHeaderColumn>
                </BootstrapTable>
            </div>
        );
    }
}
class InformationCenteredModal extends Component {
    constructor(props) {
        super(props);
        this.state = {
            isMaterialsTableOpen: false,
            isServicesTableOpen: false,
            isWorkersTableOpen: false,
            materialsCollection: null,
            workerCollection: null,
            servicesCollection: null
        };
    }
    componentWillReceiveProps() {
        this.setState({ 
            isMaterialsTableOpen: false,
            isServicesTableOpen: false,
            isWorkersTableOpen: false,
        })
    }

    updateCollections() {
        this.setState({ 
            workerCollection: this.props.object.workers,
            materialsCollection: this.props.object.materials,
            servicesCollection: this.props.object.services,
        })
    }
    render() {
        return (
            <div>
                <Modal
                    {...this.props}
                    size="lg"
                    aria-labelledby="contained-modal-title-vcenter"
                    centered
                >
                    <Modal.Header closeButton>
                        <Modal.Title id="contained-modal-title-vcenter">
                            Рабочий день
              </Modal.Title>
                    </Modal.Header>
                    <Modal.Body>
                        <ul className="list-group list-group-flush">
                            <li display="block"
                                float="left" className="list-group-item"> 
                                <Button
                                    onClick={() => {
                                        this.setState({ isWorkersTableOpen: !this.state.isWorkersTableOpen });
                                        if(this.props.object != null) {
                                            this.updateCollections();
                                        }
                                    }
                                    }
                                    aria-controls="example-collapse-text"
                                    aria-expanded={this.state.isWorkersTableOpen}
                                >
                                    Работники
                                </Button>
                                <Collapse in={this.state.isWorkersTableOpen}>
                                    <div id="example-collapse-text">
                                        <BootstrapTable data={this.state.workerCollection} striped={true} hover={true}>
                                            <TableHeaderColumn isKey dataField='name'>
                                                Имя
                                            </TableHeaderColumn>
                                            <TableHeaderColumn dataField='position'>
                                                Должность
                                            </TableHeaderColumn>
                                        </BootstrapTable>
                                    </div>
                                </Collapse></li>
                            <li display="block"
                                float="left" className="list-group-item">
                                    <Button
                                    onClick={() => {
                                        this.setState({ isMaterialsTableOpen: !this.state.isMaterialsTableOpen });
                                        if(this.props.object != null) {
                                            this.updateCollections();
                                        }
                                    }
                                    }
                                    aria-controls="example-collapse-text"
                                    aria-expanded={this.state.isMaterialsTableOpen}
                                    >
                                    Использованные продукты
                                    </Button>
                                <Collapse in={this.state.isMaterialsTableOpen}>
                                    <div id="example-collapse-text">
                                        <BootstrapTable data={this.state.materialsCollection} striped={true} hover={true}>
                                            <TableHeaderColumn isKey dataField='name'>
                                                Название
                                            </TableHeaderColumn>
                                            <TableHeaderColumn dataField='quantity'>
                                                Количество
                                            </TableHeaderColumn>
                                        </BootstrapTable>
                                    </div>
                                </Collapse>
                            </li>
                            <li display="block"
                                float="left" className="list-group-item">
                                    <Button
                                    onClick={() => {
                                        this.setState({ isServicesTableOpen: !this.state.isServicesTableOpen });
                                        if(this.props.object != null) {
                                            this.updateCollections();
                                        }
                                    }
                                    }
                                    aria-controls="example-collapse-text"
                                    aria-expanded={this.state.isServicesTableOpen}
                                    >
                                    Произведённая продукция
                                    </Button>
                                <Collapse in={this.state.isServicesTableOpen}>
                                    <div id="example-collapse-text">
                                        <BootstrapTable data={this.state.servicesCollection} striped={true} hover={true}>
                                            <TableHeaderColumn isKey dataField='name'>
                                                Название
                                            </TableHeaderColumn>
                                            <TableHeaderColumn dataField='quantity'>
                                                Количество
                                            </TableHeaderColumn>
                                        </BootstrapTable>
                                    </div>
                                </Collapse>
                            </li>
                        </ul>
                    </Modal.Body>
                    <Modal.Footer>
                        <Button onClick={this.props.onHide}>Close</Button>
                    </Modal.Footer>
                </Modal>
            </div>
        );
    }
}
export default WorkingDaysTable;