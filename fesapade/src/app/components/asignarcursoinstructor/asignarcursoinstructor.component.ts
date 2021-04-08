import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-asignarcursoinstructor',
  templateUrl: './asignarcursoinstructor.component.html',
  styleUrls: ['./asignarcursoinstructor.component.css']
})
export class AsignarcursoinstructorComponent implements OnInit {
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;
  constructor() { }

  ngOnInit(): void {
  }

}
