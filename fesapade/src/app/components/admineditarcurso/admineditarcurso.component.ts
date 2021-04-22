import { Component, OnInit } from '@angular/core';
import { CursosService } from '../../services/cursos.service';
import { ActualizarService } from '../../services/actualizar.service';
import { parse } from 'path';
@Component({
  selector: 'app-admineditarcurso',
  templateUrl: './admineditarcurso.component.html',
  styleUrls: ['./admineditarcurso.component.css']
})
export class AdmineditarcursoComponent implements OnInit {
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;

  
  //Arreglo que almacena los datos del curso para actualizarlos en la bdd
  curs = {
    id: 0,
    nombre: null,
    descripcion: null,
   portada: null
  }
  constructor(private cursoServicio: CursosService,private actualizarService: ActualizarService) { }

  ngOnInit(): void {
    //si hay un curso seleccionado para editar
    if(this.actualizarService.getCursoid()!=null)
  {
    //almacenamos el id del localstorage en una variable y mediante el servicio de cursos...
    //consultamos los datos del curso que coincida con el id, estos datos se almacenan en un arreglo...
    //que posteriormente se desplegará en el formulario para editar.
  let codCurso =  this.actualizarService.getCursoid();
  this.cursoServicio.seleccionar(parseInt(codCurso)).subscribe(result => this.curs = result[0]);
  }else{
    this.curs = {id: 0, descripcion: null, nombre: null, portada: null};
  }
  }
  //metodo que consume el servicio de cursos para modificar un curso segun el id seleccionado
  modificacion() {
    this.cursoServicio.modificacion(this.curs).subscribe(datos => {    
    if (datos['resultado'] == 'OK') {
    alert(datos['mensaje']);
    
    this.curs = {id: 0, descripcion: null, nombre: null, portada: null};
    }else{
      alert('¡Ha ocurrido un error!');
    }
    });
    }
}
