import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-notasfederado',
  templateUrl: './notasfederado.component.html',
  styleUrls: ['./notasfederado.component.css']
})
export class NotasfederadoComponent implements OnInit {
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;
  constructor() { }

  ngOnInit(): void {
  }

}
