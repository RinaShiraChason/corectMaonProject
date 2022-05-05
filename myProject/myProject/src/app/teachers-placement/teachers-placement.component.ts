import { Component, OnInit } from "@angular/core";
import { Classes } from "../classes/Classes";
import { PlacementOfATeacher } from "../classes/PlacementOfATeacher";
import { User } from "../classes/Users";
import { ClassesService } from "../services/classes.service";
import { PlacementOfATeacherService } from "../services/placement-of-ateacher.service";

@Component({
  selector: "app-teachers-placement",
  templateUrl: "./teachers-placement.component.html",
  styleUrls: ["./teachers-placement.component.scss"],
})
export class TeachersPlacementComponent implements OnInit {
  constructor(
    private placeOfService: PlacementOfATeacherService,
    private classService: ClassesService
  ) {}
  teacherDays: PlacementOfATeacher;
  classes: Classes[];
 
  ngOnInit(): void {
    var user = <User>JSON.parse(localStorage.getItem('user'));
    this.classService.getAllׁׂׂׂׂׂׂ().subscribe((x) => {
      this.classes = x;
      this.placeOfService.getByteacherId(user.userId).subscribe((x) => {
        this.teacherDays = x;

        this.teacherDays.dayInWeek1AStr = this.teacherDays.dayInWeek1A
          ? this.classes.find((x) => x.classId === this.teacherDays.dayInWeek1A)
              .className 
          : "-";
        this.teacherDays.dayInWeek2AStr = this.teacherDays.dayInWeek2A
          ? this.classes.find((x) => x.classId === this.teacherDays.dayInWeek2A)
              .className 
          : "-";
        this.teacherDays.dayInWeek3AStr = this.teacherDays.dayInWeek3A
          ? this.classes.find((x) => x.classId === this.teacherDays.dayInWeek3A)
              .className 
          : "-";
        this.teacherDays.dayInWeek4AStr = this.teacherDays.dayInWeek4A
          ? this.classes.find((x) => x.classId === this.teacherDays.dayInWeek4A)
              .className 
          : "-";
        this.teacherDays.dayInWeek5AStr = this.teacherDays.dayInWeek5A
          ? this.classes.find((x) => x.classId === this.teacherDays.dayInWeek5A)
              .className 
          : "-";

        this.teacherDays.dayInWeek1MStr = this.teacherDays.dayInWeek1M
          ? this.classes.find((x) => x.classId === this.teacherDays.dayInWeek1M)
              .className 
          : "-";
        this.teacherDays.dayInWeek2MStr = this.teacherDays.dayInWeek2M
          ? this.classes.find((x) => x.classId === this.teacherDays.dayInWeek2M)
              .className 
          : "-";
        this.teacherDays.dayInWeek3MStr = this.teacherDays.dayInWeek3M
          ? this.classes.find((x) => x.classId === this.teacherDays.dayInWeek3M)
              .className 
          : "-";
        this.teacherDays.dayInWeek4MStr = this.teacherDays.dayInWeek4M
          ? this.classes.find((x) => x.classId === this.teacherDays.dayInWeek4M)
              .className 
          : "-";
        this.teacherDays.dayInWeek5MStr = this.teacherDays.dayInWeek5M
          ? this.classes.find((x) => x.classId === this.teacherDays.dayInWeek5M)
              .className 
          : "-";
        this.teacherDays.dayInWeek6MStr = this.teacherDays.dayInWeek6M
          ? this.classes.find((x) => x.classId === this.teacherDays.dayInWeek6M)
              .className 
          : "-";
      });
    });
  }
}
