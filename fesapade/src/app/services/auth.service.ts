import { Injectable, NgZone } from '@angular/core';
import { HttpClientModule, HttpClient, HttpHeaders } from '@angular/common/http';
import { ToastrService } from 'ngx-toastr';
import { Router } from "@angular/router";
import { User } from "../models/user.model";
import { EmpleadosService } from './empleados.service';


@Injectable({
  providedIn: 'root'
})
export class AuthService {
  url='C:/xampp/htdocs/Proyectos/fesapade/src/app/recursos/crud_empleados/'; 

// arreglo que almacena los datos ingresados en el formulario
  usuario = {
    email: null,
    password: null
  }
  // arreglo que guardara la informacion de usuario para validaciones
  empleado = null;
  // modelo que almacenara la informacion del usuario ya auntenticado
  userData: any = {
    id: null,
    email: null,
    nombre: null
  }
  constructor(
    private httpClient: HttpClient,
    public ngZone: NgZone, // Servicio NgZone para eliminar la advertencia de alcance externo
    public toastr: ToastrService,
    public router: Router,
    private empleadoservicio: EmpleadosService
  ) { }

  
   // Iniciar sesión con correo electrónico / contraseña
   SignIn(email, password) {
    this.usuario = {
      email: email,
      password: password
    }
//usando el servicio "empleados.service" para activar el metodo "recuperarTodos" que validará si existe este usuario
      this.empleadoservicio.recuperarTodos(this.usuario).subscribe(result => this.empleado = result);
      if(this.empleado == ""){
        this.toastr.error('E-mail o contraseña incorrecta');
      }else{
    let categoria_id='';
      this.empleado.get().subscribe( 
        (data: [any]) =>{ 
      data.forEach(element =>{
        if(element.email == email){ 
          categoria_id = element.id_cate_empleado;
        }//else if(element.correo==''){
         // categoria='C';
       // }
      });
      console.log(categoria_id);
      if(categoria_id=="1"){
        
          this.ngZone.run(() => {
            this.router.navigate(['administrador']);
          });

          const userData: User = {
            id: this.empleado.id,
            email: this.empleado.email,
            nombre: this.empleado.nombre,
            apellido: this.empleado.apellido
            
          }
       
      }else if(categoria_id=='2'){
          this.ngZone.run(() => {
            this.router.navigate(['index']);
          });
          const userData: User = {
            id: this.empleado.id,
            email: this.empleado.email,
            nombre: this.empleado.nombre,
            apellido: this.empleado.apellido
            
          }
      }else {
       
          this.ngZone.run(() => {
            this.router.navigate(['index']);
          });
          const userData: User = {
            id: this.empleado.id,
            email: this.empleado.email,
            nombre: this.empleado.nombre,
            apellido: this.empleado.apellido
            
          }
      
      }
  
      
    
    
    });
  }
       
    }

   
}
