import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-listafederado',
  templateUrl: './listafederado.component.html',
  styleUrls: ['./listafederado.component.css']
})
export class ListafederadoComponent implements OnInit {
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;
  constructor() { }

  ngOnInit(): void {
  }

}
