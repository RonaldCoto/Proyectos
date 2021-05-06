import { Component, OnInit } from '@angular/core';
import { FederadosService } from 'src/app/services/federados.service';
import { AuthService } from "../../services/auth.service";

@Component({
  selector: 'app-listpublicaciones',
  templateUrl: './listpublicaciones.component.html',
  styleUrls: ['./listpublicaciones.component.css']
})
export class ListpublicacionesComponent {
  loginbtn: boolean;
  logoutbtn: boolean;
  public usuario = JSON.parse(localStorage.getItem('usuario'));
  public idcurso = JSON.parse(localStorage.getItem('SelectedIdCurso'));
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;

  //arreglo para almacenar publicaciones de los cursos inscritos del federado segun su ID
  publi = null;

  constructor(public authService: AuthService, public federado: FederadosService) {
    authService.getLoggedInName.subscribe(name => this.changeName(name));
    if (this.authService.isLoggedIn()) {

      console.log("loggedin");
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
    console.log(this.usuario);
       //si hay un empleado seleccionado para editar
       if(this.usuario!=null)
     {
      //almacenamos el id del localstorage en una variable y mediante el servicio de federado...
       //consultamos los datos del federado que coincida con el id, estos datos se almacenan en un arreglo...
       //que posteriormente se desplegará en el dashboard en forma de tarjetas.
       let codFederado =  this.usuario.id_fed;
       this.federado.lista_publicaciones(parseInt(codFederado),parseInt(this.idcurso)).subscribe(result => this.publi = result);
       //una vez traidos los datos limipiamos el id del localstorage
       
     }
     }

}
