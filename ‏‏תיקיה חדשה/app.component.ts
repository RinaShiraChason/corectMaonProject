import { Component, Inject } from '@angular/core';

//import {LOCAL_STORAGE, WebStorageService} from 'angular-webstorage-service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Aproject';


  //constructor(@Inject(LOCAL_STORAGE) private storage: WebStorageService) { }

  ngOnInit(): void {
     

}

}
