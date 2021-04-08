import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-admineditarempleado',
  templateUrl: './admineditarempleado.component.html',
  styleUrls: ['./admineditarempleado.component.css']
})
export class AdmineditarempleadoComponent implements OnInit {
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;
  constructor() { }

  ngOnInit(): void {
  }

}
