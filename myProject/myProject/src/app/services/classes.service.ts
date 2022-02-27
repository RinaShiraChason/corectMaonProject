import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http'
import { classes } from '../classes/Classes';

@Injectable({
  providedIn: 'root'
})
export class ClassesService {

URL="https://localhost:44397/api/classes/";

  constructor(private http:HttpClient) { }

  getAllׁׂׂׂׂׂׂ():Observable<classes[]>{
    return this.http.get<classes[]>(this.URL)
  }
  update(c: classes ):Observable<classes[]>{
    return this.http.put<classes[]>(this.URL,c)
  }
  
  add(c: classes):Observable<classes[]>{
    return this.http.post<classes[]>(this.URL,c)
  }
  
  delete(ClassId:number):Observable<classes[]>{
    return this.http.delete<classes[]>(this.URL+ClassId)
  }

}
