import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {LandingpageComponent} from '../app/components/landingpage/landingpage.component';
import {CursosComponent} from '../app/components/cursos/cursos.component';
import {GaleriaComponent} from '../app/components/galeria/galeria.component';
import {DashboardfederadoComponent} from '../app/components/dashboardfederado/dashboardfederado.component';
import {EditfederadoComponent} from '../app/components/editfederado/editfederado.component';
const routes: Routes = [
    //patmatch para que la ruta coincida completa
    { path: '', redirectTo: '/index', pathMatch: 'full' },
    { path: 'index', component: LandingpageComponent },
    {path: 'cursos', component:CursosComponent},
    {path: 'galeria', component:GaleriaComponent},
    {path: 'dashfederado', component:DashboardfederadoComponent},
    {path: 'editfede', component:EditfederadoComponent},
   
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {

 }
