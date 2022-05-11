import { Component, Inject, OnInit } from '@angular/core';
import { Images } from '../classes/Images';
import { ImagesService } from '../services/images.service';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { User } from '../classes/Users';
import Swal from 'sweetalert2';
@Component({
  selector: 'app-set-images',
  templateUrl: './set-images.component.html',
  styleUrls: ['./set-images.component.scss']
})
export class SetImagesComponent implements OnInit {
  http: any;
  img: File;
  imageUrl: string;
  fileToUpload: File[];
  componentId: string;

  imageItem: Images;
  setImageForm = this.fb.group({
    imageTitle: this.fb.control('', [Validators.required]),
    imageData: this.fb.control('', [Validators.required]),
    imageURL: this.fb.control(''),
    imageDate: this.fb.control(new Date().toISOString().split('T')[0]),
    teacherId: this.fb.control(null),
    classId: this.fb.control(null),
    imageId: this.fb.control(0),
  });


  url: string | ArrayBuffer;
  serviceBase: string = 'https://localhost:44397/UploadFile/';

  constructor(
    private imgService: ImagesService,
    private fb: FormBuilder,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private dialogRef: MatDialogRef<SetImagesComponent>
  ) { }

  ngOnInit(): void {

    if (this.data && this.data.imgId) {
      this.imgService.getById(this.data.imgId).subscribe(
        (response) => {
          this.setImageForm = this.fb.group(response);
          this.imageItem = response;
        },
        (error) => {
          console.log(error);
        }
      );
    }
    else {
      var user = <User>JSON.parse(localStorage.getItem('user'));
      this.setImageForm.patchValue({ "teacherId": user.userId,"classId":this.data.classId });
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
      if (this.imageItem) {
        this.imageItem.imageURL = null;
      }
      this.url = reader.result;
    };
  }
  //הפונקציה מעלה לתמונה לאתר
  setImage(): void {
    //הקצאת משתנה מסוג תמונה
    const p = <Images>this.setImageForm.value;
    //מגדירים את התאריך שלו שווה לתאריך הנוכחי
    p.imageDate = new Date();
    // הוספת משתנה עזר ששווה לתמונה הנוכחית
    var self = this;
    //שולחים לפונקציה ב service את התמונה הנוכחית שמוסיפה אותה למאגר התמונות במעון
    this.imgService.AddUpdateImage(p).subscribe(
      (response) => {
        // אם ההלעה עבדה
        if (this.fileToUpload) {
          this.imgService
            .uploadImage(response, this.fileToUpload[0])
            .subscribe(
              (data) => {
                //אז מראה הודעה שהתונה נשמרה בהצלחה!
                Swal.fire('','השמירה בוצעה בהצלחה','success');
                self.close();
              },
              (error) => {
                console.log(error);
                //אחרת מרתיע על שגיאה
                Swal.fire('Oooops','ארעה שגיאה בשמירה, פנה למנהל המערכת','error');
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
