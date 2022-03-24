import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Classes } from 'src/app/classes/Classes';
import { Kids } from 'src/app/classes/Kids';
import { User } from 'src/app/classes/Users';
import { ClassesService } from 'src/app/services/classes.service';
import { UserService } from 'src/app/services/user.service';
import { SetTeacherComponent } from '../set-teacher/set-teacher.component';

@Component({
  selector: 'app-teacher-list',
  templateUrl: './teacher-list.component.html',
  styleUrls: ['./teacher-list.component.scss']
})
export class TeacherListComponent implements OnInit {

  teachersList: User[];
  user: User;
  classId = 0;
  classes: Classes[];
  constructor(private userSer: UserService, private classServie: ClassesService,
    private dialog: MatDialog) { }

  ngOnInit(): void {
    this.user = <User>JSON.parse(localStorage.getItem('user'));


    this.classServie.getAllׁׂׂׂׂׂׂ().subscribe(x => {
      this.classes = x;

      ;
    });

    this.getTeachers()



  }
  openDialog(user?: User) {
    const dialogRef = this.dialog.open(SetTeacherComponent, {
      data: { user },
    });
    dialogRef.afterClosed().subscribe((result) => {
      console.log(`Dialog result: ${result}`);
    });
    dialogRef.afterClosed().subscribe((result) => {
      console.log('The dialog was closed');
      this.getTeachers();
    });
  }
  delete(kidId) { }
  getTeachers() {
    this.userSer.getTeachers().subscribe(
      data => {
        {
         
          this.teachersList = data;
          console.log(data);
        }
        err => console.log(err)

      })
    // console.log(this.childList);
  }
  // selectClass(classId) {
  //   this.classId = classId;
  //   this.getTeachers();
  // }
}
