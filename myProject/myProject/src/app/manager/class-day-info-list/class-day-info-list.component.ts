import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Classes } from 'src/app/classes/Classes';
import { Kids } from 'src/app/classes/Kids';
import { KidsAttendance } from 'src/app/classes/KidsAttendance';
import { User } from 'src/app/classes/Users';
import { KidsDayHistoryModalComponent } from 'src/app/kids-day-history-modal/kids-day-history-modal.component';
import { ClassesService } from 'src/app/services/classes.service';
import { KidsService } from 'src/app/services/kid.service';
import { KidsAttendanceService } from 'src/app/services/kids-attendance.service';
import { SetKidDayCareComponent } from 'src/app/set-kid-day-care/set-kid-day-care.component';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-class-day-info-list',
  templateUrl: './class-day-info-list.component.html',
  styleUrls: ['./class-day-info-list.component.scss']
})
export class ClassDayInfoListComponent implements OnInit {
  childList: Kids[];
  today = new Date();
  classId = 0;
  classes: Classes[];
  user: User;
  constructor(
    private KidsSer: KidsService, private classServie: ClassesService,
    private kAttenService: KidsAttendanceService, private dialog: MatDialog
  ) { }

  ngOnInit(): void {
    this.user = <User>JSON.parse(localStorage.getItem('user'));
    this.classId = this.user.classId;


    this.classServie.getAllׁׂׂׂׂׂׂ().subscribe(x => {
      this.classes = x;
      this.classId = x[0].classId;
      this.getKids();
    });



  }
  sendEmailNoKidAttendence(){

    this.kAttenService.sendEmailNoKidAttendence(this.classId).subscribe((x) => {
      if (x) {
      
        Swal.fire("", "ההודעות נשלחו בהצלחה", "success");
      } else {
        Swal.fire("Ooooops", "שליחת ההודעות נכשלה, פנה למנהל המערכת", "error");
      }
    });
  }
  selectClass(classId) {
    this.classId = classId;
    this.getKids();
  }
  getKids() {
    this.KidsSer.GetTodayKidsData(this.classId).subscribe((data) => {
      {
        this.childList = data;
        console.log(data);
      }
      (err) => console.log(err);
    });
    console.log(this.childList);
  }

  openDialog(kid?: Kids) {
    const dialogRef = this.dialog.open(SetKidDayCareComponent, {
      data: { kid },
    });
    dialogRef.afterClosed().subscribe((result) => {
      console.log(`Dialog result: ${result}`);
    });
    dialogRef.afterClosed().subscribe((result) => {
      console.log('The dialog was closed');
      this.getKids();
    });
  }
  openHistoryModal(kidId: number) {
    const dialogRef = this.dialog.open(KidsDayHistoryModalComponent, {
      data: { kidId },
    });
    dialogRef.afterClosed().subscribe((result) => {
      console.log(`Dialog result: ${result}`);
    });
    dialogRef.afterClosed().subscribe((result) => {
      console.log('The dialog was closed');
     // this.getKids();
    });
  }
  
  CheckKid(kidId: number, isArrived: boolean) {
    let attendence: KidsAttendance = {
      attendanceId: 0,
      currentDate: new Date(),
      isArrived: isArrived,
      kidId: kidId,
      kid: null,
    };
    this.kAttenService.setKidAttendence(attendence).subscribe((x) => {
      if (x) {
        this.getKids();
        Swal.fire("", "השמירה בוצעה בהצלחה", "success");
      } else {
        Swal.fire("Ooooops", "השמירה נכשלה, פנה למנהל המערכת", "error");
      }
    });
  }
}
