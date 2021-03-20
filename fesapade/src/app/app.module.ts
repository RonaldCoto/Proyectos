//Modulos
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { ToastrModule } from 'ngx-toastr';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppRoutingModule } from './app-routing.module';
//Guardianes
import { AuthGuard } from "./guard/auth.guard";
import { Auth2Guard } from "./guard/auth2.guard";
import { Auth3Guard } from "./guard/auth3.guard";
import { Auth4Guard } from "./guard/auth4.guard";
//Componentes
import { AppComponent } from './app.component';
import { LandingpageComponent } from './components/landingpage/landingpage.component';
import { CursosComponent } from './components/cursos/cursos.component';
import { GaleriaComponent } from './components/galeria/galeria.component';
import { LogInComponent} from './components/log-in/log-in.component';
import { AdministradorComponent } from './components/administrador/administrador.component';
import { InstructorComponent } from './components/instructor/instructor.component';
import { FederadoComponent } from './components/federado/federado.component';




@NgModule({
  declarations: [
    AppComponent,
    LandingpageComponent,
    CursosComponent,
    GaleriaComponent,
    LogInComponent,
    AdministradorComponent,
    InstructorComponent,
    FederadoComponent,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ToastrModule.forRoot(),
    FormsModule,  HttpClientModule,
    BrowserAnimationsModule,ReactiveFormsModule,
  ],
  providers: [AuthGuard, Auth2Guard, Auth3Guard, Auth4Guard],
  bootstrap: [AppComponent]
})
export class AppModule { }
