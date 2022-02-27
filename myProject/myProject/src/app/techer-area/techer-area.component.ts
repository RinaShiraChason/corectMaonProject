import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-techer-area',
  templateUrl: './techer-area.component.html',
  styleUrls: ['./techer-area.component.scss']
})
export class TecherAreaComponent implements OnInit {

  constructor() { }
openTextBox = function () {
  document.getElementById("TXTMSG").style.display="block";
}

  ngOnInit(): void {
  }

}
