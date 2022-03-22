import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http'
import { User } from '../classes/Users';

@Injectable({
  providedIn: 'root'
})
export class UserService {
URL="https://localhost:44397/api/User/";

  constructor(private http:HttpClient) { }

  getAllׁׂׂׂׂׂׂ():Observable<User[]>{
    return this.http.get<User[]>(this.URL)
  }
  update(pr: User ):Observable<User[]>{
    return this.http.put<User[]>(this.URL,pr)
  }
  
  add(pr: User):Observable<User[]>{
    return this.http.post<User[]>(this.URL,pr)
  }
  
  delete(userTz:number):Observable<User[]>{
    return this.http.delete<User[]>(this.URL+userTz)
  }
}
