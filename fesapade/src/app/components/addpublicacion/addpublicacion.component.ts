import { Component, OnInit } from '@angular/core';
import { AuthService } from "../../services/auth.service";
import { HttpClient, HttpResponse } from '@angular/common/http';
import { EmpleadosService } from 'src/app/services/empleados.service';

@Component({
  selector: 'app-addpublicacion',
  templateUrl: './addpublicacion.component.html',
  styleUrls: ['./addpublicacion.component.css']
})
export class AddpublicacionComponent {
  loginbtn: boolean;
  logoutbtn: boolean;
  curs = null;
  public usuario = JSON.parse(localStorage.getItem('usuario'));
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;

  //objeto que almacena los datos del curso para insterarlos en la bdd
  pub = {
    id: 0,
    titulo: null,
    descripcion: null,
    portada: null,
    id_asignacion_curso: null,
    base64textString: null
  }
  constructor(public authService: AuthService, public cursoid: EmpleadosService) {
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
    if (this.usuario != null) {
      //almacenamos el id del localstorage en una variable y mediante el servicio de federado...
      //consultamos los datos del federado que coincida con el id, estos datos se almacenan en un arreglo...
      //que posteriormente se desplegará en el dashboard en forma de tarjetas.
      let codInstructor = this.usuario.id_emp;
      this.cursoid.lista_cursos_select(parseInt(codInstructor)).subscribe(result => this.curs = result);
      //una vez traidos los datos limipiamos el id del localstorage

    }
  }

  //evento para subida de portada
  seleccionarArchivo(event) {
    var files = event.target.files;
    let file = files[0];
    this.pub.portada = file.name;

    if (files && file) {
      var reader = new FileReader();
      reader.onload = this._handleReaderLoaded.bind(this);
      reader.readAsBinaryString(file);
    }
  }

  _handleReaderLoaded(readerEvent) {
    var binaryString = readerEvent.target.result;
    this.pub.base64textString = btoa(binaryString);
  }

    //metodo que consume el servicio de empleados para agregar una nueva publicacion
    publicar() {
   
      this.cursoid.agregar_publicacion(this.pub).subscribe(datos => {
      if (datos['resultado'] == 'OK') {
      alert(datos['mensaje']);
      
      this.pub = {id: 0, titulo: null, descripcion: null, portada: null,id_asignacion_curso:null,base64textString:null};
      }else{
        alert(datos['mensaje']);
      }
      });
      }
  

}
