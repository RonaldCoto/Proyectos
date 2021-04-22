import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ActualizarService {

  constructor() { }
  /* ----------------------ACTUALIZAR CURSOS-----------------*/
 // Funcion que almacena el id del curso 
 setCursoid(idcurso) {
  localStorage.setItem('Cursoid', idcurso);
 }
 //Funcion que retorna el id del curso
 getCursoid() {
  return localStorage.getItem('Cursoid');
  }
  
  //miArray: any[] = [];
 //getFromArray(token) {
   //  return this.miArray[this.miArray.findIndex(item => item.token === token)];
// }


/* ----------------------ACTUALIZAR EMPLEADOS-----------------*/



/* ----------------------ACTUALIZAR FEDERADOS-----------------*/

}
