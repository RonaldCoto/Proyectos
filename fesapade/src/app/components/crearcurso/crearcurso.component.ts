import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-crearcurso',
  templateUrl: './crearcurso.component.html',
  styleUrls: ['./crearcurso.component.css']
})
export class CrearcursoComponent implements OnInit {
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;
  constructor() { }

  ngOnInit(): void {
  }

}
