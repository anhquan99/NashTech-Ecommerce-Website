import './App.css';
import { BrowserRouter as Router } from "react-router-dom";
import "bootstrap/dist/css/bootstrap.min.css";
import SideBar from "./Components/sidebar";
import React, { useState } from "react";
import { Container } from 'reactstrap';
import Navbar from './Components/navbar'
import TableProduct from './Components/TableProduct'
import { Switch, Route } from "react-router-dom";
import AddProduct from './Components/FormAddProduct';

function App() {
  const [sidebarIsOpen, setSidebarOpen] = useState(true);
  const toggleSidebar = () => setSidebarOpen(!sidebarIsOpen);
  return (
    <>
      <Router>
        <div className="App wrapper">
          <SideBar toggle={toggleSidebar} isOpen={sidebarIsOpen} />
          <Container fluid>
            <Navbar name="NASH"></Navbar>
            <hr className="hr"/>
            <Switch>
              <Route exact path="/" >
                <TableProduct/>
              </Route>
              <Route exact path="/getProduct" >
                <TableProduct/>
              </Route>
              <Route exact path="/addProduct" >
                <AddProduct method='post'/>
              </Route>
              <Route exact path="/Pages" ></Route>
              <Route exact path="/faq" ></Route>
              <Route exact path="/contact" ></Route>
              <Route exact path="/Home-1"  ></Route>
              <Route exact path="/Home-2"  ></Route>
              <Route exact path="/Home-3"  ></Route>
              <Route exact path="/Page-1"  ></Route>
              <Route exact path="/Page-2"  ></Route>
              <Route exact path="/page-1"  ></Route>
              <Route exact path="/page-2"  ></Route>
              <Route exact path="/page-3"  ></Route>
              <Route exact path="/page-4"  ></Route>
            </Switch>
          </Container>
        </div>
      </Router>
    </>
  );
}
export default App;