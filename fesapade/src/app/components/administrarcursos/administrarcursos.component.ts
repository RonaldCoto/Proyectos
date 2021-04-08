import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-administrarcursos',
  templateUrl: './administrarcursos.component.html',
  styleUrls: ['./administrarcursos.component.css']
})
export class AdministrarcursosComponent implements OnInit {
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;
  constructor() { }

  ngOnInit(): void {
  }

}
