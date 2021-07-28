import axios from 'axios';
import { Constants } from '../helpers/constants';
import { AuthService } from './AuthenticationService';
export class ApiService {
    constructor() {
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
        return axios.get(Constants.apiRoot + 'weatherforecast', {
            headers
        });
    }
}