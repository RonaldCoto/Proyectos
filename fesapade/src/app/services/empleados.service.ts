import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class EmpleadosService {
  url = 'http://localhost/recursos/crud_empleados/';
  constructor(private http: HttpClient) { }
  //lista de todos los empleados
  listar() {
    return this.http.get(`${this.url}listar.php`);
  }
  //insertar nuevo empleado
  alta(empleado) {
    return this.http.post(`${this.url}alta.php`, JSON.stringify(empleado));
  }
  //eliminar un empleado
  baja(codigo: number) {
    return this.http.get(`${this.url}baja.php?codigo=${codigo}`);
  }
  //obtener todos los datos de un empleado
  seleccionar(codigo: number) {
    return this.http.get(`${this.url}seleccionar.php?codigo=${codigo}`);
  }
  //editar datos de un empleado
  modificacion(empleado) {
    return this.http.post(`${this.url}modificacion.php`, JSON.stringify(empleado));
  }
  //obtener todos los empleados que sean instructores y esten de alta 
  lista_de_alta() {
    return this.http.get(`${this.url}listar_dealta_inst.php?codigo`);
  }
  //obtener cursos de instructor segun su ID 
  lista_cursos(codigo: number) {
    return this.http.get(`${this.url}listar_cursos_instructor.php?codigo=${codigo}`);
  }

  //obtener cursos de instructor segun su ID para llenar select 
  lista_cursos_select(codigo: number) {
    return this.http.get(`${this.url}cursos_por_idinstructor.php?codigo=${codigo}`);
  }

  //insertar un nuevo publicacion
  agregar_publicacion(publicacion) {
    return this.http.post(`${this.url}insertar_publicacion.php`, JSON.stringify(publicacion));
  }

  //obtener cursos de instructor segun su ID para llenar select 
  lista_pubs_instructor(codigo: number) {
    return this.http.get(`${this.url}listar_publicaciones_instructor.php?codigo=${codigo}`);
  }

  // Funcion que almacena el id del curso seleccionado
  setSelectedIdPublicacion(idselected) {
    localStorage.setItem('SelectedIdPublicacion', idselected);
  }
}
