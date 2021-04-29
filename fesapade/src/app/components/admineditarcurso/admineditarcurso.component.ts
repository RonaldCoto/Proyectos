import { Component, OnInit } from '@angular/core';
import { CursosService } from '../../services/cursos.service';
import { ActualizarService } from '../../services/actualizar.service';
import { parse } from 'path';
import { AuthService } from "../../services/auth.service";
import { HttpClient, HttpResponse } from '@angular/common/http';
import { SelectMultipleControlValueAccessor } from '@angular/forms';

@Component({
  selector: 'app-admineditarcurso',
  templateUrl: './admineditarcurso.component.html',
  styleUrls: ['./admineditarcurso.component.css']
})
export class AdmineditarcursoComponent{
  loginbtn:boolean;
  logoutbtn:boolean;
  public usuario = JSON.parse(localStorage.getItem('usuario'));
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;

  
  //objeto que almacena los datos del curso para actualizarlos en la bdd
   curs={
     id_curso: 0,
    nombre: null,
    descripcion: null,
   portada: null,
   estado:null,
   base64textString:null
    }
  
  constructor(public authService: AuthService,public cursoServicio: CursosService,
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


  ngOnInit() {
   
    //si hay un curso seleccionado para editar
    if(this.actualizarService.getSelectedId()!=null)
  {
   //almacenamos el id del localstorage en una variable y mediante el servicio de cursos...
    //consultamos los datos del curso que coincida con el id, estos datos se almacenan en un objeto...
    //que posteriormente se desplegará en el formulario para editar.
    this.curs = { id_curso:0, descripcion: null, nombre: null, portada: null,estado:null, base64textString:null};
    let codCurso =  this.actualizarService.getSelectedId();
    this.cursoServicio.seleccionar(parseInt(codCurso)).subscribe(result => this.curs = result[0]);
     //una vez traidos los datos limipiamos el id del localstorage
     this.actualizarService.deleteSelectedId();
  }
  }

  //evento para subida de portada
 seleccionarArchivo(event) {
  var files = event.target.files;
   let file = files[0];
  this.curs.portada = file.name;

  if(files && file) {
    var reader = new FileReader();
    reader.onload = this._handleReaderLoaded.bind(this);
    reader.readAsBinaryString(file);
  }
}

_handleReaderLoaded(readerEvent) {
  var binaryString = readerEvent.target.result;
  this.curs.base64textString = btoa(binaryString);
}


  //metodo que consume el servicio de cursos para modificar un curso segun el id seleccionado
  modificacion() {
   
  
    this.cursoServicio.modificacion(this.curs).subscribe(datos => {    
    if (datos['resultado'] == 'OK') {
   
    
      alert(datos['mensaje']);
    this.curs = { id_curso:0, descripcion: null, nombre: null, portada: null,estado:null, base64textString:null};
    }else{
      alert(datos['mensaje']);
    }
    });
    }


 
}
