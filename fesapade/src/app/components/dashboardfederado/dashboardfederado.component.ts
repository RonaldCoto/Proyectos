import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-dashboardfederado',
  templateUrl: './dashboardfederado.component.html',
  styleUrls: ['./dashboardfederado.component.css']
})
export class DashboardfederadoComponent implements OnInit {
  //variable para mostrar u ocultar el sidebar
  contentHighlighted: boolean = false;
  constructor() { }

  ngOnInit(): void {
  }

}
