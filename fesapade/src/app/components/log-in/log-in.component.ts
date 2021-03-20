import { Component, OnInit } from '@angular/core';
import { AuthService } from "../../services/auth.service";
import { FormsModule, FormGroup, FormBuilder, Validators, NgForm } from '@angular/forms';
import { first } from 'rxjs/operators';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';

declare var ventana4:any;//para utilizar las funciones de javascript
@Component({
  selector: 'app-log-in',
  templateUrl: './log-in.component.html',
  styleUrls: ['./log-in.component.css']
})
export class LogInComponent implements OnInit {

  contacto: FormGroup;
  submitted = false;
    
  contacto2 = {
    idPersona: null,
    email: null,
    password: null
  }
  
  constructor(public authservice:AuthService,private formBuilder: FormBuilder, 
    private http:HttpClient, private router:Router) { }

  ngOnInit(): void {
    this.contacto = this.formBuilder.group({
         
            
      email: ['', [Validators.required, Validators.email]],
      password: ['', Validators.required]
      

  });
  }

  get f() { return this.contacto.controls; }
  IniciarSeccion() { //funcion de formulario iniciar seccion

      this.submitted = true;
      
      if (this.contacto.invalid) {
          return;
      }
      //alert('Mensaje Enviado !'+JSON.stringify(this.contacto.value))
    //  console.log('Mensaje Enviado !'+JSON.stringify(this.contacto.value))
        this.Iniciar_seccion(this.contacto);

  }
  ventana4(){

    this.ventana4();

}

  Iniciar_seccion(contacto){

    this.authservice.userlogin(contacto.value.email,contacto.value.password)
    .pipe(first())
    .subscribe(
    data => {
    const redirect = this.authservice.redirectUrl;
    this.router.navigate([redirect]);
    },
    error => {
    
    alert("Email o password incorrectos"); //ventana de mensaje cuando esta incorrectos los datos
    
    });
    }
 
}
