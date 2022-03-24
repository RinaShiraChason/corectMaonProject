import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { HttpClient } from "@angular/common/http";
import { Kids } from "../classes/Kids";

@Injectable({
  providedIn: "root",
})
export class KidsService {
  getHistoryKidsData(kidId: any, monthSelected: number, yearSelected: number) {
    var urlData = this.URL + "getHistoryKidsData/" + kidId + "/"+ monthSelected + "/"+ yearSelected;

    return this.http.get<Kids>(urlData);
  }
  URL = "https://localhost:44397/api/Kids/";

  constructor(private http: HttpClient) {}

  getAllׁׂׂׂׂׂׂ(): Observable<Kids[]> {
    return this.http.get<Kids[]>(this.URL);
  }
  getKidsByTeacherׁׂׂׂׂׂׂ(teacherId: number): Observable<Kids[]> {
    var urlData = this.URL + "getKidsByTeachID/" + teacherId + "";

    return this.http.get<Kids[]>(urlData);
  }
  getKidsByClass(classId: number): Observable<Kids[]> {
    var urlData = this.URL + "getKidsByClassID/" + classId + "";

    return this.http.get<Kids[]>(urlData);
  }
  GetTodayKidsWithAttendenc(cId: number): Observable<Kids[]> {
    var urlData = this.URL + "GetTodayKidsWithAttendenc/" + cId + "";

    return this.http.get<Kids[]>(urlData);
  }
  GetTodayKidsData(cId: number): Observable<Kids[]> {
    var urlData = this.URL + "GetTodayKidsData/" + cId + "";
    return this.http.get<Kids[]>(urlData);
  }

  
  GetTodayKidsWithDayCare(cId: number): Observable<Kids[]> {
    var urlData = this.URL + "GetTodayKidsWithDayCare/" + cId + "";

    return this.http.get<Kids[]>(urlData);
  }
  update(k: Kids): Observable<Kids[]> {
    return this.http.put<Kids[]>(this.URL, k);
  }
  addUpdateKid(k: Kids): Observable<Kids> {
    return this.http.post<Kids>(this.URL + 'AddUpdateKid', k);
  }
  add(k: Kids): Observable<Kids[]> {
    k.kidId  = Number(k.kidId );
    k.parentId  = Number(k.parentId );
    debugger;
    return this.http.post<Kids[]>(this.URL, k);
  }

  delete(tz: number): Observable<Kids[]> {
    return this.http.delete<Kids[]>(this.URL + tz);
  }
}
