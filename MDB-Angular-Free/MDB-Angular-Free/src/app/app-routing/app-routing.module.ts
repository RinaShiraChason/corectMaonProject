import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {Router, RouterModule , Routes} from '@angular/router'
import {AddChildComponent} from '../add-child/add-child.component';
import {AboutComponent} from '../about/about.component';


const routes: Routes = [
  {path:'register',component:AddChildComponent},
  {path:'about' , component:AboutComponent}
]


@NgModule({
 
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
