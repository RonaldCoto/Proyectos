import { Component, OnInit } from '@angular/core';
import { AuthService } from "../../services/auth.service";
import { HttpClient, HttpResponse } from '@angular/common/http';
import { EmpleadosService } from 'src/app/services/empleados.service';
@Component({
  selector: 'app-instructor',
  templateUrl: './instructor.component.html',
  styleUrls: ['./instructor.component.css']
})
export class InstructorComponent{
  loginbtn:boolean;
  logoutbtn:boolean;
  public usuario = JSON.parse(localStorage.getItem('usuario'));
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;
   //arreglo para almacenar cursos del instructor segun su ID
   ins = null;
  constructor(public authService: AuthService, public instructor: EmpleadosService) { 
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

    ngOnInit() {
      console.log(this.usuario);
         //si hay un empleado seleccionado para editar
         if(this.usuario!=null)
       {
        //almacenamos el id del localstorage en una variable y mediante el servicio de federado...
         //consultamos los datos del federado que coincida con el id, estos datos se almacenan en un arreglo...
         //que posteriormente se desplegará en el dashboard en forma de tarjetas.
         let codInstructor =  this.usuario.id_emp;
         this.instructor.lista_cursos(parseInt(codInstructor)).subscribe(result => this.ins = result);
         //una vez traidos los datos limipiamos el id del localstorage
         
       }
       }
  

}
