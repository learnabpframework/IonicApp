import { Component } from '@angular/core';
import { AuthService, ConfigStateService, RestService } from '@abp/ng.core';
import { OAuthService } from 'angular-oauth2-oidc';
import { IdentityUserService } from '../proxy/volo/abp/identity';

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})
export class HomePage  {
  title = 'custom-angular';

  users = [];

  tenantName = 'host';

  get hasLoggedIn(): boolean {
    return this.oAuthService.hasValidAccessToken();
  }

  // eslint-disable-next-line @typescript-eslint/member-ordering
  constructor(
    private oAuthService: OAuthService,
    private authService: AuthService,
    private identityService: IdentityUserService,
    private config: ConfigStateService
  ) {

    this.tenantName = this.config.getDeep('currentTenant.name');

    if (this.tenantName === null) {
      this.tenantName = 'host';
    }

  }

  login() {
    this.authService.navigateToLogin();
  }

  retrieveUsers() {
    this.identityService.getList({ maxResultCount: 10 }).subscribe((result) => {
      this.users = result.items;
    });
  }

  logout() {
    this.authService.logout();
  }

}
