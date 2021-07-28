import AuthService from '../../Service/AuthenticationService'; 
import {ReactElement} from 'react'
// import AuthService  from '../../Service/AuthSerTS';

export default function index(): ReactElement {
    const authService = new AuthService();
    const login = () => {
        authService.login();
    };
    return (
        <div>
            <h1>Home</h1>
            <button onClick={login}>LOGIN</button>
        </div>
    )
}
