import axios from 'axios';
import { AuthenticationService } from './AuthenticationService';

export default class ApiService {
    authenticationService;
    constructor() {
        this.authenticationService = new AuthenticationService()
    }
    callApi = async () => {
        const user = await this.authenticationService.getUser();
        if (user && user.access_token) {
            return this._callApi(user.access_token).cacth(error => {
                if (error.response.status === 401) {
                    throw new Error("USER NOT LOGGED IN");
                }
                throw error;
            });
        }
        else if (user) {
            throw new Error("USER NOT LOGGED IN");
        }
    }
    _callApi = ( token) =>{
        const headers = {
            Accept : "application/json",
            Authorization : "Bearer " + token
        };
        return axios.get(process.env.REACT_APP_LOCAL_URL + "/getuser"); 
    }
}
