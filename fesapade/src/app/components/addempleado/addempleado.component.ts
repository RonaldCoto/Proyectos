import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-addempleado',
  templateUrl: './addempleado.component.html',
  styleUrls: ['./addempleado.component.css']
})
export class AddempleadoComponent implements OnInit {
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;
  constructor() { }

  ngOnInit(): void {
  }

}
