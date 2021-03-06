import { Message } from "@angular/compiler/src/i18n/i18n_ast";
import { Component, OnInit } from "@angular/core";
import { MatDialog } from "@angular/material/dialog";
import Swal from "sweetalert2";
import { Kids } from "../classes/Kids";
import { Messages } from "../classes/Messages";
import { User } from "../classes/Users";
import { MessagesService } from "../services/messages.service";
import { SetMessageComponent } from "../set-message/set-message.component";

@Component({
  selector: "app-messages",
  templateUrl: "./messages.component.html",
  styleUrls: ["./messages.component.scss"],
})
export class MessagesComponent implements OnInit {
  messagesTo: Messages[];
  messagesFrom: Messages[];
  user: User;
  kidId = 0;
  constructor(private messageService: MessagesService, private dialog: MatDialog) {
    // this.user = <IUser>this.tokenStorage.getUser().user;
  }

  ngOnInit(): void {
    this.user = <User>JSON.parse(localStorage.getItem('user'));
    if (localStorage.getItem('kid') != null
      && this.user.userTypeId === 1) {
      this.kidId = (<Kids>JSON.parse(localStorage.getItem('kid'))).kidId;
    }

    this.getAll();
  }
  openDialog(message?: Message) {
    const dialogRef = this.dialog.open(SetMessageComponent, {
      data: { message, user: this.user },
    });
    dialogRef.afterClosed().subscribe((result) => {
      console.log(`Dialog result: ${result}`);
    });
    dialogRef.afterClosed().subscribe((result) => {
      console.log('The dialog was closed');
      this.messageService.getMessagesByFrom(this.user.userId, this.kidId).subscribe((x) => {
        this.messagesFrom = x;
      });
    });
  }
  delete(mesageId) {
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
        this.messageService.delete(mesageId).subscribe((x) => {
          this.messageService.getMessagesByFrom(this.user.userId, this.kidId).subscribe((x) => {
            this.messagesFrom = x;
          });

        });
      }
    })


  }
  getAll() {
    this.messageService.getMessagesByTo(this.user.userId, this.kidId).subscribe((x) => {
      this.messagesTo = x;
    });
    this.messageService.getMessagesByFrom(this.user.userId, this.kidId).subscribe((x) => {
      this.messagesFrom = x;
    });
  }
}
