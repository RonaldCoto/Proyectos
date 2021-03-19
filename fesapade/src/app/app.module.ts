import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ToastrModule } from 'ngx-toastr';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LandingpageComponent } from './components/landingpage/landingpage.component';
import { CursosComponent } from './components/cursos/cursos.component';
import { GaleriaComponent } from './components/galeria/galeria.component';
import { LogInComponent} from './components/log-in/log-in.component';
import { AdministradorComponent } from './components/administrador/administrador.component'

@NgModule({
  declarations: [
    AppComponent,
    LandingpageComponent,
    CursosComponent,
    GaleriaComponent,
    LogInComponent,
    AdministradorComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
