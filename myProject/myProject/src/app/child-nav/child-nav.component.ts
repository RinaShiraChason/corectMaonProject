import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { User } from '../classes/Users';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-child-nav',
  templateUrl: './child-nav.component.html',
  styleUrls: ['./child-nav.component.scss']
})
export class ChildNavComponent implements OnInit {
  user: User;
  constructor(private userService: UserService, private route: Router) { }

  ngOnInit(): void {
    this.user = <User>JSON.parse(localStorage.getItem('user'));
    this.userService.loginUser.subscribe(x => {
      this.user = x;

    })
  }
  logout() {
    this.user = null;
    localStorage.removeItem('user');
    localStorage.removeItem('kid');

  }
  setKidId(kid) {
    localStorage.setItem('kid', JSON.stringify(kid));
  }
  loginSpecUser() {

    if (this.user.userTypeId === 2) {
      this.route.navigateByUrl('menuTeacher');

    }
    else if (this.user.userTypeId === 3) {
      this.route.navigateByUrl('menuManager');

    }
  }
}
