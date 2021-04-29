import { Component, OnInit } from '@angular/core';
import { AuthService } from "../../services/auth.service";
import { HttpClient, HttpResponse } from '@angular/common/http';
import { EmpleadosService } from '../../services/empleados.service'
@Component({
  selector: 'app-addempleado',
  templateUrl: './addempleado.component.html',
  styleUrls: ['./addempleado.component.css']
})
export class AddempleadoComponent{
  loginbtn:boolean;
  logoutbtn:boolean;
  public usuario = JSON.parse(localStorage.getItem('usuario'));
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;

  //objeto que almacena los datos del empleado para insertarlos en la bdd
  emps = {
    id: 0,
    nombre: null,
    apellido: null,
   direccion: null,
   email:null,
   password:null,
   id_cate_empleado:0,
   estado:null
  }
  constructor(public authService: AuthService,public empleadoServicio:EmpleadosService) { 
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

 //metodo que consume el servicio de empleados para agregar un nuevo empleado
 alta() {
   
  this.empleadoServicio.alta(this.emps).subscribe(datos => {
  if (datos['resultado'] == 'OK') {
  alert(datos['mensaje']);
  
  this.emps =  {id: 0,nombre: null,apellido: null,direccion: null,email:null,password:null,id_cate_empleado:0,estado:null
  };
  }else{
  
    alert(datos['mensaje']);
  }
  });
  }
}
