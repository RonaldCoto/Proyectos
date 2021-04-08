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
import { DashboardfederadoComponent } from './components/dashboardfederado/dashboardfederado.component';
import { EditfederadoComponent } from './components/editfederado/editfederado.component';
import { LogInComponent} from './components/log-in/log-in.component';
import { AdministradorComponent } from './components/administrador/administrador.component';
import { InstructorComponent } from './components/instructor/instructor.component';
import { AddpublicacionComponent } from './components/addpublicacion/addpublicacion.component';
import { AdministrarpubsComponent } from './components/administrarpubs/administrarpubs.component';
import { EditarpublicacionComponent } from './components/editarpublicacion/editarpublicacion.component';
import { ListafederadoComponent } from './components/listafederado/listafederado.component';
import { EditarperfilComponent } from './components/editarperfil/editarperfil.component';
import { NotasfederadoComponent } from './components/notasfederado/notasfederado.component';
import { EditarperfederadoComponent } from './components/editarperfederado/editarperfederado.component';
import { AddempleadoComponent } from './components/addempleado/addempleado.component';
import { AddfederadoComponent } from './components/addfederado/addfederado.component';
import { CrearcursoComponent } from './components/crearcurso/crearcurso.component';
import { AsignarcursoComponent } from './components/asignarcurso/asignarcurso.component';
import { EditarperfiladminComponent } from './components/editarperfiladmin/editarperfiladmin.component';
import { AdministrarfederadoComponent } from './components/administrarfederado/administrarfederado.component';
import { AdministrarcursosComponent } from './components/administrarcursos/administrarcursos.component';
import { AdmineditarempleadoComponent } from './components/admineditarempleado/admineditarempleado.component';
import { AdmineditarfederadoComponent } from './components/admineditarfederado/admineditarfederado.component';
import { AdmineditarcursoComponent } from './components/admineditarcurso/admineditarcurso.component';
import { AsignarcursoinstructorComponent } from './components/asignarcursoinstructor/asignarcursoinstructor.component';





@NgModule({
  declarations: [
    AppComponent,
    LandingpageComponent,
    CursosComponent,
    GaleriaComponent,
    DashboardfederadoComponent,
    EditfederadoComponent,
    LogInComponent,
    AdministradorComponent,
    InstructorComponent,
    AddpublicacionComponent,
    AdministrarpubsComponent,
    EditarpublicacionComponent,
    ListafederadoComponent,
    EditarperfilComponent,
    NotasfederadoComponent,
    EditarperfederadoComponent,
    AddempleadoComponent,
    AddfederadoComponent,
    CrearcursoComponent,
    AsignarcursoComponent,
    EditarperfiladminComponent,
    AdministrarfederadoComponent,
    AdministrarcursosComponent,
    AdmineditarempleadoComponent,
    AdmineditarfederadoComponent,
    AdmineditarcursoComponent,
    AsignarcursoinstructorComponent,
    
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
