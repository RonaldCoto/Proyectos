import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-instructor',
  templateUrl: './instructor.component.html',
  styleUrls: ['./instructor.component.css']
})
export class InstructorComponent implements OnInit {
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;
  constructor() { }

  ngOnInit(): void {
  }

}
