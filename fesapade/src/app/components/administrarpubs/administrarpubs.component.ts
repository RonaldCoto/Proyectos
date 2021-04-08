import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-administrarpubs',
  templateUrl: './administrarpubs.component.html',
  styleUrls: ['./administrarpubs.component.css']
})
export class AdministrarpubsComponent implements OnInit {
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;
  constructor() { }

  ngOnInit(): void {
  }

}
