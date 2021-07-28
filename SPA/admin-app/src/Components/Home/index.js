import { signinRedirect } from '../../Service/AuthenticationService'; 
import React from 'react'
// import AuthService  from '../../Service/AuthSerTS';
export default function index() {
    // var authService = new AuthenticationService();
    const login = () =>{
        signinRedirect();
    }
    return (
        <div>
            <h1>Home</h1>
            <button onClick={login}>HOME</button>
        </div>
    )
}
