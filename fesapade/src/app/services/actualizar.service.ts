import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ActualizarService {

  constructor() { }
  /* ----------------------ACTUALIZAR CURSOS/EMPLEADOS/FEDERADOS-----------------*/
 // Funcion que almacena el id del campo seleccionado
 setSelectedId(idselected) {
  localStorage.setItem('SelectedId', idselected);
 }
 //Funcion que retorna el id del dal campo seleccionado
 getSelectedId() {
  return localStorage.getItem('SelectedId');
  }
  //eliminacion del id
  deleteSelectedId() {
    localStorage.removeItem('SelectedId');
   
    }
  
  //miArray: any[] = [];
 //getFromArray(token) {
   //  return this.miArray[this.miArray.findIndex(item => item.token === token)];
// }



}
