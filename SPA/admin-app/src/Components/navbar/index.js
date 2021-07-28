import React, { useState } from 'react';
import { Collapse, Navbar, NavbarToggler, NavbarBrand, Nav, NavItem, NavLink } from 'reactstrap';
import AuthService from '../../Service/AuthenticationService'; 

const Example = (props) => {
  const [collapsed, setCollapsed] = useState(true);

  const toggleNavbar = () => setCollapsed(!collapsed);
  const authService = new AuthService();
  const logout = async () =>{
    const user = await authService.getUser();
    if(user.access_token != null){
      authService.logout()
    }
  }
  return (
    <div>
      <Navbar color="faded" light>
        <NavbarBrand href="/" className="mr-auto">{props.name}</NavbarBrand>
        <NavbarToggler onClick={toggleNavbar} className="mr-2" />
        <Collapse isOpen={!collapsed} navbar>
          <Nav navbar>
            <NavItem>
              <NavLink href="#" onClick={logout}>Logout</NavLink>
            </NavItem>
          </Nav>
        </Collapse>
      </Navbar>
    </div>
  );
}

export default Example;