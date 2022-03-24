import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Kids } from '../classes/Kids';
import { KidsService } from '../services/kid.service';

@Component({
  selector: 'app-kids-day-history-modal',
  templateUrl: './kids-day-history-modal.component.html',
  styleUrls: ['./kids-day-history-modal.component.scss']
})
export class KidsDayHistoryModalComponent implements OnInit {
  kid: Kids;

  monthSelected = new Date().getMonth() + 1;
  yearSelected = new Date().getFullYear();
  month = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12];
  years = [new Date().getFullYear(), new Date().getFullYear() - 1, new Date().getFullYear() - 2, new Date().getFullYear() - 3];
  constructor(
    private kService: KidsService,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private dialogRef: MatDialogRef<KidsDayHistoryModalComponent>
  ) { }

  ngOnInit(): void {
    if (this.data && this.data.kidId) {
      this.kService.getHistoryKidsData(this.data.kidId, this.monthSelected, this.yearSelected)
        .subscribe(x => {
          this.kid = x;
        })
    }
  }
  getHistory(month, year) {
    this.kService.getHistoryKidsData(this.data.kidId,month, year)
    .subscribe(x => {
      this.kid = x;
    })

  }
}
