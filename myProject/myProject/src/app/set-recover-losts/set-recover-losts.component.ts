import { Component, Inject, OnInit } from '@angular/core';
import { RecoverLosts } from '../classes/RecoverLosts';
import { RecoverLostsService } from '../services/recoverLosts.service';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
@Component({
  selector: 'app-set-recover-losts',
  templateUrl: './set-recover-losts.component.html',
  styleUrls: ['./set-recover-losts.component.scss']
})
export class SetRecoverLostsComponent implements OnInit {


  http: any;
  Image: File;
  imageUrl: string;
  fileToUpload: File[];
  componentId: string;
 
  recoverLosts: RecoverLosts;
  setRecoverLostForm = this.fb.group({
    recoverLostsInfo: this.fb.control('', [Validators.required]),
    recoverLostsImage: this.fb.control(''),
    recoverLostsDate: this.fb.control(null),
    postalCode: this.fb.control(null),
    idUser: this.fb.control(null),
    recoverLostsId: this.fb.control(null),
  });
  url: string | ArrayBuffer;
  serviceBase: string = 'https://localhost:44397/UploadFile/';

  constructor(
    private recService: RecoverLostsService,
    private fb: FormBuilder,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private dialogRef: MatDialogRef<SetRecoverLostsComponent>
  ) {}

  ngOnInit(): void {
    if (this.data && this.data.recoverLostsId) {
      this.recService.getById(this.data.recoverLostsId).subscribe(
        (response) => {
          this.setRecoverLostForm = this.fb.group(response);
         
          this.recoverLosts = response;
        },
        (error) => {
          console.log(error);
        }
      );
    }

  

  }
  close() {
    if (this.dialogRef && this.dialogRef.close) {
      this.dialogRef.close({ data: 'Order' });
    }
  }

  onFileChanged(event) {
    const files = event.target.files;
    if (files.length === 0) return;

    const mimeType = files[0].type;
    if (mimeType.match(/image\/*/) == null) {
      return;
    }

    const reader = new FileReader();
    this.fileToUpload = files;
    reader.readAsDataURL(files[0]);
    reader.onload = (_event) => {
      if (this.recoverLosts) {
        this.recoverLosts.recoverLostsImage = null;
      }
      this.url = reader.result;
    };
  }
  AddProduct(): void {
    const p = <RecoverLosts>this.setRecoverLostForm.value;

    this.recService.AddUpdateRecoverLost(p).subscribe(
      (response) => {
        if (this.fileToUpload) {
          this.recService
            .uploadImage(response, this.fileToUpload[0])
            .subscribe(
              (data) => {
                this.close();
              },
              (error) => {
                console.log(error);
              }
            );
        } else {
          this.close();
        }
      },
      (error) => {
        console.log(error);
      }
    );
  }
}
