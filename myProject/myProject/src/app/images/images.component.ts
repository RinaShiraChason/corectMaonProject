import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Images } from '../classes/Images';
import { ImagesService } from '../services/images.service';
import { SetRecoverLostsComponent } from '../set-recover-losts/set-recover-losts.component';

@Component({
  selector: 'app-images',
  templateUrl: './images.component.html',
  styleUrls: ['./images.component.scss']
})
export class ImagesComponent implements OnInit {

  constructor(private imagesService:ImagesService,private dialog:MatDialog) { }
  userId = 5;
  serviceBase: string = 'https://localhost:44397/UploadFile/';
  images: Images[];
  ngOnInit(): void {
    this.getAll();
  }
  openDialog(barcode?: number) {
    const dialogRef = this.dialog.open(SetRecoverLostsComponent, {
      data: { barcode },
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
    this.imagesService.GetAllByclassId(2).subscribe((x) => {
     x.forEach((element) => {
        if (element.imageURL) {
          element.imageURL = this.serviceBase + element.imageURL;
        }
      });

      this.images = x;
    });
  
  }
  delete(id){

  }
}
