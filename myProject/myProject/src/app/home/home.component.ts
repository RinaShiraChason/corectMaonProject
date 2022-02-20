import { AfterViewInit, Component, OnInit, Renderer2 } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit, AfterViewInit {

  constructor( private renderer: Renderer2) { }

  cards = [
    {img: 'assets/images/g (1).jpg'},
    {img: 'assets/images/g (2).jpg'},
    {img: 'assets/images/g (3).jpg'},
    {img: 'assets/images/g (4).jpg'},
    {img: 'assets/images/g (5).jpg'},
    {img: 'assets/images/g (6).jpg'},
    {img: 'assets/images/g (7).jpg'},
    {img: 'assets/images/g (8).jpg'},
    {img: 'assets/images/g (9).jpg'},
    {img: 'assets/images/g (10).jpg'},
    {img: 'assets/images/g (11).jpg'},
    {img: 'assets/images/g (12).jpg'},
    {img: 'assets/images/g (13).jpg'},
    {img: 'assets/images/g (14).jpg'},
    {img: 'assets/images/g (15).jpg'},
  ];
  
  slides: any = [[]];
  
  
  chunk(arr: any, chunkSize: number) {
    let R = [];
    for (let i = 0, len = arr.length; i < len; i += chunkSize) {
      R.push(arr.slice(i, i + chunkSize));
    }
    return R;
  }
  
  ngOnInit() {
    this.slides = this.chunk(this.cards, 3);
  }
  
  ngAfterViewInit() {
    const buttons = document.querySelectorAll('.btn-floating');
    buttons.forEach((el: any) => {
      this.renderer.removeClass(el, 'btn-floating');
      this.renderer.addClass(el, 'px-3');
      this.renderer.addClass(el.firstElementChild, 'fa-3x');
    });
  }
}
