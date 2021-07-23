import React, { Component } from 'react';
import { Table, Image } from 'reactstrap';
import { get } from "../../httpHelper";
import { Link } from "react-router-dom";
import './../TableProduct/TableProduct.css';
import { faPaperPlane } from "@fortawesome/free-solid-svg-icons";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
const LOCAL_IMG_URL = process.env.REACT_APP_LOCAL_IMG_URL;
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
            <Table className="producTable" hover>
                <thead>
                    <tr>
                        <th>IMAGE</th>
                        <th>NAME</th>
                        <th>RELEASE DATE</th>
                        <th>PRICE</th>
                        <th>DETAIL</th>
                    </tr>
                </thead>
                <tbody>
                    {this.state.productList.map((product) => (

                        <tr key={product.productNameID}>
                            <td ><img className="img_td" src={LOCAL_IMG_URL + product.coverImg} /></td>
                            <td>{product.productNameID}</td>
                            <td>{product.releaseDate.substr(0, 10)}</td>
                            <td>{product.price}.00</td>
                            <td>
                                <Link to={`/updateProduct/${product.productNameID}`}>
                                    <FontAwesomeIcon icon={faPaperPlane} fixedWidth />
                                </Link>
                            </td>
                        </tr>


                    ))}
                </tbody>
            </Table>
        )
    }
}
