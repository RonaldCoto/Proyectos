import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-administrarfederado',
  templateUrl: './administrarfederado.component.html',
  styleUrls: ['./administrarfederado.component.css']
})
export class AdministrarfederadoComponent implements OnInit {
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;
  constructor() { }

  ngOnInit(): void {
  }

}
