import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http'
import { TypeClass } from '../classes/TypeClass';

@Injectable({
  providedIn: 'root'
})
export class TypeClassService {
URL="https://localhost:44397/api/Type_Class/";

  constructor(private http:HttpClient) { }

  getAllׁׂׂׂׂׂׂ():Observable<TypeClass[]>{
    return this.http.get<TypeClass[]>(this.URL)
  }
  update(k: TypeClass ):Observable<TypeClass[]>{
    return this.http.put<TypeClass[]>(this.URL,k)
  }
  
  add(k: TypeClass):Observable<TypeClass[]>{
    return this.http.post<TypeClass[]>(this.URL,k)
  }
  
  delete(idTypeClass:number):Observable<TypeClass[]>{
    return this.http.delete<TypeClass[]>(this.URL+idTypeClass)
  }
}
