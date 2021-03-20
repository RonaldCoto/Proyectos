import { Injectable, NgZone, EventEmitter, Output } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Router } from "@angular/router";
import { User } from "../models/user.model";
import { EmpleadosService } from './empleados.service';
import { FederadosService } from './federados.service';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { map } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class AuthService {
redirectUrl: string;

URL = 'http://localhost/recursos';

baseUrl:string = "http://localhost/recursos";
  // arreglos que guardara la informacion de usuarios para validaciones
  empleado = null;
  federado = null;
  // modelo que almacenara la informacion del usuario ya auntenticado
  
  @Output() getLoggedInName: EventEmitter<any> = new EventEmitter();
  constructor(
    
    public ngZone: NgZone, // Servicio NgZone para eliminar la advertencia de alcance externo
    public toastr: ToastrService,
    public router: Router,
    private empleadoservicio: EmpleadosService,
    private federadoservicio: FederadosService,
    private http: HttpClient ,private httpClient : HttpClient
  ) {

   
   }
   public userlogin(email, password) {
    //alert(username) //aparece el usuario de la persona que metio los datos
    return this.httpClient.post<any>(this.baseUrl + '/login.php', { email, password })
    .pipe(map(Users => {
    this.setToken(Users[0].name);
    this.getLoggedInName.emit(true);
    let userData = {
      id_cate_empleado: Users[0].id_cate_empleado ,
      nombre: Users[0].nombre,
      apellido: Users[0].apellido
    }
    localStorage.setItem('usuario', JSON.stringify(userData));
    if(Users[0].id_cate_empleado == 1){
      
      this.redirectUrl='/administrador';
    }else if(Users[0].id_cate_empleado==2){
      this.redirectUrl='/instructor'
    }else{
      this.redirectUrl='/dashfederado'
    }
    return Users;
    
    }));
    }
  
  
  //token
  setToken(token: string) {
  localStorage.setItem('token', token);
  
  }
  getToken() {
  return localStorage.getItem('token');
  }
  deleteToken() {
  localStorage.removeItem('token');
  localStorage.removeItem('usuario');
  }
  isLoggedIn() {
  const usertoken = this.getToken();
  if (usertoken != null) {
  return true
  }
  return false;
  }
  
}
