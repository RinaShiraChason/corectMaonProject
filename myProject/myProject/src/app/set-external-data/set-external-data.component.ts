import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ExternalData } from '../classes/ExternalData';
import { ExternalDataService } from '../services/extenral-data.service';

@Component({
  selector: 'app-set-external-data',
  templateUrl: './set-external-data.component.html',
  styleUrls: ['./set-external-data.component.scss']
})
export class SetExternalDataComponent implements OnInit {


  extData: ExternalData;
  setExtForm = this.fb.group({
    externalDataTitle: this.fb.control('', [Validators.required]),
    externalDataLink: this.fb.control('', [Validators.required]),
    externalDataDate: this.fb.control(null),
    teacherId: this.fb.control(null),
    classId: this.fb.control(null),
    externalDataId: this.fb.control('0'),
  });



  constructor(
    private extService: ExternalDataService,
    private fb: FormBuilder,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private dialogRef: MatDialogRef<SetExternalDataComponent>
  ) { }

  ngOnInit(): void {
    if (this.data && this.data.ext) {

      this.setExtForm = this.fb.group(this.data.ext);
      this.extData = this.data.ext
    }
    else {
      this.setExtForm.patchValue({ 'classId': this.data.classId, 'teacherId': this.data.teacherId });
    }


  }
  close() {
    if (this.dialogRef && this.dialogRef.close) {
      this.dialogRef.close({ data: 'Order' });
    }
  }



  setExtData(): void {
    const p = <ExternalData>this.setExtForm.value;
    if (!p.externalDataId || p.externalDataId == 0) {
      p.externalDataDate = new Date();
    }
    this.extService.AddUpdateExtData(p).subscribe(
      (response) => {

        this.close();

      },
      (error) => {
        console.log(error);
      }
    );
  }
}
