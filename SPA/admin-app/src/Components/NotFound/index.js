import React, { Component } from 'react'
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";

export default class index extends Component {
    constructor(props) {
        super(props);
    }
    render() {
        return (
            <div>
                
                <h1> NOT FOUND</h1>
                <h2>{this.props.message}</h2>
            </div>
        )
    }
}
