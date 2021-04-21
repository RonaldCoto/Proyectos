import { Component, OnInit } from '@angular/core';
import { AuthService } from "../../services/auth.service";
import { HttpClient, HttpResponse } from '@angular/common/http';

@Component({
  selector: 'app-asignarcurso',
  templateUrl: './asignarcurso.component.html',
  styleUrls: ['./asignarcurso.component.css']
})
export class AsignarcursoComponent{
  loginbtn:boolean;
  logoutbtn:boolean;
  public usuario = JSON.parse(localStorage.getItem('usuario'));
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;
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


}
