import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
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
  id = 0;
  constructor(private dcSerice: DayCareService, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.route.queryParams.subscribe(params => {
      this.id = params['id'];
    });
    this.getAll();
  }
  getAll() {
    this.dcSerice.getDayCareByKids(this.id).subscribe((x) => {
      this.dayCareByKids = x;
    });

  }

}
