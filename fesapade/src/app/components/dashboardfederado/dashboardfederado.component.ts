import { Component, OnInit } from '@angular/core';
import { AuthService } from "../../services/auth.service";
import { HttpClient, HttpResponse } from '@angular/common/http';
import { FederadosService } from 'src/app/services/federados.service';

@Component({
  selector: 'app-dashboardfederado',
  templateUrl: './dashboardfederado.component.html',
  styleUrls: ['./dashboardfederado.component.css']
})
export class DashboardfederadoComponent {
  loginbtn: boolean;
  logoutbtn: boolean;
  public usuario = JSON.parse(localStorage.getItem('usuario'));
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;

  //arreglo para almacenar cursos del federado segun su ID
  fed = null;

  constructor(public authService: AuthService, public federado: FederadosService) {
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
      //almacenamos el id del localstorage en una variable y mediante el servicio de federado...
      //consultamos los datos del federado que coincida con el id, estos datos se almacenan en un arreglo...
      //que posteriormente se desplegará en el dashboard en forma de tarjetas.
      let codFederado = this.usuario.id_fed;
      this.federado.lista_cursos(parseInt(codFederado)).subscribe(result => this.fed = result);
      //una vez traidos los datos limipiamos el id del localstorage

    }

  }

  //metodo que invoca al servicio "federado" donde se almacenan los id del curso dependiendo del alumno federado
  pubscurso(codigo) {
    this.federado.setSelectedIdCurso(codigo);
  }


}
