import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http'
import { typeClass } from '../classes/typeClass';

@Injectable({
  providedIn: 'root'
})
export class TypeClassService {
URL="https://localhost:44397/api/typeClass/";

  constructor(private http:HttpClient) { }

  getAllׁׂׂׂׂׂׂ():Observable<typeClass[]>{
    return this.http.get<typeClass[]>(this.URL)
  }
  update(k: typeClass ):Observable<typeClass[]>{
    return this.http.put<typeClass[]>(this.URL,k)
  }
  
  add(k: typeClass):Observable<typeClass[]>{
    return this.http.post<typeClass[]>(this.URL,k)
  }
  
  delete(IdTypeClass:number):Observable<typeClass[]>{
    return this.http.delete<typeClass[]>(this.URL+IdTypeClass)
  }
}
