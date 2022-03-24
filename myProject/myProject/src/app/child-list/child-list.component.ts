import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Classes } from '../classes/Classes';
import { Kids } from '../classes/Kids';
import { User } from '../classes/Users';
import { SetKidComponent } from '../manager/set-kid/set-kid.component';
import { ClassesService } from '../services/classes.service';
import { KidsService } from '../services/kid.service';

@Component({
  selector: 'app-child-list',
  templateUrl: './child-list.component.html',
  styleUrls: ['./child-list.component.scss']
})
export class ChildListComponent implements OnInit {
  childList: Kids[];
  user: User;
  classId = 0;
  classes: Classes[];
  isManager = false;
  constructor(private KidsSer: KidsService, private classServie: ClassesService,
    private dialog:MatDialog) { }

  ngOnInit(): void {
    this.user = <User>JSON.parse(localStorage.getItem('user'));
    this.classId = this.user.classId;

    if (this.user.userTypeId === 3) {
      this.isManager = true;
      this.classServie.getAllׁׂׂׂׂׂׂ().subscribe(x => {
        this.classes = x;
        this.classId = x[0].classId;
        this.getChilds();
      });

    }
    else {
      this.getChilds();

    }


  }
  openDialog(kid? :Kids){
    const dialogRef = this.dialog.open(SetKidComponent, {
      data: { kid,classId:this.classId },
    });
    dialogRef.afterClosed().subscribe((result) => {
      console.log(`Dialog result: ${result}`);
    });
    dialogRef.afterClosed().subscribe((result) => {
      console.log('The dialog was closed');
      this.getChilds();
    });
  }
  delete(kidId){}
  getChilds(

  ) {
    this.KidsSer.getKidsByClass(this.classId).subscribe(

      data => {
        {
          debugger
          this.childList = data;
          console.log(data);
        }
        err => console.log(err)

      })
    // console.log(this.childList);
  }
  selectClass(classId) {
    this.classId = classId;
    this.getChilds();
  }
}
