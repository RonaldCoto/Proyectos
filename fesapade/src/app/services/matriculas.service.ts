import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class MatriculasService {
  url='http://localhost/recursos/crud_matriculas/'; 
  constructor(private http: HttpClient) { }
  
      //matricula de federado en curso seleccionado
    alta(matricula) {
    return this.http.post(`${this.url}alta.php`, JSON.stringify(matricula));
    }
   
}
