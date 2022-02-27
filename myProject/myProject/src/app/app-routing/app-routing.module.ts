import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {Router, RouterModule , Routes} from '@angular/router'
import {AddChildComponent} from '../add-child/add-child.component';
import {AboutComponent} from '../about/about.component';
import { AddTecherComponent } from '../add-techer/add-techer.component';


const routes: Routes = [
  {path:'registerChild',component:AddChildComponent},
  {path:'about' , component:AboutComponent},
  {path:'registerTeacher' , component:AddTecherComponent}

]


@NgModule({
 
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
