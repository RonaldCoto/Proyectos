import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CursosService {
  url='http://localhost/recursos/crud_cursos/'; 
  constructor(private http: HttpClient) { }
          //lista de todos los cursos
    listar() {
    return this.http.get(`${this.url}listar.php` );
    }
      //insertar un nuevo curso
    alta(curso) {
    return this.http.post(`${this.url}alta.php`, JSON.stringify(curso));
    }
    //eliminar un curso
    baja(codigo:number) {
    return this.http.get(`${this.url}baja.php?codigo=${codigo}`);
    }
    //obtener todos los datos de un curso
    seleccionar(codigo:number) {
    return this.http.get(`${this.url}seleccionar.php?codigo=${codigo}`);
    }
    //editar datos de un curso
    modificacion(curso) {
      return this.http.post(`${this.url}modificacion.php`, JSON.stringify(curso));
      } 
   
}
