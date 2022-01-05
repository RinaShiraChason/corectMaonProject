import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http'
import { teacherAndManager } from '../classes/teacherAndManager';

@Injectable({
  providedIn: 'root'
})
export class TeacherAndManagerService {
URL="https://localhost:44397/api/teacherAndManager/";

  constructor(private http:HttpClient) { }

  getAllׁׂׂׂׂׂׂ():Observable<teacherAndManager[]>{
    return this.http.get<teacherAndManager[]>(this.URL)
  }
  update(tm: teacherAndManager ):Observable<teacherAndManager[]>{
    return this.http.put<teacherAndManager[]>(this.URL,tm)
  }
  
  add(tm: teacherAndManager):Observable<teacherAndManager[]>{
    return this.http.post<teacherAndManager[]>(this.URL,tm)
  }
  
  delete(TeacherId:number):Observable<teacherAndManager[]>{
    return this.http.delete<teacherAndManager[]>(this.URL+TeacherId)
  }
}
