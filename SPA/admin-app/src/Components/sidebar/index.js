import React from "react";
import {
  faUserShield,
  faBox
} from "@fortawesome/free-solid-svg-icons";
import { Nav } from "reactstrap";
import classNames from "classnames";

import SubMenu from "./SubMenu";

const SideBar = ({ isOpen, toggle }) => (
  <div className={classNames("sidebar", { "is-open": isOpen })}>
  <div className="sidebar-header">
    <span color="info" onClick={toggle} style={{ color: "#fff" }}>
      &times;
    </span>
    <h3>SPA</h3>
  </div>
  <div className="side-menu">
    <Nav vertical className="list-unstyled pb-3">
      <p>ADMIN</p>
      <SubMenu title="Product" icon={faBox} items={submenus[0]} />
      <SubMenu title="User" icon={faUserShield} items={submenus[1]} />
    </Nav>
  </div>
</div>
);

const submenus = [
  [
    {
      title: "List",
      target: "getProduct",
    },
    {
      title: "Add",
      target: "addProduct",
    },
  ],
  [
    {
      title: "List User",
      target: "getUser",
    },
    {
      title: "List Admin",
      target: "getAdmin",
    },
  ],
];

export default SideBar;
