import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { AboutComponent } from "./about/about.component";
import { AddChildComponent } from "./add-child/add-child.component";
import { AddTecherComponent } from "./add-techer/add-techer.component";
import { CalenderComponent } from "./calender/calender.component";
import { ChildListComponent } from "./child-list/child-list.component";
import { HomeComponent } from "./home/home.component";
import { LoginPageComponent } from "./login-page/login-page.component";
import { MenuComponent } from "./menu/menu.component";
import { MessagesComponent } from "./messages/messages.component";
import { NewsComponent } from "./news/news.component";
import { PageChildPlacementComponent } from "./page-child-placement/page-child-placement.component";
import { ParentsMessagesComponent } from "./parents-messages/parents-messages.component";
import { RecoverLostsListComponent } from "./recover-losts-list/recover-losts-list.component";
import { TeachersPlacementComponent } from "./teachers-placement/teachers-placement.component";
import { TecherAreaComponent } from "./techer-area/techer-area.component";

const routes: Routes = [
  { path: "", component: HomeComponent },
  { path: "about", component: AboutComponent },
  { path: "registerTeacher", component: AddTecherComponent },
  { path: "registerChild", component: AddChildComponent },
  { path: "calendar", component: CalenderComponent },
  { path: "news", component: NewsComponent },
  { path: "loginPage", component: LoginPageComponent },
  { path: "techerArea", component: TecherAreaComponent },
  { path: "teachersPlacement", component: TeachersPlacementComponent },

  { path: "parentsMessages", component: ParentsMessagesComponent },

  {
    path: "menuTeacher",
    component: TecherAreaComponent,

    children: [
      { path: "pageChildPlacement", component: PageChildPlacementComponent },
      { path: "teachersPlacement", component: TeachersPlacementComponent },
      // { path: "requestsTable/:statusId", component: RequestsTableComponent },
      { path: "childList", component: ChildListComponent },
      { path: "recover-losts", component: RecoverLostsListComponent },
      { path: "message", component: MessagesComponent },
      {
        path: "",
        outlet: "childList",
        component: ChildListComponent,
      },
      {
        path: "",
        redirectTo: "childList",
        pathMatch: "full",
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
