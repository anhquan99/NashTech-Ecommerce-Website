import ApiService  from "../../Service/ApiService";
import React, { Component } from 'react'
import AuthService from '../../Service/AuthenticationService';
export default class index extends Component {
    constructor(){
        super();
        this.authService = new AuthService();  
        this.apiService = new ApiService();
    }
    async mygetUser(){
        const user = await this.authService.getUser();
        console.log(await this.apiService._callApi(user.access_token));
    }
    render() {
        return (
            <div>
                 <button onClick={() => this.mygetUser()}>CLick</button>
            </div>
        )
    }
}


