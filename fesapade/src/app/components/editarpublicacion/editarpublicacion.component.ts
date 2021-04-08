import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-editarpublicacion',
  templateUrl: './editarpublicacion.component.html',
  styleUrls: ['./editarpublicacion.component.css']
})
export class EditarpublicacionComponent implements OnInit {
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;
  constructor() { }

  ngOnInit(): void {
  }

}
