import React, { Component } from 'react';
import { Table } from 'reactstrap';
import { get } from "../../httpHelper";
import { Link } from "react-router-dom";
export default class index extends Component {
    state = {
        productList: []
    };
    componentDidMount() {
        this.fetchProductList();
    }
    fetchProductList() {
        get("/api/Product").then((response) => {
            if (response.status === 200) {
                this.setState({ productList: response.data });
            }
        });
    }
    render() {
        return (
            <Table striped bordered hover>
                <thead>
                    <tr>
                        <th>#</th>
                        <th>First Name</th>
                        <th>Last Name</th>
                        <th>Username</th>
                    </tr>
                </thead>
                <tbody>
                    {this.state.productList.map((product) => (

                        <tr key={product.productNameID}>
                            <td>{product.productNameID}</td>
                            <td>{product.releaseDate}</td>
                            <td>{product.price}</td>
                            <td> <Link to={`/updateProduct/${product.productNameID}`}>
                                Detail
                            </Link>
                            </td>
                        </tr>


                    ))}
                </tbody>
            </Table>
        )
    }
}
