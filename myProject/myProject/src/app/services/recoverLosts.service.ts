import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http'
import { RecoverLosts } from '../classes/RecoverLosts';

@Injectable({
  providedIn: 'root'
})
export class ParentService {
  URL="https://localhost:44397/api/RecoverLosts/";

  constructor(private http:HttpClient) { }

  getAllׁׂׂׂׂׂׂ():Observable<RecoverLosts[]>{
    return this.http.get<RecoverLosts[]>(this.URL)
  }
  update(p: RecoverLosts ):Observable<RecoverLosts[]>{
    return this.http.put<RecoverLosts[]>(this.URL,p)
  }
  
  add(p: RecoverLosts):Observable<RecoverLosts[]>{
    return this.http.post<RecoverLosts[]>(this.URL,p)
  }

  
  delete(ParentId:number):Observable<RecoverLosts[]>{
    return this.http.delete<RecoverLosts[]>(this.URL+ParentId)
  }
}
