import { Component, OnInit } from '@angular/core';
import { RecoverLosts } from '../classes/RecoverLosts';
import { RecoverLostsService } from '../services/recoverLosts.service';
import { MatDialog } from '@angular/material/dialog';
import { SetRecoverLostsComponent } from '../set-recover-losts/set-recover-losts.component';
@Component({
  selector: 'app-recover-losts-list',
  templateUrl: './recover-losts-list.component.html',
  styleUrls: ['./recover-losts-list.component.scss']
})
export class RecoverLostsListComponent implements OnInit {
  recoverLosts:RecoverLosts[];
  serviceBase: string = 'https://localhost:44397/UploadFile/';
 userId = 2;
  constructor(

    public dialog: MatDialog,
    private recoverLostService: RecoverLostsService
  ) {}

  ngOnInit(): void {
    this.getRecoverLost();
   
  }
 
  getRecoverLost() {
    this.recoverLostService.getAllׁׂׂׂׂׂׂ().subscribe(
      (response: any[]) => {
        response.forEach((element) => {
          if (element.recoverLostsImage) {
            element.recoverLostsImage = this.serviceBase + element.recoverLostsImage;
          }
        });

        this.recoverLosts = response;
     
      },
      (error) => {
        console.log(error);
      }
    );
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
      this.getRecoverLost();
    });
  }
  delete(id){

  }
}

