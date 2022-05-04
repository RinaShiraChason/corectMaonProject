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
  parents: User[];




  setMessageForm = this.fb.group({
    messageContent: this.fb.control('', [Validators.required]),
    messageDateTime: this.fb.control('', [Validators.required]),
    messageId: this.fb.control('0'),
    userFromId: this.fb.control('0'),
    kidId: this.fb.control('0', [Validators.required]),
    userToId: this.fb.control('0'),
  });
  constructor(private mServie: MessagesService,
    private kService: KidsService,
    private uService: UserService,
    private fb: FormBuilder,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private dialogRef: MatDialogRef<SetMessageComponent>
  ) { }

  ngOnInit(): void {
    this.uService.getParents().subscribe(x => {

      this.parents = x;
    })
      ;
    if (this.data && this.data.classId) {
      this.kService.getKidsByClass(this.data.classId).subscribe(x => {
        this.kids = x;

      });
    }
    if (this.data && this.data.message) {
      this.setMessageForm = this.fb.group(this.data.message);
    }




  }
  close() {
    if (this.dialogRef && this.dialogRef.close) {
      this.dialogRef.close({ data: 'Order' });
    }
  }


  setClass(): void {
    const p = <Messages>this.setMessageForm.value;
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
