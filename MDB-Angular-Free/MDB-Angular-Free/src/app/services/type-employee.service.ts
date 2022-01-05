import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http'
import { typeEmployee } from '../classes/typeEmployee';

@Injectable({
  providedIn: 'root'
})
export class TypeEmployeeService {
URL="https://localhost:44397/api/typeEmployee/";

  constructor(private http:HttpClient) { }

getAllׁׂׂׂׂׂׂ():Observable<typeEmployee[]>{
  return this.http.get<typeEmployee[]>(this.URL)
}
update(k: typeEmployee ):Observable<typeEmployee[]>{
  return this.http.put<typeEmployee[]>(this.URL,k)
}

add(k: typeEmployee):Observable<typeEmployee[]>{
  return this.http.post<typeEmployee[]>(this.URL,k)
}

delete(IdTypeEmp:number):Observable<typeEmployee[]>{
  return this.http.delete<typeEmployee[]>(this.URL+IdTypeEmp)
}
}
