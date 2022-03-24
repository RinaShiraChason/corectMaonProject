
import { Component, Inject, OnInit } from '@angular/core';

import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Classes } from 'src/app/classes/Classes';
import { Kids } from 'src/app/classes/Kids';
import { User } from 'src/app/classes/Users';
import { ClassesService } from 'src/app/services/classes.service';
import { KidsService } from 'src/app/services/kid.service';
import { UserService } from 'src/app/services/user.service';
import Swal from 'sweetalert2';
import { DayCare } from '../classes/DayCare';
import { DayCareService } from '../services/day-care.service';
@Component({
  selector: 'app-set-kid-day-care',
  templateUrl: './set-kid-day-care.component.html',
  styleUrls: ['./set-kid-day-care.component.scss']
})
export class SetKidDayCareComponent implements OnInit {

  kid: Kids;
  today = new Date();
  setKidForm = this.fb.group({
    behaviorDayCare: this.fb.control('', [Validators.required]),
    dressDayCare: this.fb.control('', [Validators.required]),
    commentDayCare: this.fb.control('', [Validators.required]),
    sleepDayCare: this.fb.control('', [Validators.required]),
    foodDayCare: this.fb.control('', [Validators.required]),

    dateCare: this.fb.control(new Date(this.today.getFullYear(), this.today.getMonth(), this.today.getDate(), 3, 0, 0).toISOString().split('T')[0], [Validators.required]),
    idDayCare: this.fb.control('0'),
    kidId: this.fb.control(null),


  });
  constructor(private classServie: ClassesService,
    private dayCareService: DayCareService,
    private userService: UserService,
    private fb: FormBuilder,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private dialogRef: MatDialogRef<SetKidDayCareComponent>
  ) { }

  ngOnInit(): void {

    if (this.data && this.data.kid &&
      this.data.kid.dayCare && this.data.kid.dayCare.length > 0) {

      this.setKidForm = this.fb.group(this.data.kid.dayCare[0]);
      var today = new Date(this.data.kid.dayCare[0].dateCare);
      var myToday = new Date(today.getFullYear(), today.getMonth(), today.getDate(), 3, 0, 0);
      this.setKidForm.patchValue({
        'dateCare':
          new Date(myToday).toISOString().split('T')[0]
      });




    }
    else {
      this.setKidForm.patchValue({ 'classId': this.data.classId });
    }
  }
  close() {
    if (this.dialogRef && this.dialogRef.close) {
      this.dialogRef.close({ data: 'Order' });
    }
  }


  setKid(): void {
    const p = <DayCare>this.setKidForm.value;
    p.kid = null;
    p.kidId = this.data.kid.kidId;

    var today = new Date(p.dateCare);
    var myToday = new Date(today.getFullYear(), today.getMonth(), today.getDate(), 3, 0, 0);
    p.dateCare = myToday;

    this.dayCareService.addUpdateKidCare(p).subscribe(
      (response) => {
        Swal.fire('', 'השמירה בוצעה בהצלחה', 'success');
        this.close();

      },
      (error) => {
        console.log(error);
      }
    );
  }
}

