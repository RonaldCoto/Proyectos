import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-admineditarcurso',
  templateUrl: './admineditarcurso.component.html',
  styleUrls: ['./admineditarcurso.component.css']
})
export class AdmineditarcursoComponent implements OnInit {
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;
  constructor() { }

  ngOnInit(): void {
  }

}
