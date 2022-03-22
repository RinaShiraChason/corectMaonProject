import { Component, OnInit } from '@angular/core';
import { DayCare } from '../classes/DayCare';
import { DayCareService } from '../services/day-care.service';

@Component({
  selector: 'app-child-area',
  templateUrl: './child-area.component.html',
  styleUrls: ['./child-area.component.scss']
})
export class ChildAreaComponent implements OnInit {
  dayCareByKids: DayCare;
  today = new Date();

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
