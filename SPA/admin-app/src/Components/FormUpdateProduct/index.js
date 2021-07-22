import React, { Component } from 'react';
import './../FormAddProduct/FormAddProduct.css';
import { get, postWithFile, put } from "../../httpHelper";
import { withRouter } from 'react-router-dom';
import * as moment from 'moment';
class index extends Component {
    constructor(props) {
        super(props);
        this.itemRef = [];
    }
    state = {
        wallpaper: [],
        coverImg: [],
        // use parallel array
        // img for loading image to browser
        img: [],
        // imgFiles to store current file in input
        imgFiles: [],
        message: "",
        brand: [],
        category: [],
        silhouette: [],
        type: [],
        color: [],
        product: [],
        releaseDate : "",
        productOldFile : []
    };
    async componentDidMount() {
        
        await this.fetchBrandList();
        await this.fetchCategoryList();
        await this.fetchSilhouetteList();
        await this.fetchTypeList();
        await this.fetchColorList();
        await this.fetchProduct();
    }
    setRef = (ref) => {
        this.itemRef.push(ref);
    }

    isFileImage(file) {
        return file && file['type'].split('/')[0] === 'image';
    }
    async  fetchProduct() {
         get("/api/Product/" + this.props.match.params.product).then((response) => {
            if (response.status === 200) {
                this.setState({
                    product: response.data
                });
                var date = this.state.product.releaseDate.substr(0,10);
                this.setState({releaseDate : date}) ;
            }
            else {
                console.load("FAILED TO LOAD PRODUCT");
                console.load(response.status);
            }
        }).then(()=>{
            var tempData = this.state.product.images.map((item) => item = "https://localhost:5001/" + "Utility/" + item.imageNameID); 
            this.setState({img : tempData});
            if(this.state.product.wallpaper != null){
                this.setState({ wallpaper : [this.state.product.wallpaper].map((item) => item = "https://localhost:5001/" + "Utility/" + item)});
            }
            this.setState({coverImg : [this.state.product.coverImg].map((item) => item = "https://localhost:5001/" + "Utility/" + item) });
            
            
        });
    }
    fetchBrandList() {
        get("/api/BrandApi").then((response) => {
            if (response.status === 200) {
                this.setState({
                    brand: response.data.map((item) => {
                        return item.brandNameID;
                    })
                });
            }
        });
    }
    fetchColorList() {
        get("/api/ColorApi").then((response) => {
            if (response.status === 200) {
                this.setState({
                    color: response.data.map((item) => {
                        return item.colorNameID;
                    })
                });
            }
        });
    }
    fetchCategoryList() {
        get("/api/CategoryApi").then((response) => {
            if (response.status === 200) {
                this.setState({
                    category: response.data.map((item) => {
                        return item.categoryNameID;
                    })
                });
            }
        });
    }
    fetchSilhouetteList() {
        get("/api/SilhouetteApi").then((response) => {
            if (response.status === 200) {
                this.setState({
                    silhouette: response.data.map((item) => {
                        return item.silhouetteNameID;
                    })
                });
            }
        });
    }
    fetchTypeList() {
        get("/api/TypeApi").then((response) => {
            if (response.status === 200) {
                this.setState({
                    type: response.data.map((item) => {
                        return item.typeNameID;
                    })
                });
            }
        });
    }
    renderDataList(source) {
        return source.map((item) => {
            return <option value={item} key={item}></option>
        })
    }

