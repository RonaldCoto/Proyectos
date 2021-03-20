import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LandingpageComponent } from './components/landingpage/landingpage.component';
import { CursosComponent } from './components/cursos/cursos.component';
import { GaleriaComponent } from './components/galeria/galeria.component';
import { DashboardfederadoComponent } from './components/dashboardfederado/dashboardfederado.component';
import { EditfederadoComponent } from './components/editfederado/editfederado.component';

@NgModule({
  declarations: [
    AppComponent,
    LandingpageComponent,
    CursosComponent,
    GaleriaComponent,
    DashboardfederadoComponent,
    EditfederadoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
