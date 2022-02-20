import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { AddChildComponent } from './add-child/add-child.component';

const routes: Routes = [
{path:"about",component:AboutComponent},
{path:"register",component:AddChildComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
