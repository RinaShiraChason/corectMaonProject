import { Component, OnInit } from "@angular/core";
import { Messages } from "../classes/Messages";
import { MessagesService } from "../services/messages.service";

@Component({
  selector: "app-messages",
  templateUrl: "./messages.component.html",
  styleUrls: ["./messages.component.scss"],
})
export class MessagesComponent implements OnInit {
  messagesTo: Messages[];
  messagesFrom: Messages[];

  constructor(private messageService: MessagesService) {
    // this.user = <IUser>this.tokenStorage.getUser().user;
  }

  ngOnInit(): void {
    this.getAll();
  }
  getAll() {
    this.messageService.getMessagesByTo(2).subscribe((x) => {
      this.messagesTo = x;
    });
    this.messageService.getMessagesByFrom(2).subscribe((x) => {
      this.messagesFrom = x;
    });
  }
}
