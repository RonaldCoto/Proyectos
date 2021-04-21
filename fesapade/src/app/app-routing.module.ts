//Modulos
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

//Componentes
import {LandingpageComponent} from '../app/components/landingpage/landingpage.component';
import {CursosComponent} from '../app/components/cursos/cursos.component';
import {GaleriaComponent} from '../app/components/galeria/galeria.component';
import {DashboardfederadoComponent} from '../app/components/dashboardfederado/dashboardfederado.component';
import {EditfederadoComponent} from '../app/components/editfederado/editfederado.component';
import { LogInComponent} from '../app/components/log-in/log-in.component';
import { AdministradorComponent } from '../app/components/administrador/administrador.component';
import { InstructorComponent } from '../app/components/instructor/instructor.component';
import {AddpublicacionComponent} from '../app/components/addpublicacion/addpublicacion.component';
import {AdministrarpubsComponent} from '../app/components/administrarpubs/administrarpubs.component';
import{EditarpublicacionComponent} from '../app/components/editarpublicacion/editarpublicacion.component';
import {ListafederadoComponent} from '../app/components/listafederado/listafederado.component';
import {EditarperfilComponent} from '../app/components/editarperfil/editarperfil.component';
import {NotasfederadoComponent} from '../app/components/notasfederado/notasfederado.component';
import {EditarperfederadoComponent} from '../app/components/editarperfederado/editarperfederado.component';
import {AddempleadoComponent} from '../app/components/addempleado/addempleado.component';
import {AddfederadoComponent} from '../app/components/addfederado/addfederado.component';
import {AdministrarfederadoComponent} from '../app/components/administrarfederado/administrarfederado.component';
import {CrearcursoComponent} from '../app/components/crearcurso/crearcurso.component';
import {AdministrarcursosComponent} from '../app/components/administrarcursos/administrarcursos.component';
import {EditarperfiladminComponent} from '../app/components/editarperfiladmin/editarperfiladmin.component';
import {AsignarcursoComponent} from '../app/components/asignarcurso/asignarcurso.component';
import {AdmineditarempleadoComponent} from '../app/components/admineditarempleado/admineditarempleado.component';
import {AdmineditarfederadoComponent} from '../app/components/admineditarfederado/admineditarfederado.component';
import {AdmineditarcursoComponent} from '../app/components/admineditarcurso/admineditarcurso.component';
import {AsignarcursoinstructorComponent} from '../app/components/asignarcursoinstructor/asignarcursoinstructor.component';
//Guardianes 
import { AuthGuard } from "./guard/auth.guard";
import { Auth2Guard } from "./guard/auth2.guard";
import { Auth3Guard } from "./guard/auth3.guard";
import { Auth4Guard } from "./guard/auth4.guard";
import { from } from 'rxjs';
const routes: Routes = [
    //patmatch para que la ruta coincida completa
    { path: '', redirectTo: '/index', pathMatch: 'full' },
    { path: 'index', component: LandingpageComponent },
    {path: 'cursos', component:CursosComponent},
    {path: 'galeria', component:GaleriaComponent},
    {path: 'dashfederado', component:DashboardfederadoComponent,canActivate:[Auth3Guard]},
    {path: 'editfede', component:EditfederadoComponent},
    {path: 'cursos', component:CursosComponent, },
    {path: 'galeria', component:GaleriaComponent},
    {path: 'login', component:LogInComponent,canActivate:[Auth4Guard]},
    {path: 'administrador', component:AdministradorComponent,canActivate:[AuthGuard]},
    {path: 'instructor', component:InstructorComponent,canActivate:[Auth2Guard]},
    {path: 'add-publicacion', component:AddpublicacionComponent},
    {path: 'admin-publicacion', component:AdministrarpubsComponent},
    {path: 'edit-publicacion', component:EditarpublicacionComponent},
    {path: 'list-federados', component:ListafederadoComponent},
    {path: 'edit-perfil', component:EditarperfilComponent},
    {path: 'notas-federado', component:NotasfederadoComponent},
    {path: 'edit-perfil-federado', component:EditarperfederadoComponent},
    {path: 'add-empleado', component:AddempleadoComponent},
    {path: 'add-federado', component:AddfederadoComponent},
    {path: 'admin-federado', component:AdministrarfederadoComponent},
    {path: 'crear-curso', component:CrearcursoComponent},
    {path: 'admin-curso', component:AdministrarcursosComponent},
    {path: 'edit-perfil-admin', component:EditarperfiladminComponent},
    {path: 'asign-curso-federado', component:AsignarcursoComponent},
    {path: 'admin-editar-empleado', component:AdmineditarempleadoComponent},
    {path: 'admin-editar-federado', component:AdmineditarfederadoComponent},
    {path: 'admin-editar-curso', component:AdmineditarcursoComponent},
    {path: 'asignar-curso-instructor', component:AsignarcursoinstructorComponent},
    //{path: 'instructor', component:InstructorComponent,canActivate:[Auth2Guard]} cuando este el login
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {

 }
