import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http'
import { placementOfATeacher } from '../classes/PlacementOfATeacher';

@Injectable({
  providedIn: 'root'
})
export class PlacementOfATeacherService {
  URL="https://localhost:44397/api/placementOfATeacher/";

  constructor(private http:HttpClient) { }

getAllׁׂׂׂׂׂׂ():Observable<placementOfATeacher[]>{
  return this.http.get<placementOfATeacher[]>(this.URL)
}
update(pot: placementOfATeacher ):Observable<placementOfATeacher[]>{
  return this.http.put<placementOfATeacher[]>(this.URL,pot)
}

add(pot: placementOfATeacher):Observable<placementOfATeacher[]>{
  return this.http.post<placementOfATeacher[]>(this.URL,pot)
}

delete(IdPlacementOfATeacher:number):Observable<placementOfATeacher[]>{
  return this.http.delete<placementOfATeacher[]>(this.URL+IdPlacementOfATeacher)
}
}
