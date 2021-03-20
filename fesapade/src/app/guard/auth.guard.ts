import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { AuthService } from "../services/auth.service";
@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
   public usuario = JSON.parse(localStorage.getItem('usuario'));
  constructor(
    public authService: AuthService,
    public router: Router
  ){ }
    //Protegiendo zona de administrador
  canActivate(
    
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): boolean {
    const routeurl: string = state.url;
    return this.isLogin(routeurl);
    }
    
    isLogin(routeurl: string) {
    if (this.authService.isLoggedIn() && this.usuario.id_cate_empleado==1) {
      
        return true;
      
   
    }
    
    this.authService.redirectUrl = routeurl;
    this.router.navigate(['/index'], {queryParams: { returnUrl: routeurl }} );
    }
  
}