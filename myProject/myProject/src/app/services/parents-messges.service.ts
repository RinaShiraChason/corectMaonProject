import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Messages } from '../classes/Messages';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ParentsMessgesService {
URL ="http://localhost:4200/parentsMessages";

  constructor(private http: HttpClient) { }

  getAllׁׂׂׂׂׂׂ(): Observable<Messages[]> {

    return this.http.get<Messages[]>(this.URL)
  }
}
