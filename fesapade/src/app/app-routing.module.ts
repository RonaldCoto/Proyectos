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

//Guardianes
import { AuthGuard } from "./guard/auth.guard";
import { Auth2Guard } from "./guard/auth2.guard";
import { Auth3Guard } from "./guard/auth3.guard";
import { Auth4Guard } from "./guard/auth4.guard";
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
    {path: 'instructor', component:InstructorComponent},
    //{path: 'instructor', component:InstructorComponent,canActivate:[Auth2Guard]} cuando este el login
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {

 }
