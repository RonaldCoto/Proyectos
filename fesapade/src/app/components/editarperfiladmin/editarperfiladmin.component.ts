import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-editarperfiladmin',
  templateUrl: './editarperfiladmin.component.html',
  styleUrls: ['./editarperfiladmin.component.css']
})
export class EditarperfiladminComponent implements OnInit {
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;
  constructor() { }

  ngOnInit(): void {
  }

}
