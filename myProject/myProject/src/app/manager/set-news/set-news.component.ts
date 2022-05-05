import { Component, OnInit } from '@angular/core';
import { Messages } from 'src/app/classes/Messages';
import { MessagesService } from 'src/app/services/messages.service';

@Component({
  selector: 'app-set-news',
  templateUrl: './set-news.component.html',
  styleUrls: ['./set-news.component.scss']
})
export class SetNewsComponent implements OnInit {

  messages: Messages[];
  sourceMessages: Messages[];
  constructor(private messageService: MessagesService) { }

  ngOnInit(): void {
    this.getAll();
  }
  getAll() {
   
    this.messageService.getMessagesNews().subscribe((x) => {
      this.messages = x;
      this.sourceMessages = x;
    });
  }
  saveNews(){
    this.messageService.saveNews( this.messages).subscribe((x) => {
      this.messages = x;
    });

  }
}
