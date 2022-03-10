import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.scss']
})
export class MenuComponent implements OnInit {

  constructor(private usersService: UserService,private router:Router) { }

  ngOnInit(): void {
  }
  checkIfManager() {
    // if (this.usersService.user.UserStatusName == "מנהל") {
     return true;
    // }

  }
  readAsapimFromExcel(){

    this.router.navigate(["/updatestudents"]);
  
  }

  goToRequestTable(){
    this.router.navigate(["/requestsTable"]);

  }

  routeBack(){
    this.router.navigate(["/users"]);
  }
}
