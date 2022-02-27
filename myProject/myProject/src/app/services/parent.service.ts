import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http'
import { parent } from '../classes/RecoverLosts';

@Injectable({
  providedIn: 'root'
})
export class ParentService {
  URL="https://localhost:44397/api/parent/";

  constructor(private http:HttpClient) { }

  getAllׁׂׂׂׂׂׂ():Observable<parent[]>{
    return this.http.get<parent[]>(this.URL)
  }
  update(p: parent ):Observable<parent[]>{
    return this.http.put<parent[]>(this.URL,p)
  }
  
  add(p: parent):Observable<parent[]>{
    return this.http.post<parent[]>(this.URL,p)
  }

  
  delete(ParentsId:number):Observable<parent[]>{
    return this.http.delete<parent[]>(this.URL+ParentsId)
  }
}
