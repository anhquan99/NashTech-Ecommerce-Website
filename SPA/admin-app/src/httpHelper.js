import axios from "axios";
import AuthService from './Service/AuthenticationService';

const endpoint = process.env.REACT_APP_LOCAL_URL;
// const token = localStorage.getItem("token");

export async function get(url) {
  const authService = new AuthService();
  const user = await authService.getUser();
  console.log(user);
  const headers = {
    Accept: 'application/json',
    Authorization: 'Bearer ' + user.access_token
  };
  return axios.get(endpoint + url, {
    headers
  });
}

export async function put(url, body) {
  const authService = new AuthService();
  const user = await authService.getUser();
  const headers = {
    Accept: 'application/json',
    Authorization: 'Bearer ' + user.access_token
  };
  return axios.put(endpoint + url, body,{
    headers
  });
}

export async function post(url, body) {
  const authService = new AuthService();
  const user = await authService.getUser();
  const headers = {
    Accept: 'application/json',
    Authorization: 'Bearer ' + user.access_token
  };
  return axios.post(endpoint + url, body,{
      headers
  });
}
export async function postWithFile(url, body) {
  const authService = new AuthService();
  const user = await authService.getUser();
  return axios.post(endpoint + url, body, {
    headers: {
      'Content-Type': 'application/json',
      Authorization: 'Bearer ' + user.access_token
    }
  });
}
export async function del(url) {
  const authService = new AuthService();
  const user = await authService.getUser();
  const headers = {
    Accept: 'application/json',
    Authorization: 'Bearer ' + user.access_token
  };
  return axios.delete(endpoint + url,{
    headers
  });
}
