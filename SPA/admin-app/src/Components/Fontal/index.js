import authority  from "../../Service/AuthenticationService";
import React, { Component } from 'react'

export default class index extends Component {
    mygetUser(){
        // getUser().then((user) => {
        //   if (user) {
        //     console.log("User details: " + JSON.stringify(user));
            
        //   } else {
        //     console.log('You are not logged in.');
        //   }
        // });
        var auth = new authority();
        var user = authority.getUser;
        var token = window.localStorage;
        console.log(user);
    }
    render() {
        return (
            <div>
                 <button onClick={() => this.mygetUser()}>CLick</button>
            </div>
        )
    }
}


