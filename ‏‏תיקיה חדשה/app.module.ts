import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms'
import { AppRoutingModule } from './app-routing.module'
import { AppComponent } from './app.component';
import { MDBBootstrapModule } from 'angular-bootstrap-md';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';


import { DaysPipe } from './days.pipe';
import { PipeDaysPipe } from './pipe-days.pipe';

@NgModule({
  declarations: [
    AppComponent,

    DaysPipe,
    PipeDaysPipe,

  ],

  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    BrowserAnimationsModule,
    MDBBootstrapModule.forRoot(),




  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
