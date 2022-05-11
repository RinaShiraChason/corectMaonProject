import { Component, OnInit, Renderer2 } from '@angular/core';
import { ActivityUpdate } from '../classes/ActivityUpdate';
import { ActivatedRoute } from '@angular/router';
import { DayCare } from '../classes/DayCare';
import { DayCareService } from '../services/day-care.service';
import {ActivityUpdateService} from '../services/activity-update.service';

@Component({
  selector: 'app-child-info',
  templateUrl: './child-info.component.html',
  styleUrls: ['./child-info.component.scss']
})
export class ChildInfoComponent implements OnInit {

  dayCareByKids: DayCare;
  activityUpdateByClass: ActivityUpdate;
  today = new Date();
  id = 0;
  constructor(private dcSerice: DayCareService, private route: ActivatedRoute, 
    private auSerice: ActivityUpdateService,private renderer: Renderer2) { }

  cards = [
    {img: 'assets/images/g(16).jpg'},
    {img: 'assets/images/g(17).jpg'},
    {img: 'assets/images/g(18).jpg'},
    {img: 'assets/images/g(19).jpg'},
    {img: 'assets/images/g(20).jpg'},
    {img: 'assets/images/g(21).jpg'},
    {img: 'assets/images/g(28).jpg'},
    {img: 'assets/images/g(30).jpg'},
    {img: 'assets/images/g(31).jpg'},
    {img: 'assets/images/g(32).jpg'},
    {img: 'assets/images/g(23).jpg'},
    {img: 'assets/images/g(24).jpg'},
    {img: 'assets/images/g(25).jpg'},
    {img: 'assets/images/g(26).jpg'},
    {img: 'assets/images/g(27).jpg'},
  ];
 
  slides: any = [[]];
  
  imgDrive(){
  let url = 'https//drive.google.com/drive/folders/1Hm9ZSihyrqaGPJLAwOClsPSInJlzAeZY?usp=sharing';
  window.open(url);
  }
  
  chunk(arr: any, chunkSize: number) {
    let R = [];
    for (let i = 0, len = arr.length; i < len; i += chunkSize) {
      R.push(arr.slice(i, i + chunkSize));
    }
    return R;
  }

  ngAfterViewInit() {
    const buttons = document.querySelectorAll('.btn-floating');
    buttons.forEach((el: any) => {
      this.renderer.removeClass(el, 'btn-floating');
      this.renderer.addClass(el, 'px-3');
      this.renderer.addClass(el.firstElementChild, 'fa-3x');
    });
  }
  
  ngOnInit(): void {
    this.id = +localStorage.getItem('kidId');
   

    this.getAll();
    this.getActivityUpdateByClass();
   
    
    this.slides = this.chunk(this.cards, 3);
  }
  
  getAll() {
    this.dcSerice.getDayCareByKids(this.id).subscribe((x) => {
      this.dayCareByKids = x;
    });

  }

  getActivityUpdateByClass() {
    this.auSerice.getTodayActivityUpdateByClass(1).subscribe((x) => {
      this.activityUpdateByClass = x;
    });
  }

}
