import { Component, OnInit } from '@angular/core';
import { RecoverLosts } from '../classes/RecoverLosts';
import { RecoverLostsService } from '../services/recoverLosts.service';
import { MatDialog } from '@angular/material/dialog';
import { SetRecoverLostsComponent } from '../set-recover-losts/set-recover-losts.component';
import { User } from '../classes/Users';
import Swal from 'sweetalert2';
@Component({
  selector: 'app-recover-losts-list',
  templateUrl: './recover-losts-list.component.html',
  styleUrls: ['./recover-losts-list.component.scss']
})
export class RecoverLostsListComponent implements OnInit {
  recoverLosts: RecoverLosts[];
  serviceBase: string = 'https://localhost:44397/UploadFile/';
  userId = 0;
  constructor(

    public dialog: MatDialog,
    private recoverLostService: RecoverLostsService
  ) { }

  ngOnInit(): void {
    this.userId = (<User>JSON.parse(localStorage.getItem('user'))).userId;
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
  openDialog(recId?: number) {
    const dialogRef = this.dialog.open(SetRecoverLostsComponent, {
      data: { recId },
    });
    dialogRef.afterClosed().subscribe((result) => {
      console.log(`Dialog result: ${result}`);
    });
    dialogRef.afterClosed().subscribe((result) => {
      console.log('The dialog was closed');
      this.getRecoverLost();
    });
  }
  delete(id) {
    Swal.fire({
      title: 'האם את/ה בטוח/ה?',
      text: "האם את/ה בטוח/ה שאת/ה רוצה למחוק את ההודעה הנוכחית?",
      icon: 'warning',
      showCancelButton: true,
      confirmButtonColor: '#3085d6',
      cancelButtonColor: '#d33',

      confirmButtonText: 'כן',
      cancelButtonText: 'לא',
    }).then((result) => {
      if (result.isConfirmed) {
        this.recoverLostService.delete(id).subscribe((x) => {
          this.getRecoverLost();
        });
      }
    });
  }
}

