import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http'
import { PlacementOfATeacher } from '../classes/PlacementOfATeacher';

@Injectable({
  providedIn: 'root'
})
export class PlacementOfATeacherService {
  URL="https://localhost:44397/api/PlacementOfATeacher/";

  constructor(private http:HttpClient) { }

getAllׁׂׂׂׂׂׂ():Observable<PlacementOfATeacher[]>{
  return this.http.get<PlacementOfATeacher[]>(this.URL)
}
update(pot: PlacementOfATeacher ):Observable<PlacementOfATeacher[]>{
  return this.http.put<PlacementOfATeacher[]>(this.URL,pot)
}

add(pot: PlacementOfATeacher):Observable<PlacementOfATeacher[]>{
  return this.http.post<PlacementOfATeacher[]>(this.URL,pot)
}

delete(IdPlacementOfATeacher:number):Observable<PlacementOfATeacher[]>{
  return this.http.delete<PlacementOfATeacher[]>(this.URL+IdPlacementOfATeacher)
}
}
