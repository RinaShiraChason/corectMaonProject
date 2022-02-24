import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http'
import { Kids } from '../classes/Kids';
@Injectable({
  providedIn: 'root'
})
export class KidsService {
URL="https://localhost:44397/api/Kids/";

  constructor(private http:HttpClient) { }

getAllׁׂׂׂׂׂׂ():Observable<Kids[]>{
  
  return this.http.get<Kids[]>(this.URL)
}

update(k: Kids ):Observable<Kids[]>{
  return this.http.put<Kids[]>(this.URL,k)
}

add(k: Kids):Observable<Kids[]>{
  k.KidId=(Number)(k.KidId)
  k.ParentId=(Number)(k.ParentId)
  debugger
  return this.http.post<Kids[]>(this.URL,k)
}

delete(tz:number):Observable<Kids[]>{
  return this.http.delete<Kids[]>(this.URL+tz)
}
}