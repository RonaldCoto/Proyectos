import { Component, OnInit } from '@angular/core';
import { EvaluacionesService } from 'src/app/services/evaluaciones.service';
import { ActualizarService } from 'src/app/services/actualizar.service';
import { AuthService } from "../../services/auth.service";
@Component({
  selector: 'app-administrarevaluaciones',
  templateUrl: './administrarevaluaciones.component.html',
  styleUrls: ['./administrarevaluaciones.component.css']
})
export class AdministrarevaluacionesComponent implements OnInit {
  loginbtn: boolean;
  logoutbtn: boolean;
  evaluaciones=null;
  public usuario = JSON.parse(localStorage.getItem('usuario'));
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;
  constructor(public authService: AuthService,public evaluacionesService: EvaluacionesService,
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
     
      //si hay un empleado seleccionado para editar
      if (this.usuario != null) {
         //invocando metodo para lista de evaluaciones
     
        this.ListarEvaluaciones();
        
      }
  
    }
    //metodo que consume el servicio de evaluaciones para listar.
  ListarEvaluaciones() {
   //se consume el servicio de evaluaciones, invocando el metodo que trae las evaluaciones... 
        //del instructor que se encuentra logueado
        let codempleado = this.usuario.id_emp;
        this.evaluacionesService.lista_evaluaciones_instructor(parseInt(codempleado)).subscribe(result => this.evaluaciones = result);
  
    }

    //metodo que consume el servicio de evaluaciones para eliminar una evaluacion seleccionada
    eliminar(codigo) {
      if (confirm('¡PELIGRO!\nEsta a punto de eliminar una evaluación.\nSi continua se eliminarán todas las notas asignadas.\n¿Desea continuar?')) {
      this.evaluacionesService.baja(codigo).subscribe(datos => {
      if (datos['resultado'] == 'OK') {
      alert(datos['mensaje']);
      this.ListarEvaluaciones();
      }else{
        alert('¡Ha ocurrido un error!');
      }
      });
      }
      }
  
      //metodo que invoca al servicio "actualizarService" donde se almacenan el id de la evaluacion seleccionada
      seleccionar(codigo) {
        this.actualizarService.setSelectedId(codigo);
      }

}
