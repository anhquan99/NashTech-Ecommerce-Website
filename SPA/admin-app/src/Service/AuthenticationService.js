import { Log, UserManager, WebStorageStateStore } from 'oidc-client';
export default class AuthService {
  constructor() {
    const settings = {
      authority: 'https://nash-ids.azurewebsites.net/',
      client_id: 'identity-server-demo-web',
      redirect_uri: 'https://nash-spa.azurewebsites.net/signin-callback.html',
      monitorSession: false,
      post_logout_redirect_uri: 'https://nash-spa.azurewebsites.net/',
      response_type: 'code',
      scope: 'read openid profile email',
      userStore: new WebStorageStateStore({ store: window.localStorage }) // set this to save user info in localStorage
    };
    this.userManager = new UserManager(settings);
    Log.logger = console;
    Log.level = Log.INFO;
  }
  getUser() {
    return this.userManager.getUser();
    
  }
  login() {
    return this.userManager.signinRedirect();
  }
  logout() {
    return this.userManager.signoutRedirect();
  }
}