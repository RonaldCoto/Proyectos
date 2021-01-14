import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ArkassComponent } from '../app/components/arkass/arkass.component'

const routes: Routes = [
  //patmatch para que la ruta coincida completa
  { path: '', redirectTo: '/index', pathMatch: 'full' },
  { path: 'index', component: ArkassComponent },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
