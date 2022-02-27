import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http'
import { DayCare } from '../classes/DayCare';

@Injectable({
  providedIn: 'root'
})
export class DayCareService {
URL="https://localhost:44397/api/DayCare/";

  constructor(private http:HttpClient) { }

  getAllׁׂׂׂׂׂׂ():Observable<DayCare[]>{
    return this.http.get<DayCare[]>(this.URL)
  }
  update(dc: DayCare ):Observable<DayCare[]>{
    return this.http.put<DayCare[]>(this.URL,dc)
  }
  
  add(dc: DayCare):Observable<DayCare[]>{
    return this.http.post<DayCare[]>(this.URL,dc)
  }
  
  delete(IdDayCare:number):Observable<DayCare[]>{
    return this.http.delete<DayCare[]>(this.URL+IdDayCare)
  }
}
