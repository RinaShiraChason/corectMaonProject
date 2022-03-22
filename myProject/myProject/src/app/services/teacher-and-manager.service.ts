import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http'
import { Images } from '../classes/Images';

@Injectable({
  providedIn: 'root'
})
export class TeacherAndManagerService {
URL="https://localhost:44397/api/Images/";

  constructor(private http:HttpClient) { }

  getAllׁׂׂׂׂׂׂ():Observable<Images[]>{
    return this.http.get<Images[]>(this.URL)
  }
  update(tm: Images ):Observable<Images[]>{
    return this.http.put<Images[]>(this.URL,tm)
  }
  
  add(tm: Images):Observable<Images[]>{
    return this.http.post<Images[]>(this.URL,tm)
  }
  
  delete(teacherId:number):Observable<Images[]>{
    return this.http.delete<Images[]>(this.URL+teacherId)
  }
}
