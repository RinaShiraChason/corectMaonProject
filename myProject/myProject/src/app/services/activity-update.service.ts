import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http'
import { ActivityUpdate } from '../classes/ActivityUpdate';

@Injectable({
  providedIn: 'root'
})
export class ActivityUpdateService {
  URL="https://localhost:44397/api/ActivityUpdate/";

  constructor(private http:HttpClient) { }

  getAllׁׂׂׂׂׂׂ():Observable<ActivityUpdate[]>{
    return this.http.get<ActivityUpdate[]>(this.URL)
  }
  update(av: ActivityUpdate ):Observable<ActivityUpdate[]>{
    return this.http.put<ActivityUpdate[]>(this.URL,av)
  }
  
  add(av: ActivityUpdate):Observable<ActivityUpdate[]>{
    return this.http.post<ActivityUpdate[]>(this.URL,av)
  }
  
  delete(IdActivityUpdate:number):Observable<ActivityUpdate[]>{
    return this.http.delete<ActivityUpdate[]>(this.URL+IdActivityUpdate)
  } 
}