    handleImageChange(e, source) {
        if (e.target.files) {
            for (let i = 0; i < e.target.files.length; i++) {
                if (!this.isFileImage(e.target.files[i])) {
                    this.setState({ message: "INVALID IMAGE FILE" });
                    this.setState({ [source]: [] });
                    return;
                }
            }
            const filesArray = Array.from(e.target.files).map((file) =>
                URL.createObjectURL(file)
            );


            this.setState({ [source]: filesArray });
            Array.from(e.target.files).map(
                (file) => {
                    URL.revokeObjectURL(file);
                }
            );

            this.setState({ message: "" });
        }
    };
    async handleMultiImageChange(e) {
        if (e.target.files) {
            var files = Array.from(e.target.files);

            var oldFiles = Array.from(this.state.imgFiles);
            // // không hiểu tại sao ra được array không duplicate đáng lẽ nó phải ra phần tử không thuộc oldFiles
            // // https://stackoverflow.com/questions/1187518/how-to-get-the-difference-between-two-arrays-in-javascript
            var diffrent = Array.from(files.filter(x => !oldFiles.includes(x)));

            // console.log(this.state.imgFiles);
            await this.setState({ imgFiles: diffrent });
            // console.log(diffrent);

            for (let i = 0; i < diffrent.length; i++) {
                if (!this.isFileImage(files[i])) {
                    this.setState({ message: "INVALID IMAGE FILE" });
                    return;
                }
            }
            const filesArray = Array.from(diffrent).map((file) =>
                URL.createObjectURL(file)
            );
            await this.setState({ img: filesArray });
            // console.log(this.state.img);
            Array.from(e.target.files).map(
                (file) => {
                    URL.revokeObjectURL(file);
                    // console.log("revokeObjectURL: " + file);
                }
            );

            this.setState({ message: "" });
        }
    };
    renderPhotos(source, state) {
        return source.map((photo, i) => {
            return (<div
                id={i}
                key={photo}
                ref={this.setRef} style={{
                    backgroundImage: `url("${photo}")`,
                    border: "1px solid rgb(222, 222, 222)",
                    height: '250px',
                    backgroundColor: "white",
                    backgroundPosition: "center",
                    backgroundRepeat: "no-repeat",
                    backgroundSize: "contain",
                    position: "relative"
                }}>
                <button type="button" className="close" aria-label="Close" onClick={() => this.removeMultiPhotos({ photo }, source, state)}>
                    <span aria-hidden="true">&times;</span>
                </button>
            </div>)
        })
    }
    async handleFormSubmit(e) {
        e.preventDefault();
        var object = {};
        const formData = new FormData(e.target);
        formData.forEach(function (value, key) {
            object[key] = value;
        });
        var tempFiles = await Array.from(this.state.imgFiles);
        for (var i = 0; i < tempFiles.length; i++) {
            formData.append("imagesPost", tempFiles[i]);

        }
        for (var key of formData.entries()) {
            console.log(key[0] + ', ' + key[1])
        }
        put(`/api/Product/${this.props.match.params.product}`, formData).then((response) => {
            if (response.status === 200) {
                alert("Success");
                window.location = "/";
            }
        }).catch(function (error) {
            console.log("PUT Product field");
            return Promise.reject(error);
        });
    }
    async removeMultiPhotos(blobPhoto, source, state) {
        // let blob = await fetch(blobPhoto).then(r => r.blob());
        var tempBlob = blobPhoto.photo;
        var files = await Array.from(source);
        for (var i = 0; i < files.length; i++) {
            if (tempBlob === files[i]) {
                files.splice(i, 1);
                var tempFiles = this.state.imgFiles;
                tempFiles.splice(i, 1);
                this.setState({ imgFiles: tempFiles });
                console.log(this.state.imgFiles);
                await this.setState({ [state]: files });
                break;
            }
        }

    }
    render() {
        return (
            <form className="form" onSubmit={(e) => this.handleFormSubmit(e)} encType="multipart/form-data">
                <h2 className="textareas">ADD NEW PRODUCT</h2>
                <div className="form-group">
                    <label htmlFor="productNameID">PRODUCT NAME</label>
                    <input type="text" className="form-control" id="productNameID" placeholder="ENTER PRODUCT NAME" value={this.state.product.productNameID} defaultValue="" name="productNameID" />
                </div>


                <div className="form-row">
                    <div className="form-group col-md-6">
                        <label htmlFor="releaseDate">RELEASE DATE</label>
                        <input type="date" className="form-control" id="releaseDate" name="releaseDate" placeholder="ENTER RELEASE DATE" value={this.state.releaseDate} defaultValue="" />
                    </div>
                    <div className="form-group col-md-6">
                        <label htmlFor="upperMaterial">UPPER MATERIAL</label>
                        <input type="text" className="form-control" id="upperMaterial" name="upperMaterial" value={this.state.product.upperMaterial} placeholder="ENTER UPPER MATERIAL" defaultValue="" />
                    </div>
                </div>


                <div className="form-row">
                    <div className="form-group col-md-6">
                        <label htmlFor="color">COLOR</label>
                        <input type="text" className="form-control" id="color" name="color" placeholder="ENTER COLOR" value={this.state.product.color} list="colors" defaultValue=""/>
                        <datalist id="colors">{this.renderDataList(this.state.color)}</datalist>
                    </div>
                    <div className="form-group col-md-6">
                        <label htmlFor="colorway">COLOWAY</label>
                        <input type="text" className="form-control" id="colorway" name="colorway" placeholder="ENTER COLORWAY" value={this.state.product.colorWay} defaultValue="" />
                    </div>
                </div>


                <div className="form-row">
                    <div className="form-group col-md-6">
                        <label htmlFor="price">PRICE</label>
                        <input type="number" className="form-control" id="price" name="price" placeholder="ENTER PRICE" value={this.state.product.price}  defaultValue=""/>
                    </div>
                    <div className="form-group col-md-6">
                        <label htmlFor="usedPrice">USED PRICE</label>
                        <input type="number" className="form-control" id="usedPrice" name="usedPrice" placeholder="ENTER USED PRICE" value={this.state.product.usedPrice} defaultValue="" />
                    </div>
                </div>


                <div className="form-row">
                    <div className="form-group col-md-6">
                        <label htmlFor="brand">BRAND</label>
                        <input type="text" className="form-control" id="brand" name="brand" placeholder="ENTER BRAND" list="brands" value={this.state.product.brand} defaultValue=""/>
                        <datalist id="brands">{this.renderDataList(this.state.brand)}</datalist>
                    </div>
                    <div className="form-group col-md-6">
                        <label htmlFor="silhouette">SILHOUTTE</label>
                        <input type="text" className="form-control" id="silhouette" name="silhouette" placeholder="ENTER SILHOUTTE" list="silhouettes" value={this.state.product.silhouette} defaultValue=""/>
                        <datalist id="silhouettes">{this.renderDataList(this.state.silhouette)}</datalist>
                    </div>
                </div>


                <div className="form-row">
                    <div className="form-group col-md-6">
                        <label htmlFor="category">CATEGORY</label>
                        <input type="text" className="form-control" id="category" name="category" placeholder="ENTER CATEGORY" list="categories" value={this.state.product.category} defaultValue="" />
                        <datalist id="categories">{this.renderDataList(this.state.category)}</datalist>
                    </div>
                    <div className="form-group col-md-6">
                        <label htmlFor="type">TYPE</label>
                        <input type="text" className="form-control" id="type" name="type" placeholder="ENTER TYPE" list="types" value={this.state.product.type} defaultValue="" />
                        <datalist id="types">{this.renderDataList(this.state.type)}</datalist>
                    </div>
                </div>


                <div className="form-group">
                    <label htmlFor="story">STORY</label>
                    <textarea className="form-control text_area" id="story" name="story" placeholder="ENTER STORY" value={this.state.product.story} defaultValue="" />
                </div>

                <div className="input-group mb-3">
                    <div className="input-group-prepend">
                        <span className="input-group-text">UPLOAD PRODUCT IMAGE</span>
                    </div>
                    <div className="custom-file">
                        <input type="file" className="custom-file-input" id="productImage" multiple="multiple" accept="image/*" onChange={(e) => this.handleMultiImageChange(e, "img", "imgFiles")} />
                        <label className="custom-file-label" htmlFor="productImage">Choose file</label>
                    </div>
                </div>
                <div className="grid">
                {this.renderPhotos(this.state.img, "img")}</div>
                <hr></hr>

                <div className="input-group mb-3">
                    <div className="input-group-prepend">
                        <span className="input-group-text">UPLOAD PRODUCT COVER</span>
                    </div>
                    <div className="custom-file">
                        <input type="file" className="custom-file-input" id="productCover" name="coverImagePost" accept="image/*" onChange={(e) => this.handleImageChange(e, "coverImg")} />
                        <label className="custom-file-label" htmlFor="productCover">Choose file</label>
                    </div>
                </div>
                <div className="grid">
                {this.renderPhotos(this.state.coverImg, "coverImg")}
                </div>
                <hr></hr>

                <div className="input-group mb-3">
                    <div className="input-group-prepend">
                        <span className="input-group-text">UPLOAD PRODUCT WALLPAPER</span>
                    </div>
                    <div className="custom-file">
                        <input type="file" className="custom-file-input" id="productWallpaper" name="wallpaperImagePost" accept="image/*" onChange={(e) => this.handleImageChange(e, "wallpaper")} />
                        <label className="custom-file-label" htmlFor="productWallpaper">Choose file</label>
                    </div>
                </div>
                <div className="grid">
                {this.renderPhotos(this.state.wallpaper, "wallpaper")}
                </div>
                <hr></hr>

                <div className="col text-center">
                    <label className="error">{this.state.message}</label>
                </div>
                <div className="col text-center button">
                    <button type="submit" className="btn form-btn col-md-2 ">UPDATE</button>
                </div>


            </form>
        )
    }
}
export default withRouter(index);