import { MsalService } from '@azure/msal-angular';
import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RoleGuard implements CanActivate {

  constructor(private msalService: MsalService) {}

  canActivate(route: ActivatedRouteSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
    const requiredRole = route.data['requiredRole'];
    const account = this.msalService.instance.getActiveAccount();

    if (account?.idTokenClaims?.roles?.includes(requiredRole)) {
      return true;
    }

    return false;
  }
  
}
