import './App.css';
import { BrowserRouter as Router } from "react-router-dom";
import "bootstrap/dist/css/bootstrap.min.css";
import SideBar from "./Components/sidebar";
import React, { useState } from "react";
import { Container } from 'reactstrap';
import Navbar from './Components/navbar'
import TableProduct from './Components/TableProduct'
import { Switch, Route, BrowserRouter } from "react-router-dom";
import AddProduct from './Components/FormAddProduct';
import UpdateProduct from './Components/FormUpdateProduct';
import NotFound from './Components/NotFound';
// import Fontal from './Components/Fontal'

function App() {
  const [sidebarIsOpen, setSidebarOpen] = useState(true);
  const toggleSidebar = () => setSidebarOpen(!sidebarIsOpen);
  return (
    <>
      <BrowserRouter>
        <div className="App wrapper">
          <SideBar toggle={toggleSidebar} isOpen={sidebarIsOpen} />
          <Container fluid>
            <Navbar name="NASH"></Navbar>
            <hr className="hr" />
            <Switch>
              <Route exact path="/" >
                <TableProduct />
              </Route>
              <Route exact path="/getProduct" >
                <TableProduct />
              </Route>
              <Route exact path="/addProduct" >
                <AddProduct />
              </Route>
              <Route exact path="/updateProduct/:product" >
                <UpdateProduct />
              </Route>
              {/* <Route exact path="/notfound" >
                <NotFound></NotFound>
              </Route> */}
              <Route path="**" >
                <NotFound></NotFound>
              </Route>
              {/* <Route exact path="/fontal"  >
                <Fontal></Fontal>
              </Route> */}
            </Switch>
          </Container>
        </div>
      </BrowserRouter>
    </>
  );
}
export default App;
