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
@Component({
  selector: 'app-set-kid',
  templateUrl: './set-kid.component.html',
  styleUrls: ['./set-kid.component.scss']
})
export class SetKidComponent implements OnInit {
  classes: Classes[];
  http: any;
  Image: File;
  imageUrl: string;
  fileToUpload: File[];
  componentId: string;
  kid: Kids;
  parents: User[];
  date = new Date();
  dateMin = new Date(new Date().getFullYear() - 4, 0, 2);
  showParent = false;
  setKidForm = this.fb.group({
    nameKids: this.fb.control('', [Validators.required]),
    tzKid: this.fb.control('', [Validators.required]),
    ageKids: this.fb.control('', [Validators.required, Validators.min(0), Validators.max(4)]),
    dateBorn: this.fb.control(new Date(new Date().getFullYear(), 0, 2).toISOString().split('T')[0], [Validators.required]),
    kidId: this.fb.control('0'),
    classId: this.fb.control(null),
    parentId: this.fb.control(null),

  });
  setParentForm = this.fb.group({

    userName: this.fb.control('', [Validators.required]),
    userTz: this.fb.control('', [Validators.required]),
    address: this.fb.control('', [Validators.required]),
    email: this.fb.control('', [Validators.required]),
    phoneNamber1: this.fb.control('', [Validators.required]),
    phoneNamber2: this.fb.control('', [Validators.required]),
    password: this.fb.control('', [Validators.required]),
    userTypeId: this.fb.control('1'),
    classId: this.fb.control(''),

  });
  constructor(private classServie: ClassesService,
    private kService: KidsService,
    private userService: UserService,
    private fb: FormBuilder,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private dialogRef: MatDialogRef<SetKidComponent>
  ) { }
  selectParent(parent: User) {
    if (parent.toString() == 'null') {
      this.showParent = true;
      this.setParentForm = this.fb.group({

        userName: this.fb.control('', [Validators.required]),
        userTz: this.fb.control('', [Validators.required]),
        address: this.fb.control('', [Validators.required]),
        email: this.fb.control('', [Validators.required]),
        phoneNamber1: this.fb.control('', [Validators.required]),
        phoneNamber2: this.fb.control('', [Validators.required]),
        password: this.fb.control('', [Validators.required]),
        userTypeId: this.fb.control('1'),
        classId: this.fb.control(''),

      });
    }
    else {
      // this.showParent = false;
      this.setParentForm = this.fb.group(parent);

    }

  }
  ngOnInit(): void {
    this.classServie.getAllׁׂׂׂׂׂׂ().subscribe(x => {
      this.classes = x;

    });
    this.userService.getParents().subscribe(x => {
      this.parents = x;
    })
    if (this.data && this.data.kid) {
      this.showParent = true;
      this.setKidForm = this.fb.group(this.data.kid);
      var today = new Date(this.data.kid.dateBorn);

      var myToday = new Date(today.getFullYear(), today.getMonth(), today.getDate(), 3, 0, 0);
  

      
      this.setKidForm.patchValue({
        'dateBorn':
          new Date(myToday).toISOString().split('T')[0]
      });
      this.setParentForm = this.fb.group(this.data.kid.userParent);
      // this.setKidForm = this.fb.group({
      //   nameKids: this.fb.control(this.data.kid.nameKids, [Validators.required]),
      //   tzKid: this.fb.control(this.data.kid.tzKid, [Validators.required]),
      //   ageKids: this.fb.control(this.data.kid.ageKids, [Validators.required, Validators.min(0), Validators.min(4)]),
      //   dateBorn: this.fb.control(new Date(this.data.kid.dateBorn).toISOString().split('T')[0], [Validators.required]),
      //   kidId: this.fb.control(this.data.kid.kidId),
      //   classId: this.fb.control(this.data.kid.classId),
      //   parentId: this.fb.control(this.data.kid.parentId),
      //   userParent: this.fb.group({
      //     userName: this.fb.control(this.data.kid.userParent.userName, [Validators.required]),
      //     userTz: this.fb.control(this.data.kid.userParent.userTz, [Validators.required]),
      //     address: this.fb.control(this.data.kid.userParent.address, [Validators.required]),
      //     email: this.fb.control(this.data.kid.userParent.email, [Validators.required]),
      //     phoneNamber1: this.fb.control(this.data.kid.userParent.phoneNamber1, [Validators.required]),
      //     phoneNamber2: this.fb.control(this.data.kid.userParent.phoneNamber2, [Validators.required]),
      //     password: this.fb.control(this.data.kid.userParent.password, [Validators.required]),
      //     userTypeId: this.fb.control('1'),
      //     classId: this.fb.control(''),
      //   })
      // });



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
    const p = <Kids>this.setKidForm.value;
    p.userParent = <User>this.setParentForm.value;
    p.userParent.kids = null;

    var today = new Date(p.dateBorn);

    var myToday = new Date(today.getFullYear(), today.getMonth(), today.getDate(), 3, 0, 0);


    p.dateBorn = myToday;
    p.parentId = p.userParent.userId;
    this.kService.addUpdateKid(p).subscribe(
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
