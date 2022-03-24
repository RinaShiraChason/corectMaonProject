import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import Swal from 'sweetalert2';
import { User } from '../classes/Users';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-login-page',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.scss']
})
export class LoginPageComponent implements OnInit {
  form = this.fb.group({
    email: this.fb.control('', [Validators.required, Validators.pattern('^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$')]),
    password: this.fb.control('', [
      Validators.required,
      Validators.pattern(
        '(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[$@$!%*?&])[A-Za-zd$@$!%*?&].{7,}'
      ),
    ]),
  });
  constructor(private fb: FormBuilder, private userService: UserService, private route: Router) { }

  ngOnInit(): void {
  }

  signIn() {
    var user = <User>this.form.value;
    this.userService.login(user).subscribe(x => {
      if (!x) {
        Swal.fire('Ooooops', 'שם משתמש או סיסמא שגויים', 'error')
      }
      else {
        localStorage.setItem('user',JSON.stringify(x));
        this.userService.loginUser.next(x);
        if (x.userTypeId === 1) {
          if(x.kids.length > 0)
          {
            var id = x.kids[0].kidId;
            this.route.navigateByUrl('childArea/'+id);
          }
        else{
          Swal.fire('Oooops','ארעה תקלה, פנה להנהלת המעון','error')
        }

        }
        else if (x.userTypeId === 2) {
          this.route.navigateByUrl('menuTeacher');

        }
        else if (x.userTypeId === 3) {
          this.route.navigateByUrl('menuManager');

        }
        else{
          this.route.navigateByUrl('about');


        }
      }
    })
  }
}
