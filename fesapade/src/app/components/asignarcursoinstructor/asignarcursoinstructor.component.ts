import { Component, OnInit } from '@angular/core';
import { AuthService } from "../../services/auth.service";
import { ActualizarService } from '../../services/actualizar.service';
import { CursosService } from '../../services/cursos.service';
import { EmpleadosService } from '../../services/empleados.service';
import {AsignacionesCursosService} from '../../services/asignaciones-cursos.service';
import {ActivatedRoute} from '@angular/router'

@Component({
  selector: 'app-asignarcursoinstructor',
  templateUrl: './asignarcursoinstructor.component.html',
  styleUrls: ['./asignarcursoinstructor.component.css']
})
export class AsignarcursoinstructorComponent{
  loginbtn:boolean;
  logoutbtn:boolean;
  
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;
    //objeto que almacena los datos del curso para asignar
    curs={
      id_curso: 0,
     nombre: null,
     descripcion: null,
    portada: null,
    estado:null,
    id_empleado:null
     };
    //arreglo para almacenar empleados
  empleados=null;
  //variable de componente que recibe el id del curso para asignar desde la url
   //id_cursoSel=this.route.snapshot.paramMap.get('id');

  constructor(public authService: AuthService,public cursoServicio: CursosService,
    public actualizarService: ActualizarService,public empleadoServicio: EmpleadosService,
    public asignacionesCursosService:AsignacionesCursosService,private route:ActivatedRoute) { 
     
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
    let id_cursoSel = this.actualizarService.getSelectedId();
  
  //metodo que consume el servicio de empleados para listar.
  this.empleadoServicio.lista_de_alta().subscribe(result => this.empleados = result);
  this.cursoServicio.seleccionar(parseInt(id_cursoSel)).subscribe(
    result => this.curs = result[0]);
   
    this.actualizarService.deleteSelectedId();
     
       
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
    

     //metodo que consume el servicio de asignaciones_cursos para agregar una nueva asignacion
 alta() {
   
  if (confirm('¡ALERTA!\nEsta a punto de designar a un instructor en un curso.\nSi lo hace este instructor no podrá ser eliminado ni removido del curso.\n¿Desea continuar?')) {
   //solo se pueden inscribir cursos en estado INICIADO
    if(this.curs.estado == "INICIADO"){
    
    this.asignacionesCursosService.alta(this.curs).subscribe(datos => {
      if (datos['resultado'] == 'OK') {
      alert(datos['mensaje']);
      
      this.curs = { id_curso:0, descripcion: null, nombre: null, portada: null,estado:null,id_empleado:null};
      this.empleados = null;
      }else{
        alert(datos['mensaje']);
      }
      });
   }else{
     alert("Este curso ya ha finalizado.\nCambie su estado a 'INICIADO' para que sea asignable.");
   }
   
  }
 }
}
