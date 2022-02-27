import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { AddChildComponent } from './add-child/add-child.component';
import { AddTecherComponent } from './add-techer/add-techer.component';
import { CalenderComponent } from './calender/calender.component';
import { ChildListComponent } from './child-list/child-list.component';
import { HomeComponent } from './home/home.component';
import { LoginPageComponent } from './login-page/login-page.component';
import { NewsComponent } from './news/news.component';
import { PageChildPlacementComponent } from './page-child-placement/page-child-placement.component';
import { ParentsMessagesComponent } from './parents-messages/parents-messages.component';
import { TeachersPlacementComponent } from './teachers-placement/teachers-placement.component';
import { TecherAreaComponent } from './techer-area/techer-area.component';

const routes: Routes = [
{path:"",component:HomeComponent},
{path:"about",component:AboutComponent},
{path:'registerTeacher' , component:AddTecherComponent},
{path:'registerChild',component:AddChildComponent},
{path:'calendar',component:CalenderComponent},
{path:'news',component:NewsComponent},
{path:'loginPage',component:LoginPageComponent},
{path:'techerArea',component:TecherAreaComponent},
{path:'teachersPlacement',component:TeachersPlacementComponent},
{path:'pageChildPlacement',component:PageChildPlacementComponent},
{path:'parentsMessages',component:ParentsMessagesComponent},
{path:'childList',component:ChildListComponent},







];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
