import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-addpublicacion',
  templateUrl: './addpublicacion.component.html',
  styleUrls: ['./addpublicacion.component.css']
})
export class AddpublicacionComponent implements OnInit {
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;
  constructor() { }

  ngOnInit(): void {
  }

}
