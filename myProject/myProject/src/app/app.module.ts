
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppComponent } from './app.component';
import { MDBBootstrapModule } from 'angular-bootstrap-md';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HomePageComponent } from './home-page/home-page.component';
import { LoginPageComponent } from './login-page/login-page.component';
import { ManagerNavComponent } from './manager-nav/manager-nav.component';
import { ChildAreaComponent } from './child-area/child-area.component';
import { TecherAreaComponent } from './techer-area/techer-area.component';
import { TeachersPlacementComponent } from './teachers-placement/teachers-placement.component';
import { KidsAttendanceComponent } from './kids-attendance/kids-attendance.component';
import { ParentsMessagesComponent } from './parents-messages/parents-messages.component';
import { UpdateChildAreaComponent } from './update-child-area/update-child-area.component';
import { NewsComponent } from './news/news.component';
import { GeneralMessagesComponent } from './general-messages/general-messages.component';
import { DayUpdateComponent } from './day-update/day-update.component';
import { WeekUpdateComponent } from './week-update/week-update.component';
import { LossComponent } from './loss/loss.component';
import { AboutComponent } from './about/about.component';
import { CalenderComponent } from './calender/calender.component';
import { ChildNavComponent } from './child-nav/child-nav.component';
import { TeacherNavComponent } from './teacher-nav/teacher-nav.component';
import { AddChildComponent } from './add-child/add-child.component';
import { ChildListComponent } from './child-list/child-list.component';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AddTecherComponent } from './add-techer/add-techer.component';
import { HomeComponent } from './home/home.component';
// // MDB Angular Pro
// import { TabsModule, WavesModule } from 'ng-uikit-pro-standard';
import { AddClassComponent } from './add-class/add-class.component';
import { PageChildPlacementComponent } from './page-child-placement/page-child-placement.component';

@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    LoginPageComponent,
    ManagerNavComponent,
    ChildAreaComponent,
    TecherAreaComponent,
    TeachersPlacementComponent,
    KidsAttendanceComponent,
    ParentsMessagesComponent,
    UpdateChildAreaComponent,
    NewsComponent,
    GeneralMessagesComponent,
    DayUpdateComponent,
    WeekUpdateComponent,
    LossComponent,
    AboutComponent,
    CalenderComponent,
    ChildNavComponent,
    TeacherNavComponent,
    AddChildComponent,
    ChildListComponent,
    AddTecherComponent,
    AddClassComponent,
    HomeComponent,
    PageChildPlacementComponent
    //AddChildComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MDBBootstrapModule.forRoot(),
    FormsModule,
   HttpClientModule,
   AppRoutingModule,
   FormsModule,
   ReactiveFormsModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
