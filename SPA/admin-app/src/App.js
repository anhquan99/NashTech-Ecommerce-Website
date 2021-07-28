// import './App.css';
// import { BrowserRouter as Router } from "react-router-dom";
// import "bootstrap/dist/css/bootstrap.min.css";
// import SideBar from "./Components/sidebar";
// import React, { useState } from "react";
// import { Container } from 'reactstrap';
// import Navbar from './Components/navbar'
// import TableProduct from './Components/TableProduct'
// import { Switch, Route, BrowserRouter } from "react-router-dom";
// import AddProduct from './Components/FormAddProduct';
// import UpdateProduct from './Components/FormUpdateProduct';
// import NotFound from './Components/NotFound';
// import TableUser from './Components/TableUser';
// import TableAdmin from './Components/TableAdmin';
// import Home from './Components/Home';
// import Fontal from './Components/Fontal'

// // import Fontal from './Components/Fontal'

// function App() {
//   const [sidebarIsOpen, setSidebarOpen] = useState(true);
//   const toggleSidebar = () => setSidebarOpen(!sidebarIsOpen);
//   return (
//     <>
//       <BrowserRouter>
//         <div className="App wrapper">
//           <SideBar toggle={toggleSidebar} isOpen={sidebarIsOpen} />
//           <Container fluid>
//             <Navbar name="NASH"></Navbar>
//             <hr className="hr" />
//             <Switch>
//               <Route exact path="/" >
//                 <Home />
//               </Route>
//               <Route exact path="/getProduct" >
//                 <TableProduct />
//               </Route>
//               <Route exact path="/addProduct" >
//                 <AddProduct />
//               </Route>
//               <Route exact path="/updateProduct/:product" >
//                 <UpdateProduct />
//               </Route>
//               <Route exact path="/getuser"  >
//                 <TableUser></TableUser>
//               </Route>
//               <Route exact path="/getadmin"  >
//                 <TableAdmin></TableAdmin>
//               </Route>
//               <Route exact path="/fontal"  >
//                 <Fontal></Fontal>
//               </Route>
//               {/* <Route exact path="/notfound" >
//                 <NotFound></NotFound>
//               </Route> */}
//               <Route path="**" >
//                 <NotFound></NotFound>
//               </Route>
              
//             </Switch>
//           </Container>
//         </div>
//       </BrowserRouter>
//     </>
//   );
// }
// export default App;



import './App.css';
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
import TableUser from './Components/TableUser';
import TableAdmin from './Components/TableAdmin';
import { GuardedRoute, GuardProvider } from 'react-router-guards';
import AuthenticationService from './Service/AuthenticationService';
import { NOTFOUND } from 'dns';
import Home from './Components/Home'
const authService = new AuthenticationService();
const requireLogin = async (to: any, from: any, next: any) => {
  if (to.meta.auth) {
    if (await authService.getUser()) {
      next();
    } else {
      authService.login();
    }
  } else {
    if (await authService.getUser()) {
      next.redirect('/');
    } else {
      next();
    }
  }
};

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
            <GuardProvider guards={[requireLogin]} error={NOTFOUND}>

              <Switch>

                <GuardedRoute exact path="/" >
                  <Home />
                </GuardedRoute>

                <GuardedRoute exact path="/getProduct" meta={{ auth: true }} >
                  <TableProduct />
                </GuardedRoute>

                <GuardedRoute exact path="/addProduct" meta={{ auth: true }} >
                  <AddProduct />
                </GuardedRoute>

                <GuardedRoute exact path="/updateProduct/:product" meta={{ auth: true }} >
                  <UpdateProduct />
                </GuardedRoute>

                <GuardedRoute exact path="/getuser" meta={{ auth: true }}  >
                  <TableUser></TableUser>
                </GuardedRoute>

                <GuardedRoute exact path="/getadmin" meta={{ auth: true }}   >
                  <TableAdmin></TableAdmin>
                </GuardedRoute>

                <Route path="**" >
                  <NotFound></NotFound>
                </Route>
              </Switch>

            </GuardProvider>
          </Container>
        </div>
      </BrowserRouter>
    </>
  );
}
export default App;
