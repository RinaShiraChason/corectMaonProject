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
import { ChildAreaComponent } from "./child-area/child-area.component";
import { ImagesComponent } from "./images/images.component";
import { ExternalDataComponent } from "./external-data/external-data.component";
import { DayCareComponent } from "./day-care/day-care.component";
import { ActivityUpdateComponent } from "./activity-update/activity-update.component";
import { ManagerAreaComponent } from "./manager/manager-area/manager-area.component";
import { TeacherPlacementListComponent } from "./manager/teacher-placement-list/teacher-placement-list.component";
import { TeacherListComponent } from "./manager/teacher-list/teacher-list.component";
import { ClassesListComponent } from "./manager/classes-list/classes-list.component";
import { ClassDayInfoListComponent } from "./manager/class-day-info-list/class-day-info-list.component";



const routes: Routes = [

  { path: "about", component: AboutComponent },
  { path: "registerTeacher", component: AddTecherComponent },
  { path: "registerChild", component: AddChildComponent },
  { path: "calendar", component: CalenderComponent },
  { path: "news", component: NewsComponent },
  { path: "loginPage", component: LoginPageComponent },
  { path: "techerArea", component: TecherAreaComponent },
  { path: "childArea", component: ChildAreaComponent },
  { path: "childArea/:id", component: ChildAreaComponent },
  
  { path: "teachersPlacement", component: TeachersPlacementComponent },

  { path: "parentsMessages", component: ParentsMessagesComponent },
  { path: "", component: HomeComponent },
  {
    path: "menuTeacher",
    component: TecherAreaComponent,

    children: [
      { path: "pageChildPlacement", component: PageChildPlacementComponent },
      { path: "teachersPlacement", component: TeachersPlacementComponent },
      // { path: "requestsTable/:statusId", component: RequestsTableComponent },
      { path: "childList", component: ChildListComponent },
      { path: "recover-losts", component: RecoverLostsListComponent },

      { path: "externalData", component: ExternalDataComponent },
      { path: "dayCare", component: DayCareComponent },
      { path: "activityUpdate", component: ActivityUpdateComponent },

      { path: "images", component: ImagesComponent },
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
  }, {
    path: "menuManager",
    component: ManagerAreaComponent,

    children: [
      { path: "pageChildPlacement", component: PageChildPlacementComponent },
      { path: "teachersPlacement", component: TeacherPlacementListComponent },
      { path: "teachers", component: TeacherListComponent },
      { path: "classes", component: ClassesListComponent },
      // { path: "requestsTable/:statusId", component: RequestsTableComponent },
      { path: "childList", component: ChildListComponent },
      { path: "recover-losts", component: RecoverLostsListComponent },
      { path: "externalData", component: ExternalDataComponent },
      // { path: "dayCare", component: DayCareComponent },
      // { path: "activityUpdate", component: ActivityUpdateComponent },
      { path: "day", component: ClassDayInfoListComponent },
      { path: "images", component: ImagesComponent },
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
export class AppRoutingModule { }
