import { Component, OnInit } from '@angular/core';
import { AuthService } from "../../services/auth.service";
import { HttpClient, HttpResponse } from '@angular/common/http';
import { EmpleadosService } from '../../services/empleados.service';
import { ActualizarService } from '../../services/actualizar.service';

@Component({
  selector: 'app-administrador',
  templateUrl: './administrador.component.html',
  styleUrls: ['./administrador.component.css']
})
export class AdministradorComponent{
  loginbtn:boolean;
  logoutbtn:boolean;
  public usuario = JSON.parse(localStorage.getItem('usuario'));
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;

  //arreglo para almacenar empleados
  empleados = null;
  constructor(public authService: AuthService, public empleadoServicio: EmpleadosService,
    public actualizarService: ActualizarService) { 
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
    ngOnInit(): void {
      //invocando metodo para lista de empleados
      this.ListarEmpleados();
    }
    //metodo que consume el servicio de empleados para listar.
  ListarEmpleados() {
    this.empleadoServicio.listar().subscribe(result => this.empleados = result);
    }
//metodo que consume el servicio de empleados para eliminar un empleado seleccionado
    eliminar(codigo) {
      if (confirm('¿Desea eliminar este empleado?')) {
      this.empleadoServicio.baja(codigo).subscribe(datos => {
      if (datos['resultado'] == 'OK') {
      alert(datos['mensaje']);
      this.ListarEmpleados();
      }else{
        alert(datos['mensaje']);
      }
      });
      }
      }
//metodo que invoca al servicio "actualizar" donde se almacenan los id 
      editar(codigo){
        this.actualizarService.setSelectedId(codigo);
      }


}
