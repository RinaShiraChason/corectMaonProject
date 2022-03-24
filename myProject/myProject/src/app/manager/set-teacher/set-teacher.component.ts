import { Component, Inject, OnInit } from '@angular/core';

import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Classes } from 'src/app/classes/Classes';
import { User } from 'src/app/classes/Users';
import { ClassesService } from 'src/app/services/classes.service';
import { UserService } from 'src/app/services/user.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-set-teacher',
  templateUrl: './set-teacher.component.html',
  styleUrls: ['./set-teacher.component.scss']
})
export class SetTeacherComponent implements OnInit {
  classes: Classes[];
 
  setUserForm = this.fb.group({

    userName: this.fb.control('', [Validators.required]),
    userTz: this.fb.control('', [Validators.required]),
    address: this.fb.control('', [Validators.required]),
    email: this.fb.control('', [Validators.required]),
    phoneNamber1: this.fb.control('', [Validators.required]),
    phoneNamber2: this.fb.control('', [Validators.required]),
    password: this.fb.control('', [Validators.required]),
    userTypeId: this.fb.control('2'),
    classId: this.fb.control('', [Validators.required]),

  });
  constructor(private classServie: ClassesService,
    private userService: UserService,
    private fb: FormBuilder,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private dialogRef: MatDialogRef<SetTeacherComponent>
  ) { }
 
  ngOnInit(): void {
    this.classServie.getAllׁׂׂׂׂׂׂ().subscribe(x => {
      this.classes = x;

    });

    if (this.data && this.data.user) {
      this.setUserForm = this.fb.group(this.data.user);
  

    }
  
  }
  close() {
    if (this.dialogRef && this.dialogRef.close) {
      this.dialogRef.close({ data: 'Order' });
    }
  }


  setUser(): void {
    const p = <User>this.setUserForm.value;
    this.userService.addUpdateUser(p).subscribe(
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
