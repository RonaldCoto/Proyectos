import { Component, OnInit } from '@angular/core';
import { AuthService } from "../../services/auth.service";
import { HttpClient, HttpResponse } from '@angular/common/http';
import { FederadosService } from '../../services/federados.service';
@Component({
  selector: 'app-addfederado',
  templateUrl: './addfederado.component.html',
  styleUrls: ['./addfederado.component.css']
})
export class AddfederadoComponent{
  loginbtn:boolean;
  logoutbtn:boolean;
  public usuario = JSON.parse(localStorage.getItem('usuario'));
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;

  //objeto que almacena los datos del federado para insertarlos en la bdd
  feds = {
    id: 0,
    nombre: null,
    apellido: null,
   direccion: null,
   email:null,
   password:null,
   estado:null
  }
  constructor(public authService: AuthService,public federadoServicio:FederadosService) { 
    authService.getLoggedInName.subscribe(name => this.changeName(name));
    if(this.authService.isLoggedIn())
    {
  
   
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

    //metodo que consume el servicio de federados para agregar un nuevo federado
 alta() {
  this.federadoServicio.alta(this.feds).subscribe(datos => {
  if (datos['resultado'] == 'OK') {
  
    alert(datos['mensaje']);
  this.feds =  {id: 0,nombre: null,apellido: null,direccion: null,email:null,password:null,estado:null
  };
  }else{
    alert(datos['mensaje']);
  }
  });
  }

}
