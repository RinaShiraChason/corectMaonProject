import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ActivityUpdate } from '../classes/ActivityUpdate';
import { ExternalData } from '../classes/ExternalData';
import { User } from '../classes/Users';
import { ActivityUpdateService } from '../services/activity-update.service';
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
  classId = 2;
  externalDataList: ExternalData[];
  constructor(private externalService: ExternalDataService, private dialog: MatDialog) { }
  //GetTodayActivityUpdateByClass
  ngOnInit(): void {
    this.user = <User>JSON.parse(localStorage.getItem('user'));
    this.userId = this.user.userId;
    // this.classId = this.user.classId;


    // this.auService.getTodayActivityUpdateByClass(this.classId).subscribe(x => {
    //   this.activityUpdate = x;
    // })    this.getAll();
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
  delete(id) { }

}
