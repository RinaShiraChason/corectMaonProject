import { Component, OnInit } from "@angular/core";
import Swal from "sweetalert2";

import { Kids } from "../classes/Kids";
import { KidsAttendance } from "../classes/KidsAttendance";
import { KidsService } from "../services/kid.service";
import { KidsAttendanceService } from "../services/kids-attendance.service";

@Component({
  selector: "app-page-child-placement",
  templateUrl: "./page-child-placement.component.html",
  styleUrls: ["./page-child-placement.component.scss"],
})
export class PageChildPlacementComponent implements OnInit {
  childList: Kids[];
  today = new Date();
  constructor(
    private KidsSer: KidsService,
    private kAttenService: KidsAttendanceService
  ) {}

  ngOnInit(): void {
    this.getKids();
  }
  getKids() {
    this.KidsSer.GetTodayKidsWithAttendenc(1).subscribe((data) => {
      {
      
        this.childList = data;
        console.log(data);
      }
      (err) => console.log(err);
    });
    console.log(this.childList);
  }
  CheckKid(kidId: number, isArrived: boolean) {
    let attendence: KidsAttendance = {
      AttendanceId: 0,
      CurrentDate: new Date(),
      IsArrived: isArrived,
      KidId: kidId,
      Kid: null,
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
