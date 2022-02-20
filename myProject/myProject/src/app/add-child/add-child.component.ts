import { Component, OnInit } from '@angular/core';
import { kids } from '../classes/kids';
import { typeClass } from '../classes/typeClass';

import { KidsService } from '../services/kids.service';
import { TypeClassService } from '../services/type-class.service';

@Component({
  selector: 'app-add-child',
  templateUrl: './add-child.component.html',
  styleUrls: ['./add-child.component.scss']
})

export class AddChildComponent implements OnInit {
  myKids: kids = new kids();
  listTypeClass: typeClass[]
  constructor(private kidsSer: KidsService, private classTypeSer: TypeClassService) { }


  ngOnInit(): void {
    this.classTypeSer.getAllׁׂׂׂׂׂׂ().subscribe(
      data =>{ this.listTypeClass=data,
      console.log(this.listTypeClass)}
      
    )
  }

  addKids() {
    //delete
    //זה מילוי נוכחות וזה לא קשור לטופס הזה אז מה עושים
    this.myKids.AttendanceId = 0;
    // this.myKids.AgeKids = 0;
    // this.myKids.DateBorn = new Date();

    this.myKids.ClassId = 1;

    console.log(this.myKids);
    debugger
    this.kidsSer.add(this.myKids).subscribe(
      data => console.log(data),
      err => console.log(err)



    )


  }

}
