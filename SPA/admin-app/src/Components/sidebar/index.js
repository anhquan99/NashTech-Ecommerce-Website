import React from "react";
import {
  faHome,
  faBriefcase,
  faPaperPlane,
  faQuestion,
  faImage,
  faCopy,
} from "@fortawesome/free-solid-svg-icons";
import { NavItem, NavLink, Nav } from "reactstrap";
import classNames from "classnames";
import { Link } from "react-router-dom";

import SubMenu from "./SubMenu";

const SideBar = ({ isOpen, toggle }) => (
  <div className={classNames("sidebar", { "is-open": isOpen })}>
  <div className="sidebar-header">
    <span color="info" onClick={toggle} style={{ color: "#fff" }}>
      &times;
    </span>
    <h3>ADMIN</h3>
  </div>
  <div className="side-menu">
    <Nav vertical className="list-unstyled pb-3">
      <p>Dummy Heading</p>
      <SubMenu title="Product" icon={faHome} items={submenus[0]} />
      <SubMenu title="User" icon={faCopy} items={submenus[1]} />
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
      title: "List",
      target: "getUser",
    },
    {
      title: "Add",
      target: "addUser",
    },
  ],
];

export default SideBar;
