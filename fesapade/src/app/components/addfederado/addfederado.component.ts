import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-addfederado',
  templateUrl: './addfederado.component.html',
  styleUrls: ['./addfederado.component.css']
})
export class AddfederadoComponent implements OnInit {
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;
  constructor() { }

  ngOnInit(): void {
  }

}
