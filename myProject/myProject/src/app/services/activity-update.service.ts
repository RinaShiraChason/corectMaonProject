import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http'
import { activityUpdate } from '../classes/ActivityUpdate';

@Injectable({
  providedIn: 'root'
})
export class ActivityUpdateService {
  URL="https://localhost:44397/api/activityUpdate/";

  constructor(private http:HttpClient) { }

  getAllׁׂׂׂׂׂׂ():Observable<activityUpdate[]>{
    return this.http.get<activityUpdate[]>(this.URL)
  }
  update(av: activityUpdate ):Observable<activityUpdate[]>{
    return this.http.put<activityUpdate[]>(this.URL,av)
  }
  
  add(av: activityUpdate):Observable<activityUpdate[]>{
    return this.http.post<activityUpdate[]>(this.URL,av)
  }
  
  delete(IdActivityUpdate:number):Observable<activityUpdate[]>{
    return this.http.delete<activityUpdate[]>(this.URL+IdActivityUpdate)
  } 
}
