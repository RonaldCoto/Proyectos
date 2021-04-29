import { Component, OnInit } from '@angular/core';
import { CursosService } from '../../services/cursos.service';
import { AuthService } from "../../services/auth.service";
import { HttpClient, HttpResponse } from '@angular/common/http';

@Component({
  selector: 'app-crearcurso',
  templateUrl: './crearcurso.component.html',
  styleUrls: ['./crearcurso.component.css']
})
export class CrearcursoComponent{
  loginbtn:boolean;
  logoutbtn:boolean;
  public usuario = JSON.parse(localStorage.getItem('usuario'));
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;
  
  //objeto que almacena los datos del curso para insterarlos en la bdd
  curs = {
    id: 0,
    nombre: null,
    descripcion: null,
   portada: null,
   estado:null,
   base64textString: null
  }
  //arreglo que almacenará el nomnre de la imagen seleccionada para subir
  constructor(public authService: AuthService,private cursoServicio: CursosService) { 
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
  ngOnInit(): void {
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



    //metodo que consume el servicio de cursos para agregar un nuevo curso
  alta() {
   
    this.cursoServicio.alta(this.curs).subscribe(datos => {
    if (datos['resultado'] == 'OK') {
    alert(datos['mensaje']);
    
    this.curs = {id: 0, descripcion: null, nombre: null, portada: null,estado:null,base64textString:null};
    }else{
      alert(datos['mensaje']);
    }
    });
    }


}
