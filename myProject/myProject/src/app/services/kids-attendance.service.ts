import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http'
import { KidsAttendance } from '../classes/KidsAttendance';

@Injectable({
  providedIn: 'root'
})
export class KidsAttendanceService {
URL="https://localhost:44397/api/KidsAttendance/";

  constructor(private http:HttpClient) { }

  getAllׁׂׂׂׂׂׂ():Observable<KidsAttendance[]>{
    return this.http.get<KidsAttendance[]>(this.URL)
  }
  update(ka: KidsAttendance ):Observable<KidsAttendance[]>{
    return this.http.put<KidsAttendance[]>(this.URL,ka)
  }
  
  setKidAttendence(ka: KidsAttendance):Observable<KidsAttendance[]>{
    var urlData = this.URL + "setKidAttendence" ;

   
    return this.http.post<KidsAttendance[]>(urlData,ka)
  }
  
  delete(attendanceId :number):Observable<KidsAttendance[]>{
    return this.http.delete<KidsAttendance[]>(this.URL+attendanceId )
  }
}
