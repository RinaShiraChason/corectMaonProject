import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http'
import { kidsAttendance } from '../classes/KidsAttendance';

@Injectable({
  providedIn: 'root'
})
export class KidsAttendanceService {
URL="https://localhost:44397/api/kidsAttendance/";

  constructor(private http:HttpClient) { }

  getAllׁׂׂׂׂׂׂ():Observable<kidsAttendance[]>{
    return this.http.get<kidsAttendance[]>(this.URL)
  }
  update(ka: kidsAttendance ):Observable<kidsAttendance[]>{
    return this.http.put<kidsAttendance[]>(this.URL,ka)
  }
  
  add(ka: kidsAttendance):Observable<kidsAttendance[]>{
    return this.http.post<kidsAttendance[]>(this.URL,ka)
  }
  
  delete(AttendanceId:number):Observable<kidsAttendance[]>{
    return this.http.delete<kidsAttendance[]>(this.URL+AttendanceId)
  }
}
