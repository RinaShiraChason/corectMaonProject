
import { BrowserModule } from '@angular/platform-browser';
import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
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
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AddTecherComponent } from './add-techer/add-techer.component';
import { HomeComponent } from './home/home.component';
// // MDB Angular Pro
// import { TabsModule, WavesModule } from 'ng-uikit-pro-standard';
import { AddClassComponent } from './add-class/add-class.component';
import { PageChildPlacementComponent } from './page-child-placement/page-child-placement.component';
import { KidsService } from './services/kid.service';
import { MenuComponent } from './menu/menu.component';
import { MatButtonModule } from '@angular/material/button';
import { MatMenuModule } from '@angular/material/menu';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatInputModule } from '@angular/material/input';
import { MatIconModule } from '@angular/material/icon';
import { MatFormFieldModule} from '@angular/material/form-field';
import { MatProgressBarModule} from '@angular/material/progress-bar';
import { MatSelectModule} from '@angular/material/select';
import { MatCardModule} from '@angular/material/card';
import { MatDatepickerModule} from '@angular/material/datepicker';
import { MatRadioModule} from '@angular/material/radio';
import { MatTableModule} from '@angular/material/table';
import { MatPaginatorModule} from '@angular/material/paginator';
import { MatSortModule} from '@angular/material/sort';
import { MatGridListModule} from '@angular/material/grid-list';
import { MatProgressSpinnerModule} from '@angular/material/progress-spinner';
import { MatSnackBarModule} from '@angular/material/snack-bar';
import { MatSlideToggleModule} from '@angular/material/slide-toggle';
import { MessagesComponent } from './messages/messages.component';
import { RecoverLostsListComponent } from './recover-losts-list/recover-losts-list.component';
import { SetRecoverLostsComponent } from './set-recover-losts/set-recover-losts.component';
import { MAT_DATE_LOCALE } from '@angular/material/core';
import { MatDialogModule, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ImagesComponent } from './images/images.component';
import { ExternalDataComponent } from './external-data/external-data.component';
import { SetExternalDataComponent } from './set-external-data/set-external-data.component';
import { SetImagesComponent } from './set-images/set-images.component';
import { ActivityUpdateComponent } from './activity-update/activity-update.component';
import { DayCareComponent } from './day-care/day-care.component';
import { ManagerAreaComponent } from './manager/manager-area/manager-area.component';
import { TeacherListComponent } from './manager/teacher-list/teacher-list.component';
import { SetTeacherComponent } from './manager/set-teacher/set-teacher.component';
import { SetKidComponent } from './manager/set-kid/set-kid.component';
import { ClassesListComponent } from './manager/classes-list/classes-list.component';
import { TeacherPlacementListComponent } from './manager/teacher-placement-list/teacher-placement-list.component';
import { ClassDayInfoListComponent } from './manager/class-day-info-list/class-day-info-list.component';
import { SetClassComponent } from './manager/set-class/set-class.component';
import { SetKidDayCareComponent } from './set-kid-day-care/set-kid-day-care.component';
import { KidsDayHistoryModalComponent } from './kids-day-history-modal/kids-day-history-modal.component';
import { SetMessageComponent } from './set-message/set-message.component';
import { SetNewsComponent } from './manager/set-news/set-news.component';
import { ChildInfoComponent } from './child-info/child-info.component';



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
    PageChildPlacementComponent,
    MenuComponent,
    MessagesComponent,
    RecoverLostsListComponent,
    SetRecoverLostsComponent,
    ImagesComponent,
    ExternalDataComponent,
    SetExternalDataComponent,
    SetImagesComponent,
    ActivityUpdateComponent,
    DayCareComponent,
    ManagerAreaComponent,
    TeacherListComponent,
    SetTeacherComponent,
    SetKidComponent,
    ClassesListComponent,
    TeacherPlacementListComponent,
    ClassDayInfoListComponent,
    SetClassComponent,
    SetKidDayCareComponent,
    KidsDayHistoryModalComponent,
    SetMessageComponent,
    SetNewsComponent,
    ChildInfoComponent
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
    ReactiveFormsModule,
    MatButtonModule,
    MatMenuModule,
    MatToolbarModule,
    MatProgressBarModule,
    MatIconModule,
    MatCardModule,
    MatFormFieldModule,
    MatInputModule,
    MatDatepickerModule,
    MatRadioModule,
    MatSelectModule,
    MatSlideToggleModule,
    MatTableModule,
    MatPaginatorModule,
    MatSortModule,
    MatGridListModule,
    MatProgressSpinnerModule,
    MatSnackBarModule,

  ],
  schemas:[CUSTOM_ELEMENTS_SCHEMA],
 
  providers: [HttpClient,
    { provide: MAT_DIALOG_DATA, useValue: {} },
    { provide: MatDialogRef, useValue: {} },
    {  provide: MAT_DATE_LOCALE, useValue: 'he-IL'},],
  bootstrap: [AppComponent]
})
export class AppModule { }
