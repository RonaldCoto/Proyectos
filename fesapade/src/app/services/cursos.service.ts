import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CursosService {
  url='http://localhost/recursos/crud_cursos/'; 
  constructor(private http: HttpClient) { }
    listar() {
    return this.http.get(`${this.url}listar.php` );
    }
    alta(curso) {
    return this.http.post(`${this.url}alta.php`, JSON.stringify(curso));
    }
    baja(codigo:number) {
    return this.http.get(`${this.url}baja.php?codigo=${codigo}`);
    }
    seleccionar(codigo:number) {
    return this.http.get(`${this.url}seleccionar.php?codigo=${codigo}`);
    }
    modificacion(curso) {
      return this.http.post(`${this.url}modificacion.php`, JSON.stringify(curso));
      } 
}
