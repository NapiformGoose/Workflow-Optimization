import React, { Component } from 'react';
import "../../css/bootstrap.css";

import { Nav, Navbar, Button, FormControl, Form } from "react-bootstrap";


class Home extends Component {
  render() {
    return (
      <div>
       <Navbar bg="dark" variant="dark">
    <Navbar.Brand href="#home">Navbar</Navbar.Brand>
    <Nav className="mr-auto">
      <Nav.Link href="#home">Materials table</Nav.Link>
    </Nav>
    <Form inline>
      <FormControl type="text" placeholder="Search" className="mr-sm-2" />
      <Button variant="outline-info">Search</Button>
    </Form>
  </Navbar>
      </div>
    );
  }
}
export default Home;