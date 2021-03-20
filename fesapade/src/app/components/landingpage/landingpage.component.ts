import { Component, OnInit } from '@angular/core';
import { AuthService } from "../../services/auth.service";
import { HttpClient, HttpResponse } from '@angular/common/http';

@Component({
  selector: 'app-landingpage',
  templateUrl: './landingpage.component.html',
  styleUrls: ['./landingpage.component.css']
})
export class LandingpageComponent {
  loginbtn:boolean;
  logoutbtn:boolean;
  public usuario = JSON.parse(localStorage.getItem('usuario'));
  constructor(public authService: AuthService) { 

    authService.getLoggedInName.subscribe(name => this.changeName(name));
  if(this.authService.isLoggedIn())
  {

  console.log("loggedin");
  this.loginbtn=false;
  this.logoutbtn=true
  }
  else{
  this.loginbtn=true;
  this.logoutbtn=false
  }
  
  }
  
  private changeName(name: boolean): void {
  this.logoutbtn = name;
  this.loginbtn = !name;
  }
  logout()
  {
  this.authService.deleteToken();
  window.location.href = "/login";
  
  }
  redirect()
  {
  if(this.usuario.id_cate_empleado == 1){
    window.location.href = "/administrador";
  }else if (this.usuario.id_cate_empleado == 2){
    window.location.href = "/instructor";
  }else{
    window.location.href = "/federado";
  }
  
  
  }
  }


