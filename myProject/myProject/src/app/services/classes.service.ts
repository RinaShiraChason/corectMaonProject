import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http'
import { Classes } from '../classes/Classes';

@Injectable({
  providedIn: 'root'
})
export class ClassesService {

URL="https://localhost:44397/api/Classes/";

  constructor(private http:HttpClient) { }

  getAllׁׂׂׂׂׂׂ():Observable<Classes[]>{
    return this.http.get<Classes[]>(this.URL)
  }
  update(c: Classes ):Observable<Classes[]>{
    return this.http.put<Classes[]>(this.URL,c)
  }
  
  add(c: Classes):Observable<Classes[]>{
    return this.http.post<Classes[]>(this.URL,c)
  }
  
  delete(classId:number):Observable<Classes[]>{
    return this.http.delete<Classes[]>(this.URL+classId)
  }

}
