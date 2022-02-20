import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http'
import { person } from '../classes/person';

@Injectable({
  providedIn: 'root'
})
export class PersonService {
URL="https://localhost:44397/api/person/";

  constructor(private http:HttpClient) { }

  getAllׁׂׂׂׂׂׂ():Observable<person[]>{
    return this.http.get<person[]>(this.URL)
  }
  update(pr: person ):Observable<person[]>{
    return this.http.put<person[]>(this.URL,pr)
  }
  
  add(pr: person):Observable<person[]>{
    return this.http.post<person[]>(this.URL,pr)
  }
  
  delete(PersonTz:number):Observable<person[]>{
    return this.http.delete<person[]>(this.URL+PersonTz)
  }
}
