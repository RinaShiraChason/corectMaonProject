import { Component, Inject, OnInit } from '@angular/core';

import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Classes } from 'src/app/classes/Classes';
import { TypeClass } from 'src/app/classes/TypeClass';
import { User } from 'src/app/classes/Users';
import { ClassesService } from 'src/app/services/classes.service';
import { TypeClassService } from 'src/app/services/type-class.service';
import { UserService } from 'src/app/services/user.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-set-class',
  templateUrl: './set-class.component.html',
  styleUrls: ['./set-class.component.scss']
})
export class SetClassComponent implements OnInit {
  typeClassList: TypeClass[];

  setClassForm = this.fb.group({
    className: this.fb.control('', [Validators.required]),
    classTypeId: this.fb.control('', [Validators.required]), 
    classId: this.fb.control('0'), 
  });
  constructor(private classServie: ClassesService,
    private tClassServie: TypeClassService,
    private fb: FormBuilder,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private dialogRef: MatDialogRef<SetClassComponent>
  ) { }
 
  ngOnInit(): void {
    this.tClassServie.getAllׁׂׂׂׂׂׂ().subscribe(x => {
      this.typeClassList = x;

    });

    if (this.data && this.data.classes) {
      this.setClassForm = this.fb.group(this.data.classes);
  

    }
  
  }
  close() {
    if (this.dialogRef && this.dialogRef.close) {
      this.dialogRef.close({ data: 'Order' });
    }
  }


  setClass(): void {
    const p = <Classes>this.setClassForm.value;
    this.classServie.addUpdateClass(p).subscribe(
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
