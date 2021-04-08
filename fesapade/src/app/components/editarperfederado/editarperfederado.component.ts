import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-editarperfederado',
  templateUrl: './editarperfederado.component.html',
  styleUrls: ['./editarperfederado.component.css']
})
export class EditarperfederadoComponent implements OnInit {
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;
  constructor() { }

  ngOnInit(): void {
  }

}
