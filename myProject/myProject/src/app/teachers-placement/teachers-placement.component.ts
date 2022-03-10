import { Component, OnInit } from "@angular/core";
import { Classes } from "../classes/Classes";
import { PlacementOfATeacher } from "../classes/PlacementOfATeacher";
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
    this.classService.getAllׁׂׂׂׂׂׂ().subscribe((x) => {
      this.classes = x;
      this.placeOfService.getByTeacherId(2).subscribe((x) => {
        this.teacherDays = x;

        this.teacherDays.DayInWeek1AStr = this.teacherDays.DayInWeek1A
          ? this.classes.find((x) => x.ClassId === this.teacherDays.DayInWeek1A)
              .ClassName
          : "-";
        this.teacherDays.DayInWeek2AStr = this.teacherDays.DayInWeek2A
          ? this.classes.find((x) => x.ClassId === this.teacherDays.DayInWeek2A)
              .ClassName
          : "-";
        this.teacherDays.DayInWeek3AStr = this.teacherDays.DayInWeek3A
          ? this.classes.find((x) => x.ClassId === this.teacherDays.DayInWeek3A)
              .ClassName
          : "-";
        this.teacherDays.DayInWeek4AStr = this.teacherDays.DayInWeek4A
          ? this.classes.find((x) => x.ClassId === this.teacherDays.DayInWeek4A)
              .ClassName
          : "-";
        this.teacherDays.DayInWeek5AStr = this.teacherDays.DayInWeek5A
          ? this.classes.find((x) => x.ClassId === this.teacherDays.DayInWeek5A)
              .ClassName
          : "-";

        this.teacherDays.DayInWeek1MStr = this.teacherDays.DayInWeek1M
          ? this.classes.find((x) => x.ClassId === this.teacherDays.DayInWeek1M)
              .ClassName
          : "-";
        this.teacherDays.DayInWeek2MStr = this.teacherDays.DayInWeek2M
          ? this.classes.find((x) => x.ClassId === this.teacherDays.DayInWeek2M)
              .ClassName
          : "-";
        this.teacherDays.DayInWeek3MStr = this.teacherDays.DayInWeek3M
          ? this.classes.find((x) => x.ClassId === this.teacherDays.DayInWeek3M)
              .ClassName
          : "-";
        this.teacherDays.DayInWeek4MStr = this.teacherDays.DayInWeek4M
          ? this.classes.find((x) => x.ClassId === this.teacherDays.DayInWeek4M)
              .ClassName
          : "-";
        this.teacherDays.DayInWeek5MStr = this.teacherDays.DayInWeek5M
          ? this.classes.find((x) => x.ClassId === this.teacherDays.DayInWeek5M)
              .ClassName
          : "-";
        this.teacherDays.DayInWeek6MStr = this.teacherDays.DayInWeek6M
          ? this.classes.find((x) => x.ClassId === this.teacherDays.DayInWeek6M)
              .ClassName
          : "-";
      });
    });
  }
}
