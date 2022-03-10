import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Messages } from '../classes/Messages';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ParentsMessgesService {
 
URL ="https://localhost:44397/api/parentsMessages/";

  constructor(private http: HttpClient) { }

  getAllׁׂׂׂׂׂׂ(): Observable<Messages[]> {

    return this.http.get<Messages[]>(this.URL)
  }
  getMessgesByTeacherׁׂׂׂׂׂׂ(teacherId: number): Observable<Messages[]> {
    var urlData = this.URL + "getKidsByTeachID/" + teacherId +"";
  
      return this.http.get<Messages[]>(urlData);
    }
  update(m: Messages): Observable<Messages[]> {
    return this.http.put<Messages[]>(this.URL, m)
  }

  add(m: Messages): Observable<Messages[]> {
    debugger
    return this.http.post<Messages[]>(this.URL, m)
  }

  delete(messageId: number): Observable<Messages[]> {
    return this.http.delete<Messages[]>(this.URL + messageId)
  }
}
