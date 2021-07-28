import { Log, UserManager, WebStorageStateStore } from 'oidc-client';
export default class AuthService {
    constructor() {
        const settings = {
            authority: 'https://localhost:44311/',
            client_id: 'identity-server-demo-web',
            redirect_uri: 'http://localhost:3000/',
            monitorSession: false,
            post_logout_redirect_uri: 'http://localhost:3000/',
            response_type: 'code',
            scope: 'read openid profile email',
            userStore: new WebStorageStateStore({ store: window.localStorage }) // set this to save user info in localStorage
        };
        this.userManager = new UserManager(settings);
        Log.logger = console;
        Log.level = Log.INFO;
    }
    getUser() {
        this.userManager.getUser();
        return;
    }
    login() {
        this.userManager.signinRedirect();
        return 
    }
    logout() {
        this.userManager.signoutRedirect();
        return 
    }
}