import { Component, OnInit } from '@angular/core';
import { CursosService } from '../../services/cursos.service';
@Component({
  selector: 'app-crearcurso',
  templateUrl: './crearcurso.component.html',
  styleUrls: ['./crearcurso.component.css']
})
export class CrearcursoComponent implements OnInit {
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;
  
  //Arreglo que almacena los datos del curso para insterarlos en la bdd
  curs = {
    id: 0,
    nombre: null,
    descripcion: null,
   portada: null
  }
  constructor(private cursoServicio: CursosService) { }

  ngOnInit(): void {
  }
  //metodo que consume el servicio de cursos para agregar un nuevo curso
  alta() {
    this.cursoServicio.alta(this.curs).subscribe(datos => {
    if (datos['resultado'] == 'OK') {
    alert(datos['mensaje']);
    
    this.curs = {id: 0, descripcion: null, nombre: null, portada: null};
    }else{
      alert('¡Ha ocurrido un error!');
    }
    });
    }
}
