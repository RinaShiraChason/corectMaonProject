import { Component, OnInit } from '@angular/core';
import { DayCare } from '../classes/DayCare';
import { DayCareService } from '../services/day-care.service';

@Component({
  selector: 'app-calender',
  templateUrl: './calender.component.html',
  styleUrls: ['./calender.component.scss']
})
export class CalenderComponent implements OnInit {
dayCareByKids: DayCare;

  constructor(private dcSerice: DayCareService) { }

  
  ngOnInit(): void {
    this.getAll();
  }
  getAll() {
    this.dcSerice.getDayCareByKids(3).subscribe((x) => {
      this.dayCareByKids = x;
    });

     }
}
