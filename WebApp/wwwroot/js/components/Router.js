import React, { Component } from "react";
import { Link } from "react-router-dom";


export class Nav extends Component {
  render() {
    return (
      <div className="nav">
        <nav>
          <ul>
            <li><Link to='/'>Home</Link></li>
            <li><Link to='/materials'>Materials</Link></li>
          </ul>
        </nav>
      </div>
    );
  }
}
export default Nav;