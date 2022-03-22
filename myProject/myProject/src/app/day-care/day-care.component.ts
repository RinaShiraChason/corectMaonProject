import { Component, OnInit } from '@angular/core';
import { Kids } from '../classes/Kids';
import { KidsService } from '../services/kid.service';

@Component({
  selector: 'app-day-care',
  templateUrl: './day-care.component.html',
  styleUrls: ['./day-care.component.scss']
})
export class DayCareComponent implements OnInit {

  childList: Kids[];
  today = new Date();
  constructor(
    private KidsSer: KidsService
  ) { }

  ngOnInit(): void {
    this.getKids();
  }
  getKids() {
    this.KidsSer.GetTodayKidsWithDayCare(1).subscribe((data) => {
      {

        this.childList = data;
        console.log(data);
      }
      (err) => console.log(err);
    });
    console.log(this.childList);
  }
  edit(kidId: number) {


  }
  // CheckKid(kidId: number, isArrived: boolean) {
  //   let attendence: KidsAttendance = {
  //     attendanceId : 0,
  //     currentDate : new Date(),
  //     isArrived : isArrived,
  //     kidId : kidId,
  //     kid : null,
  //   };
  //   this.kAttenService.setKidAttendence(attendence).subscribe((x) => {
  //     if (x) {
  //       this.getKids();
  //       Swal.fire("", "השמירה בוצעה בהצלחה", "success");
  //     } else {
  //       Swal.fire("Ooooops", "השמירה נכשלה, פנה למנהל המערכת", "error");
  //     }
  //   });
  // }
}
