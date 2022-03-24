import { Component, OnInit } from '@angular/core';
import { User } from '../classes/Users';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-child-nav',
  templateUrl: './child-nav.component.html',
  styleUrls: ['./child-nav.component.scss']
})
export class ChildNavComponent implements OnInit {
  user: User;
  constructor(private userService:UserService) { }

  ngOnInit(): void {
    this.user = <User>JSON.parse(localStorage.getItem('user'));
    this.userService.loginUser.subscribe(x=>{
      this.user = x;

    })
  }
  logout(){
    this.user = null;
    localStorage.removeItem('user');

  }
}
