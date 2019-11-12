import React, { Component } from "react";
import { Link } from "react-router-dom";
import { Navbar, Nav, Form, FormControl, Button, NavItem } from 'react-bootstrap';

export class NavigationBar extends Component {
  render() {
    return (
      <div className="nav">
        {/* <nav>
          <ul>
            <li><Link to='/'>Home</Link></li>
            <li><Link to='/materials'>Materials</Link></li>
          </ul>
        </nav> */}
        <Navbar expand="lg" bg="dark" variant="dark">
            <Navbar.Brand href="/" as={Link} to="/">Workflow Optimization</Navbar.Brand>
              <Nav className="mr-auto">
                <NavItem href="/materials">
                  <Nav.Link as={Link} to="/materials" >Materials</Nav.Link>
                </NavItem>
              </Nav>
              <Nav className="mr-auto">
                <NavItem href="/workingdays">
                  <Nav.Link as={Link} to="/workingdays" >Working days</Nav.Link>
                </NavItem>
              </Nav>
          </Navbar>
      </div>
    );
  }
}
export default NavigationBar;