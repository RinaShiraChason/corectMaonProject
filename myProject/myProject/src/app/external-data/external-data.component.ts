import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import Swal from 'sweetalert2';
import { ActivityUpdate } from '../classes/ActivityUpdate';
import { Classes } from '../classes/Classes';
import { ExternalData } from '../classes/ExternalData';
import { User } from '../classes/Users';
import { ActivityUpdateService } from '../services/activity-update.service';
import { ClassesService } from '../services/classes.service';
import { ExternalDataService } from '../services/extenral-data.service';
import { SetExternalDataComponent } from '../set-external-data/set-external-data.component';

@Component({
  selector: 'app-external-data',
  templateUrl: './external-data.component.html',
  styleUrls: ['./external-data.component.scss']
})
export class ExternalDataComponent implements OnInit {
  userId = 0;
  user: User;
  classId = 0;
  isManager = false;
  externalDataList: ExternalData[];
  classes:Classes[];
  constructor(private externalService: ExternalDataService, private dialog: MatDialog,private classServie:ClassesService) { }
  //GetTodayActivityUpdateByClass
  ngOnInit(): void {
    this.user = <User>JSON.parse(localStorage.getItem('user'));
    this.userId = this.user.userId;
    this.classId = this.user.classId;

    if (this.user.userTypeId === 3) {
      this.isManager = true;
      this.classServie.getAllׁׂׂׂׂׂׂ().subscribe(x => {
        this.classes = x;
        this.classId = x[0].classId;
        this.getAll();
      });

    }
    else {
      this.getAll();

    }
  }
  selectClass(classId) {
    this.classId = classId;
    this.getAll();
  }
  openDialog(ext?: ExternalData) {
    const dialogRef = this.dialog.open(SetExternalDataComponent, {
      data: { ext, classId: this.classId, teacherId: this.user.userId },
    });
    dialogRef.afterClosed().subscribe((result) => {
      console.log(`Dialog result: ${result}`);
    });
    dialogRef.afterClosed().subscribe((result) => {
      console.log('The dialog was closed');
      this.getAll();
    });
  }
  getAll() {
    this.externalService.GetAllByclassId(this.classId).subscribe(x => {
      this.externalDataList = x;
    })

  }
  delete(id) {
    Swal.fire({
      title: 'האם את/ה בטוח/ה?',
      text: "האם את/ה בטוח/ה שאת/ה רוצה למחוק את הרשומה הנוכחית?",
      icon: 'warning',
      showCancelButton: true,
      confirmButtonColor: '#3085d6',
      cancelButtonColor: '#d33',

      confirmButtonText: 'כן',
      cancelButtonText: 'לא',
    }).then((result) => {
      if (result.isConfirmed) {
        this.externalService.delete(id).subscribe((x) => {
          this.getAll();
        });
      }
    });
  }

}
