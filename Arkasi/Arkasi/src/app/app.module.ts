import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ArkassComponent } from './components/arkass/arkass.component';
import { PortfoliosComponent } from './components/portfolios/portfolios.component';

@NgModule({
  declarations: [
    AppComponent,
    ArkassComponent,
    PortfoliosComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
