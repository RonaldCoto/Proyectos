import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {LandingpageComponent} from '../app/components/landingpage/landingpage.component'

const routes: Routes = [
    //patmatch para que la ruta coincida completa
    { path: '', redirectTo: '/index', pathMatch: 'full' },
    { path: 'index', component: LandingpageComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {

 }
