import { Component, OnInit } from '@angular/core';
import { Classes } from 'src/app/classes/Classes';
import { PlacementOfATeacher } from 'src/app/classes/PlacementOfATeacher';
import { User } from 'src/app/classes/Users';
import { ClassesService } from 'src/app/services/classes.service';
import { PlacementOfATeacherService } from 'src/app/services/placement-of-ateacher.service';
import { UserService } from 'src/app/services/user.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-teacher-placement-list',
  templateUrl: './teacher-placement-list.component.html',
  styleUrls: ['./teacher-placement-list.component.scss']
})
export class TeacherPlacementListComponent implements OnInit {
  constructor(
    private placeOfService: PlacementOfATeacherService,
    private classService: ClassesService,
    private userSer: UserService
  ) { }
  teacherDays: PlacementOfATeacher;
  classes: Classes[];
  teachersList: User[];
  teacherId = 0;
  ngOnInit(): void {
    this.userSer.getTeachers().subscribe(
      data => {
        {

          this.teachersList = data;
          this.teacherId = data[0].userId;
          this.classService.getAllׁׂׂׂׂׂׂ().subscribe((x) => {
            this.classes = x;
            this.getTeacherPlacement();

          });
        }
        err => console.log(err)

      })


  }
  selectTeacher(id){
    this.teacherId = id;
    this.getTeacherPlacement();
  }
  saveTeacherPlacement(){

    this.placeOfService.update(this.teacherDays ).subscribe((x) => {
      if(x){
        Swal.fire('','השמירה בוצעה בהצלחה!','success');
      }
      else{
        Swal.fire('Oooops','ארעה שגיאה','error');
   
      }
    });
    
  }
  getTeacherPlacement() {
    this.placeOfService.getByteacherId(this.teacherId).subscribe((x) => {
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
  }
}
