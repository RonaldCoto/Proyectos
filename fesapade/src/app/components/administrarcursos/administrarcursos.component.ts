import { Component, OnInit } from '@angular/core';
import { CursosService } from '../../services/cursos.service';
import { ActualizarService } from '../../services/actualizar.service';
import { AuthService } from "../../services/auth.service";
import { HttpClient, HttpResponse } from '@angular/common/http';
import { Router } from '@angular/router';
@Component({
  selector: 'app-administrarcursos',
  templateUrl: './administrarcursos.component.html',
  styleUrls: ['./administrarcursos.component.css']
})
export class AdministrarcursosComponent{
  loginbtn:boolean;
  logoutbtn:boolean;
  public usuario = JSON.parse(localStorage.getItem('usuario'));
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;

  //arreglo para almacenar cursos
  cursos = null;
  constructor(public authService: AuthService,private cursoServicio: CursosService,
    private router:Router,
    private actualizarService: ActualizarService) { 
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
   
    //invocando metodo para lista de cursos
    this.ListarCursos();
 
  }
//metodo que consume el servicio de cursos para listar.
  ListarCursos() {
    this.cursoServicio.listar().subscribe(result => this.cursos = result);
  
    }
//metodo que consume el servicio de cursos para eliminar un curso seleccionado
    eliminar(codigo) {
      if (confirm('¡PELIGRO!\nEsta a punto de eliminar un curso.\nSi continua se eliminarán todas las publicaciones, notas y evaluaciones realizadas.\n¿Desea continuar?')) {
      this.cursoServicio.baja(codigo).subscribe(datos => {
      if (datos['resultado'] == 'OK') {
      alert(datos['mensaje']);
      this.ListarCursos();
      }else{
        alert('¡Ha ocurrido un error!');
      }
      });
      }
      }
//metodo que invoca al servicio "actualizar" donde se almacenan los id 
      editar(codigo){
        
        this.actualizarService.setSelectedId(codigo);
       
      }
     
    
}
