import React, { Component } from "react";
import { Link } from "react-router-dom";
import { Navbar, Nav, Form, FormControl, Button, NavItem, Container } from 'react-bootstrap';
import "../../css/bootstrap.css";

export class NavigationBar extends Component {
  render() {
    return (
        <Navbar expand="sm" bg="dark" variant="dark">
            <Navbar.Brand href="/" as={Link} to="/">Workflow Optimization</Navbar.Brand>
              <Nav className="mr-auto">
                <NavItem href="/materials">
                  <Nav.Link as={Link} to="/materials" >Материалы</Nav.Link>
                </NavItem>
                <NavItem href="/workingdays">
                  <Nav.Link as={Link} to="/workingdays" >Рабочие дни</Nav.Link>
                </NavItem>
                <NavItem href="/services">
                  <Nav.Link as={Link} to="/services" >Услуги</Nav.Link>
                </NavItem>
                <NavItem href="/workers">
                  <Nav.Link as={Link} to="/workers" >Работники</Nav.Link>
                </NavItem>
              </Nav>
          </Navbar>

    );
  }
}
export default NavigationBar;