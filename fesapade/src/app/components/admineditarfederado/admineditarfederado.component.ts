import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-admineditarfederado',
  templateUrl: './admineditarfederado.component.html',
  styleUrls: ['./admineditarfederado.component.css']
})
export class AdmineditarfederadoComponent implements OnInit {
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;
  constructor() { }

  ngOnInit(): void {
  }

}
