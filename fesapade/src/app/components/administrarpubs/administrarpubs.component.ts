import { Component, OnInit } from '@angular/core';
import { AuthService } from "../../services/auth.service";
import { HttpClient, HttpResponse } from '@angular/common/http';
import { PublicacionesService } from 'src/app/services/publicaciones.service';
import { ActualizarService } from 'src/app/services/actualizar.service';
@Component({
  selector: 'app-administrarpubs',
  templateUrl: './administrarpubs.component.html',
  styleUrls: ['./administrarpubs.component.css']
})
export class AdministrarpubsComponent {
  loginbtn: boolean;
  logoutbtn: boolean;
  //arrreglo que almacena las publicaciones del instructor logueado
  pubs=null;
  public usuario = JSON.parse(localStorage.getItem('usuario'));
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;
  constructor(public authService: AuthService,public publicacionesService: PublicacionesService,
    public actualizarService: ActualizarService) {
    authService.getLoggedInName.subscribe(name => this.changeName(name));
    if (this.authService.isLoggedIn()) {

      this.loginbtn = false;
      this.logoutbtn = true
    }
    else {
      this.loginbtn = true;
      this.logoutbtn = false
    }
  }

  private changeName(name: boolean): void {
    this.logoutbtn = name;
    this.loginbtn = !name;
  }
  logout() {
    this.authService.deleteToken();
    window.location.href = "/login";

  }

  ngOnInit() {
    //console.log(this.usuario);
    //si hay un empleado seleccionado para editar
    if (this.usuario != null) {
         //invocando metodo para lista de publicaciones     
         this.ListarPublicaciones();

    }

  }

    //metodo que consume el servicio de publicaciones para listar.
    ListarPublicaciones() {
        //se consume el servicio de publicaciones, invocando el metodo que trae las publicaciones del instructor
      // que se encuentra logueado
      let codempleado = this.usuario.id_emp;
      this.publicacionesService.lista_pubs_instructor(parseInt(codempleado)).subscribe(result => this.pubs = result);
       }

       //metodo que consume el servicio de publicaciones para eliminar una publicacion seleccionada
    eliminar(codigo) {
      if (confirm('¡PELIGRO!\nEsta a punto de eliminar una publicacion.\n¿Desea continuar?')) {
      this.publicacionesService.baja(codigo).subscribe(datos => {
      if (datos['resultado'] == 'OK') {
      alert(datos['mensaje']);
      this.ListarPublicaciones();
      }else{
        alert('¡Ha ocurrido un error!');
      }
      });
      }
      }

    //metodo que invoca al servicio "actualizarService" donde se almacenan el id de la publicacion seleccionada
    pub(codigo) {
      this.actualizarService.setSelectedId(codigo);
    }


}
