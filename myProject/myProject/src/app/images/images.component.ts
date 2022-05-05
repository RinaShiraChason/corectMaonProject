import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import Swal from 'sweetalert2';
import { Classes } from '../classes/Classes';
import { Images } from '../classes/Images';
import { User } from '../classes/Users';
import { ClassesService } from '../services/classes.service';
import { ImagesService } from '../services/images.service';
import { SetImagesComponent } from '../set-images/set-images.component';
import { SetRecoverLostsComponent } from '../set-recover-losts/set-recover-losts.component';

@Component({
  selector: 'app-images',
  templateUrl: './images.component.html',
  styleUrls: ['./images.component.scss']
})
export class ImagesComponent implements OnInit {

  constructor(private imagesService:ImagesService,private dialog:MatDialog,private classServie:ClassesService) { }
  userId = 0;
  user:User;
  classId = 0;
  classes:Classes[];
  serviceBase: string = 'https://localhost:44397/UploadFile/';
  images: Images[];
  isManager = false;
  ngOnInit(): void {
    this.user = <User>JSON.parse(localStorage.getItem('user'));
    this.userId = this.user.userId;
    this.classId = this.user.classId;

    if (this.user.userTypeId === 3) {
      this.isManager = true;
      this.classServie.getAllׁׂׂׂׂׂׂ().subscribe(x => {
        this.classes = x;
        this.classId = x[0].classId;
        this.getAll();
      });

    }
    else {
      this.getAll();

    }
   
  }
  selectClass(classId) {
    this.classId = classId;
    this.getAll();
  }

  openDialog(imgId?: number) {
    const dialogRef = this.dialog.open(SetImagesComponent, {
      data: { imgId,classId:this.classId },
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
    this.imagesService.GetAllByclassId( this.classId).subscribe((x) => {
     x.forEach((element) => {
        if (element.imageURL) {
          element.imageURL = this.serviceBase + element.imageURL;
        }
      });

      this.images = x;
    });
  
  }
  delete(id) {
    Swal.fire({
      title: 'האם את/ה בטוח/ה?',
      text: "האם את/ה בטוח/ה שאת/ה רוצה למחוק את הרשומה הנוכחית?",
      icon: 'warning',
      showCancelButton: true,
      confirmButtonColor: '#3085d6',
      cancelButtonColor: '#d33',

      confirmButtonText: 'כן',
      cancelButtonText: 'לא',
    }).then((result) => {
      if (result.isConfirmed) {
        this.imagesService.delete(id).subscribe((x) => {
          this.getAll();
        });
      }
    });
  }

}
