import axios from "axios";

const endpoint = process.env.REACT_APP_LOCAL_URL;
// const token = localStorage.getItem("token");

export function get(url) {
//   console.log(token);
  return axios.get(endpoint + url, {
    // headers: { Authorization: `Bearer ${token}` },
  });
}

export function put(url, body) {
  return axios.put(endpoint + url, body);
}

export function post(url, body) {
  return axios.post(endpoint + url, body);
}
export function postWithFile(url, body) {
  return axios.post(endpoint + url, body,{
    headers: {
      'Content-Type': 'application/json',
    }
  });
}
export function del(url) {
  return axios.delete(endpoint + url);
}
