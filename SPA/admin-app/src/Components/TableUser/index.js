import React, { Component } from 'react';
import { Table, Image, Button } from 'reactstrap';
import { get, put, del } from "../../httpHelper";
import './../TableProduct/TableProduct.css';
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { Link } from "react-router-dom";
import { faLevelUpAlt, faBan } from '@fortawesome/free-solid-svg-icons';
const LOCAL_IMG_URL = process.env.REACT_APP_LOCAL_IMG_URL;
export default class index extends Component {
    state = {
        userList: []
    };
    componentDidMount() {
        this.fetchUserList();
    }
    fetchUserList() {
        get("/api/UserApi").then((response) => {
            if (response.status === 200) {
                console.log(response.data);
                this.setState({ userList: response.data });
            }
        });
    }
    update(email) {
        put("/api/UserApi/" + email).then((response) => {
            if (response.status === 200) {
                this.fetchUserList();
            }
            else {
                alert(response.status);
            }
        });

    }
    delete(email) {
        del("/api/UserApi/" + email).then((response) => {
            if (response.status === 200) {
                this.fetchUserList();
            }
            else {
                alert(response.status);
            }
        });

    }
    render() {
        return (
            <Table hover>
                <thead>
                    <tr>
                        <th>EMAIL</th>
                        <th>FULL NAME</th>
                        <th>ADDRESS</th>
                        <th>ROLE</th>
                        <th>PROMOTE TO ADMIN</th>
                        <th>DELETE</th>
                    </tr>
                </thead>
                <tbody>
                    {this.state.userList.map((user) => (

                        <tr key={user.email}>
                            <td>{user.email}</td>
                            <td>{user.fullName}</td>
                            <td>{user.address}</td>
                            <td>{user.role}</td>
                            <td>
                            <Link onClick={() => this.update(user.email)} to={`#`}>
                                    <FontAwesomeIcon icon={faLevelUpAlt} fixedWidth />
                                </Link>
                            </td>
                            <td>
                            <Link onClick={() => this.delete(user.email)} to={`#`}>
                                    <FontAwesomeIcon icon={faBan} fixedWidth />
                                </Link>
                            </td>
                        </tr>


                    ))}
                </tbody>
            </Table>
        )
    }
}
