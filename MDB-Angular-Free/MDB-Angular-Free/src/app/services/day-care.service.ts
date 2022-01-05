import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http'
import { dayCare } from '../classes/dayCare';

@Injectable({
  providedIn: 'root'
})
export class DayCareService {
URL="https://localhost:44397/api/dayCare/";

  constructor(private http:HttpClient) { }

  getAllׁׂׂׂׂׂׂ():Observable<dayCare[]>{
    return this.http.get<dayCare[]>(this.URL)
  }
  update(dc: dayCare ):Observable<dayCare[]>{
    return this.http.put<dayCare[]>(this.URL,dc)
  }
  
  add(dc: dayCare):Observable<dayCare[]>{
    return this.http.post<dayCare[]>(this.URL,dc)
  }
  
  delete(IdDayCare:number):Observable<dayCare[]>{
    return this.http.delete<dayCare[]>(this.URL+IdDayCare)
  }
}
