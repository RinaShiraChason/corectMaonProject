import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Classes } from 'src/app/classes/Classes';
import { Kids } from 'src/app/classes/Kids';
import { User } from 'src/app/classes/Users';
import { ClassesService } from 'src/app/services/classes.service';
import { UserService } from 'src/app/services/user.service';
import { SetClassComponent } from '../set-class/set-class.component';
import { SetTeacherComponent } from '../set-teacher/set-teacher.component';
@Component({
  selector: 'app-classes-list',
  templateUrl: './classes-list.component.html',
  styleUrls: ['./classes-list.component.scss']
})
export class ClassesListComponent implements OnInit {
  user: User;
  classes: Classes[];
  constructor(private cService: ClassesService, private classServie: ClassesService,
    private dialog: MatDialog) { }

  ngOnInit(): void {
    this.user = <User>JSON.parse(localStorage.getItem('user'));
    this.getClasses();
  }
  openDialog(classes?: Classes) {
    const dialogRef = this.dialog.open(SetClassComponent, {
      data: { classes },
    });
    dialogRef.afterClosed().subscribe((result) => {
      console.log(`Dialog result: ${result}`);
    });
    dialogRef.afterClosed().subscribe((result) => {
      console.log('The dialog was closed');
      this.getClasses();
    });
  }
  delete(kidId) { }
  getClasses() {
    this.classServie.getAllׁׂׂׂׂׂׂ().subscribe(x => {
      this.classes = x;
    });
  }

}