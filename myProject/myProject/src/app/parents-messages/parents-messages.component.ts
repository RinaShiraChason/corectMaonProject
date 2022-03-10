import { Message } from '@angular/compiler/src/i18n/i18n_ast';
import { Component, OnInit } from '@angular/core';
import { ParentsMessgesService } from '../services/parents-messges.service';

@Component({
  selector: 'app-parents-messages',
  templateUrl: './parents-messages.component.html',
  styleUrls: ['./parents-messages.component.scss']
})

export class ParentsMessagesComponent implements OnInit {
  messgesList: Message[];

  constructor(private pMassegesService: ParentsMessgesService) { }

  ngOnInit(): void {

    this.pMassegesService.getMessgesByTeacherׁׂׂׂׂׂׂ(5).subscribe(

    //   data => {
    //     {
    //       debugger
    //       this.messgesList = data;
    //       console.log(data);
    //     }
    //     err => console.log(err) }

     )
    // console.log(this.messgesList);
  }


}
