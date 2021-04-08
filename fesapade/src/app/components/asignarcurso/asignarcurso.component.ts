import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-asignarcurso',
  templateUrl: './asignarcurso.component.html',
  styleUrls: ['./asignarcurso.component.css']
})
export class AsignarcursoComponent implements OnInit {
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;
  constructor() { }

  ngOnInit(): void {
  }

}
