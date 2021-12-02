import { Component, OnInit } from '@angular/core';
import { Observable, Subject } from 'rxjs';
import { startWith, map } from 'rxjs/operators';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  ngOnInit(): void {
    this.results = this.searchText.pipe(
      startWith(''),
      map((value: string) => this.filter(value))
    );
  }
  title = 'mdb-angular-free';
  searchText = new Subject();
  results: Observable<string[]>;
  data: any = [
    'red',
    'green',
    'blue',
    'cyan',
    'magenta',
    'yellow',
    'black',
  ];

  filter(value: string): string[] {
    const filterValue = value.toLowerCase();
    return this.data.filter((item: string) => item.toLowerCase().includes(filterValue));
  }
}





