import { Message } from '@angular/compiler/src/i18n/i18n_ast';
import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import Swal from 'sweetalert2';
import { Classes } from '../classes/Classes';
import { Kids } from '../classes/Kids';
import { Messages } from '../classes/Messages';
import { User } from '../classes/Users';
import { KidsService } from '../services/kid.service';
import { MessagesService } from '../services/messages.service';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-set-message',
  templateUrl: './set-message.component.html',
  styleUrls: ['./set-message.component.scss']
})
export class SetMessageComponent implements OnInit {

  kids: Kids[];
  message: Messages;
  users: User[];
  today = new Date();
  setMessageForm = this.fb.group({
    messageContent: this.fb.control('', [Validators.required]),
    messageDateTime: this.fb.control(new Date().toISOString().split('T')[0], [Validators.required]),
    messageId: this.fb.control('0'),
    userFromId: this.fb.control('0'),
    kidId: this.fb.control(''),
    userToId: this.fb.control('', [Validators.required]),
  });
  constructor(private mServie: MessagesService,
    private kService: KidsService,
    private uService: UserService,
    private fb: FormBuilder,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private dialogRef: MatDialogRef<SetMessageComponent>
  ) { }
  //TS
  addHoursToDate(date: Date, hours: number): Date {
    return new Date(new Date(date).setHours(date.getHours() + hours));
  }

  onChangeParent(e) {
    var user = this.users.filter(x => x.userId === e.value)[0];
    this.kids = user.kids;
    if (this.kids && this.kids.length > 0 ) {
      this.setMessageForm.patchValue({ kidId: this.kids[0].kidId });

    }
  }
  ngOnInit(): void {
    if (this.data && this.data.user)
      this.setMessageForm.patchValue({ userFromId: this.data.user.userId });
    if (this.data.user.userTypeId === 1) {

      this.uService.GetTeachersAndManagers().subscribe(x => {
        this.users = x;
      })
    }
    else if (this.data.user.userTypeId === 2 || this.data.user.userTypeId === 3) {

      this.uService.getParents().subscribe(x => {
        this.users = x;

        var user = this.users.filter(x => x.userId === this.data.message.userToId)[0];
        this.kids = user.kids;


      })
    }

    // if (this.data && this.data.classId) {
    //   this.kService.getKidsByClass(this.data.classId).subscribe(x => {
    //     this.kids = x;
    //   });
    // }
    if (this.data && this.data.message) {
      this.setMessageForm = this.fb.group(this.data.message);

    }
    else {
      if (this.data.user.userTypeId === 1) {
        this.setMessageForm.patchValue({ kidId: 2 });

      }
    }




  }
  close() {
    if (this.dialogRef && this.dialogRef.close) {
      this.dialogRef.close({ data: 'Order' });
    }
  }


  setClass(): void {
    const p = <Messages>this.setMessageForm.value;
    p.messageDateTime = this.addHoursToDate(new Date(), 3);
    this.mServie.addUpdateMessage(p).subscribe(
      (response) => {
        Swal.fire('', 'השמירה בוצעה בהצלחה', 'success');
        this.close();

      },
      (error) => {
        console.log(error);
      }
    );
  }
}
