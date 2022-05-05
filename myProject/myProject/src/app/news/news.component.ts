import { Component, OnInit } from '@angular/core';
import { Messages } from '../classes/Messages';
import { MessagesService } from '../services/messages.service';

@Component({
  selector: 'app-news',
  templateUrl: './news.component.html',
  styleUrls: ['./news.component.scss']
})
export class NewsComponent implements OnInit {
  messages: Messages[];
  
  constructor(private messageService: MessagesService) { }

  ngOnInit(): void {
    this.getAll();
  }
  getAll() {
   
    this.messageService.getMessagesNews().subscribe((x) => {
      this.messages = x;
    });
  }
}
