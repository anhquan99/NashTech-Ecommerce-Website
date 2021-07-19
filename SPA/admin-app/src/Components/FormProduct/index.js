import React, { Component } from 'react'
import './../FormProduct/FormProduct.css';
import { get, post } from "../../httpHelper";
export default class index extends Component {
    state = {
        wallpaper: [],
        coverImg: [],
        img: [],
        message: "",
        brand:[],
        category:[],
        silhouette:[],
        type:[],
        color:[]
    };
    componentDidMount(){
        this.fetchBrandList();
        this.fetchCategoryList();
        this.fetchSilhouetteList();
        this.fetchTypeList();
        this.fetchColorList();
    }
    isFileImage(file) {
        return file && file['type'].split('/')[0] === 'image';
    }
    fetchBrandList() {
        get("/api/BrandApi").then((response) => {
            if (response.status === 200) {
                this.setState({brand: response.data.map((item)=>{
                    return item.brandNameID;
                })});
            }
            console.log("brand: " + this.state.brand);
        });
    }
    fetchColorList() {
        get("/api/ColorApi").then((response) => {
            if (response.status === 200) {
                this.setState({color: response.data.map((item)=>{
                    return item.colorNameID;
                })});
            }
            console.log(this.state.color);
        });
    }
    fetchCategoryList() {
        get("/api/CategoryApi").then((response) => {
            if (response.status === 200) {
                this.setState({category: response.data.map((item)=>{
                    return item.categoryNameID;
                })});
            }
            console.log(this.state.category);
        });
    }
    fetchSilhouetteList() {
        get("/api/SilhouetteApi").then((response) => {
            if (response.status === 200) {
                this.setState({silhouette: response.data.map((item)=>{
                    return item.silhouetteNameID;
                })});
            }
            console.log(this.state.silhouette);
        });
    }
    fetchTypeList() {
        get("/api/TypeApi").then((response) => {
            if (response.status === 200) {
                this.setState({type: response.data.map((item)=>{
                    return item.typeNameID;
                })});
            }
            console.log(this.state.type);

        });
    }
    renderDataList(source){
        return source.map((item)=>{
            return <option value={item}></option>
        })
    }

