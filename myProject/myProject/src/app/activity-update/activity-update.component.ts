import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ActivityUpdate } from '../classes/ActivityUpdate';
import { ActivityUpdateService } from '../services/activity-update.service';

@Component({
  selector: 'app-activity-update',
  templateUrl: './activity-update.component.html',
  styleUrls: ['./activity-update.component.scss']
})
export class ActivityUpdateComponent implements OnInit {


  activityUpdate: ActivityUpdate;
  classId = 2;
  userId = 5;
  setActivityUpdateForm = this.fb.group({
    dailyActivitySubject: this.fb.control('', [Validators.required]),
    dailyActivityInfo: this.fb.control('', [Validators.required]),

    idActivityUpdate: this.fb.control(null),
    dailyActivityDate: this.fb.control(null),
    classId: this.fb.control(null),
  });
  constructor(private fb: FormBuilder, private auService: ActivityUpdateService) { }
  //GetTodayActivityUpdateByClass
  SetActivityUpdate(){}
  ngOnInit(): void {

    this.activityUpdate = { teacherId: this.userId, classId: this.classId, dailyActivityDate: new Date(), dailyActivityInfo: '', dailyActivitySubject: '', idActivityUpdate: 0, class: null, userTeacher: null };
    this.auService.getTodayActivityUpdateByClass(this.classId).subscribe(x => {
      if (x) {

        this.activityUpdate = x;
        this.setActivityUpdateForm = this.fb.group(x);

      }

    })
  }

}