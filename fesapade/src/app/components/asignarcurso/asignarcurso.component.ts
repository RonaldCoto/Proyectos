import { Component, OnInit } from '@angular/core';
import { AuthService } from "../../services/auth.service";
import { HttpClient, HttpResponse } from '@angular/common/http';
import { CursosService } from '../../services/cursos.service';
import { FederadosService } from '../../services/federados.service';
import { AsignacionesCursosService} from '../../services/asignaciones-cursos.service'
import { MatriculasService} from '../../services/matriculas.service'
@Component({
  selector: 'app-asignarcurso',
  templateUrl: './asignarcurso.component.html',
  styleUrls: ['./asignarcurso.component.css']
})
export class AsignarcursoComponent{
  loginbtn:boolean;
  logoutbtn:boolean;
  public usuario = JSON.parse(localStorage.getItem('usuario'));
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;
  //arreglo para almacenar datos de federados para listar
  federados=null;
  
  //arreglo que almacena los datos de asignaciones y cursos-asignados para listar
  asignaciones=null;
  //objeto que almacena los datos del instructor a cargo del curso seleccionado
  instructor={
    nombre:null,
    apellido:null,
    estado:null
  };
 //objeto que almacena los datos de la matricula a insertar
  matricula={
    id_asignacion_curso:null,
    id_federado:null
  }
  constructor(public authService: AuthService,public federadoServicio: FederadosService,
    public asignacionCursoService: AsignacionesCursosService,public matriculaService: MatriculasService) { 

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
  ngOnInit() {
     //metodo que consume el servicio de federados para listar los que estan de ALTA.
    this.federadoServicio.lista_de_alta().subscribe(result => this.federados = result);
  //metodo que consume el servicio asignacionCurso para obtener los datos de cursos que tengan... 
  //un instructor y esten en estado INICIADO
 this.asignacionCursoService.seleccionar_cursos_asignados_iniciados().subscribe(
  result1 => this.asignaciones = result1
  
  );  
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
   
 //metodo que consume el servicio de matriculas para agregar una nueva matricula
 alta() {
   
   console.log(this.matricula);

  if (confirm('¡ALERTA!\nEsta a punto de asignar a un federado en un curso.\nSi lo hace este federado no podrá ser eliminado ni removido del curso.\n¿Desea continuar?')) {

    this.matriculaService.alta(this.matricula).subscribe(datos => {
      if (datos['resultado'] == 'OK') {
      alert(datos['mensaje']);
     
      this.matricula={
        id_asignacion_curso:null,
        id_federado:null
      }
     
      }else{
        alert(datos['mensaje']);
      }
      });
   
  }
 }

}