    handleImageChange(e, source) {
        // console.log(e.target.files);
        if (e.target.files) {
            // console.log(e.target.files.length);
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

            // console.log("filesArray: ", filesArray);

            this.setState({ [source]: filesArray });
            Array.from(e.target.files).map(
                (file) => URL.revokeObjectURL(file) // avoid memory leak
            );
            this.setState({ message: "" });
        }
    };
    renderPhotos(source) {
        // console.log(source);
        return source.map((photo) => {
            return <img src={photo} alt="" key={photo} />
        })
    }
    handleFormSubmit(e){
        e.preventDefault();
        post("/api/Product").then((response) => {
            console.log(response);
            // if (response.status === 200) {
            //     this.setState({brand: response.data.map((item)=>{
            //         return item.brandNameID;
            //     })});
            // }
            // console.log("brand: " + this.state.brand);
        });
    }
    render() {
        return (
            <form className="form" onSubmit={(e) => this.handleFormSubmit(e)}>
                <h2 className="textareas">ADD NEW PRODUCT</h2>
                <div className="form-group">
                    <label htmlFor="productNameID">PRODUCT NAME</label>
                    <input type="text" className="form-control" id="productNameID" placeholder="ENTER PRODUCT NAME" name="productNameID" />
                </div>


                <div className="form-row">
                    <div className="form-group col-md-6">
                        <label htmlFor="releaseDate">RELEASE DATE</label>
                        <input type="date" className="form-control" id="releaseDate" name="releaseDate" placeholder="ENTER RELEASE DATE" />
                    </div>
                    <div className="form-group col-md-6">
                        <label htmlFor="upperMaterial">UPPER MATERIAL</label>
                        <input type="text" className="form-control" id="upperMaterial" name="upperMaterial" placeholder="ENTER UPPER MATERIAL" />
                    </div>
                </div>


                <div className="form-row">
                    <div className="form-group col-md-6">
                        <label htmlFor="color">COLOR</label>
                        <input type="text" className="form-control" id="color" name="color" placeholder="ENTER COLOR" list="colors"/>
                        <datalist id="colors">{this.renderDataList(this.state.color)}</datalist>
                    </div>
                    <div className="form-group col-md-6">
                        <label htmlFor="colorway">COLOWAY</label>
                        <input type="text" className="form-control" id="colorway" name="colorway" placeholder="ENTER COLORWAY" />
                    </div>
                </div>


                <div className="form-row">
                    <div className="form-group col-md-6">
                        <label htmlFor="price">PRICE</label>
                        <input type="text" className="form-control" id="price" name="price" placeholder="ENTER PRICE" />
                    </div>
                    <div className="form-group col-md-6">
                        <label htmlFor="usedPrice">USED PRICE</label>
                        <input type="text" className="form-control" id="usedPrice" name="usedPrice" placeholder="ENTER USED PRICE" />
                    </div>
                </div>


                <div className="form-row">
                    <div className="form-group col-md-6">
                        <label htmlFor="brand">BRAND</label>
                        <input type="text" className="form-control" id="brand" name="brand" placeholder="ENTER BRAND" list="brands"/>
                        <datalist id="brands">{this.renderDataList(this.state.brand)}</datalist>
                    </div>
                    <div className="form-group col-md-6">
                        <label htmlFor="silhouette">SILHOUTTE</label>
                        <input type="text" className="form-control" id="silhouette" name="silhouette" placeholder="ENTER SILHOUTTE" list="silhouettes"/>
                        <datalist id="silhouettes">{this.renderDataList(this.state.silhouette)}</datalist>
                    </div>
                </div>


                <div className="form-row">
                    <div className="form-group col-md-6">
                        <label htmlFor="category">CATEGORY</label>
                        <input type="text" className="form-control" id="category" name="category" placeholder="ENTER CATEGORY" list="categories" />
                        <datalist id="categories">{this.renderDataList(this.state.category)}</datalist>
                    </div>
                    <div className="form-group col-md-6">
                        <label htmlFor="type">TYPE</label>
                        <input type="text" className="form-control" id="type" name="type" placeholder="ENTER TYPE" list="types"/>
                        <datalist id="types">{this.renderDataList(this.state.type)}</datalist>
                    </div>
                </div>


                <div className="form-group">
                    <label htmlFor="story">STORY</label>
                    <textarea className="form-control text_area" id="story" name="story" placeholder="ENTER STORY" />
                </div>

                <div className="input-group mb-3">
                    <div className="input-group-prepend">
                        <span className="input-group-text">UPLOAD PRODUCT IMAGE</span>
                    </div>
                    <div className="custom-file">
                        <input type="file" className="custom-file-input" id="productImage" name="images" multiple="multiple" accept="image/*" onChange={(e) => this.handleImageChange(e, "img")} />
                        <label className="custom-file-label" for="productImage">Choose file</label>
                    </div>
                </div>
                <div className="grid">{this.renderPhotos(this.state.img)}</div>
                <hr></hr>

                <div className="input-group mb-3">
                    <div className="input-group-prepend">
                        <span className="input-group-text">UPLOAD PRODUCT COVER</span>
                    </div>
                    <div className="custom-file">
                        <input type="file" className="custom-file-input" id="productCover" name="coverImage" accept="image/*" onChange={(e) => this.handleImageChange(e, "coverImg")} />
                        <label className="custom-file-label" for="productCover">Choose file</label>
                    </div>
                </div>
                <div className="grid">{this.renderPhotos(this.state.coverImg)}</div>
                <hr></hr>

                <div className="input-group mb-3">
                    <div className="input-group-prepend">
                        <span className="input-group-text">UPLOAD PRODUCT WALLPAPER</span>
                    </div>
                    <div className="custom-file">
                        <input type="file" className="custom-file-input" id="productWallpaper" name="wallpaperImage" accept="image/*" onChange={(e) => this.handleImageChange(e, "wallpaper")} />
                        <label className="custom-file-label" for="productWallpaper">Choose file</label>
                    </div>
                </div>
                <div className="grid">{this.renderPhotos(this.state.wallpaper)}</div>
                <hr></hr>

                <div className="col text-center">
                    <label className="error">{this.state.message}</label>
                </div>
                <div className="col text-center button">
                    <button type="submit" className="btn form-btn col-md-3 ">ADD</button>
                </div>


            </form>
        )
    }
}
