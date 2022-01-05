import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http'
import { kids } from '../classes/kids';
@Injectable({
  providedIn: 'root'
})
export class KidsService {
URL="https://localhost:44397/api/kids/";

  constructor(private http:HttpClient) { }

getAllׁׂׂׂׂׂׂ():Observable<kids[]>{
  return this.http.get<kids[]>(this.URL)
}
update(k: kids ):Observable<kids[]>{
  return this.http.put<kids[]>(this.URL,k)
}

add(k: kids):Observable<kids[]>{
  return this.http.post<kids[]>(this.URL,k)
}

delete(tz:number):Observable<kids[]>{
  return this.http.delete<kids[]>(this.URL+tz)
}
}