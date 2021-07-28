import { UserManager, WebStorageStateStore } from 'oidc-client';
// import { storeUserError, storeUser } from '../actions/authActions'

const config = {
    authority: process.env.REACT_APP_LOCAL_AUTHORITY,
    client_id: process.env.REACT_APP_LOCAL_CLIENT_ID,
    redirect_uri: process.env.REACT_APP_LOCAL_REDIRECT_URL,
    monitorSession: false,
    post_logout_redirect_uri: process.env.REACT_APP_LOCAL_LOGOUT_URL,
    response_type: 'code', // for Auth Code flow
    scope: process.env.REACT_APP_LOCAL_SCOPE,
    userStore: new WebStorageStateStore({ store: window.localStorage }) // set this to save user info in localStorage
  };

const userManager = new UserManager(config)

export async function loadUserFromStorage(store) {
    return await this.userManager.getUser();
//   try {
//     let user = await userManager.getUser()
//     // if (!user) { return store.dispatch(storeUserError()) }
//     // store.dispatch(storeUser(user))
//   } catch (e) {
//     console.error(`User not found: ${e}`)
//     // store.dispatch(storeUserError())
//   }
}

export function signinRedirect() {
  return userManager.signinRedirect()
}

export function signinRedirectCallback() {
  return userManager.signoutRedirect()
}

export function signoutRedirect() {
  userManager.clearStaleState()
  userManager.removeUser()
  return userManager.signoutRedirect()
}

export function signoutRedirectCallback() {
  userManager.clearStaleState()
  userManager.removeUser()
  return userManager.signoutRedirectCallback()
}

export default userManager