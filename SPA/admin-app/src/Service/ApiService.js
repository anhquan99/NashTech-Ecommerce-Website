import axios from 'axios';
import AuthService from './AuthenticationService';
export default class ApiService {
    constructor(){
        this.authService = new AuthService(); 
    }
    async callApi() {
        const user = await this.authService.getUser();
        if (user && user.access_token) {
            return this._callApi(user.access_token).catch(error => {
                if (error.response.status === 401) {
                    throw new Error('User is not logged in');
                }
                throw error;
            });
        }
        else if (user) {
            throw new Error('User is not logged in');
        }
    }
    _callApi(token) {
        const headers = {
            Accept: 'application/json',
            Authorization: 'Bearer ' + token
        };
        console.log("Call");
        return axios.get(process.env.REACT_APP_LOCAL_URL + '/api/userapi', {
            headers
        });
    }
}