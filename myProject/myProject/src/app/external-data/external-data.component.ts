import { Component, OnInit } from '@angular/core';
import { ActivityUpdate } from '../classes/ActivityUpdate';
import { ActivityUpdateService } from '../services/activity-update.service';

@Component({
  selector: 'app-external-data',
  templateUrl: './external-data.component.html',
  styleUrls: ['./external-data.component.scss']
})
export class ExternalDataComponent implements OnInit {
  activityUpdate: ActivityUpdate;
  classId = 2;
  constructor(private auService: ActivityUpdateService) { }
  //GetTodayActivityUpdateByClass
  ngOnInit(): void {
    // this.auService.getTodayActivityUpdateByClass(this.classId).subscribe(x => {
    //   this.activityUpdate = x;
    // })
  }

}
