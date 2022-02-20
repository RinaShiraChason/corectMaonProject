import { Component, OnInit } from '@angular/core';
import { kids } from '../classes/kids';
import { KidsService } from '../services/kids.service';

@Component({
  selector: 'app-child-list',
  templateUrl: './child-list.component.html',
  styleUrls: ['./child-list.component.scss']
})
export class ChildListComponent implements OnInit {
  childList:kids[];
   
  constructor(private KidsSer:KidsService) { }

  ngOnInit(): void {
    
    this.KidsSer.getAllׁׂׂׂׂׂׂ().subscribe(
      
      data=>{{
        debugger
        this.childList=data
        console.log(data);
      }
        err=>console.log(err)
        
      })
      console.log(this.childList);
  
  }

}
