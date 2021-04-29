import { Component, OnInit } from '@angular/core';
import { AuthService } from "../../services/auth.service";
import { HttpClient, HttpResponse } from '@angular/common/http';
import { FederadosService } from '../../services/federados.service';
import { ActualizarService } from '../../services/actualizar.service';
@Component({
  selector: 'app-administrarfederado',
  templateUrl: './administrarfederado.component.html',
  styleUrls: ['./administrarfederado.component.css']
})
export class AdministrarfederadoComponent{
  loginbtn:boolean;
  logoutbtn:boolean;
  public usuario = JSON.parse(localStorage.getItem('usuario'));
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;
   //arreglo para almacenar federados
   federados = null;
  constructor(public authService: AuthService,public federadoServicio:FederadosService,
    public actualizarService:ActualizarService) { 
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
      //invocando metodo para lista de federados
      this.ListarFederados();
    }
    //metodo que consume el servicio de federados para listar.
  ListarFederados() {
    this.federadoServicio.listar().subscribe(result => this.federados = result);
    }
//metodo que consume el servicio de federados para eliminar un federado seleccionado
    eliminar(codigo) {
      if (confirm('¿Desea eliminar este federado?')) {
      this.federadoServicio.baja(codigo).subscribe(datos => {
      if (datos['resultado'] == 'OK') {
      alert(datos['mensaje']);
      this.ListarFederados();
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
