import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { ExternalData } from "../classes/ExternalData";

@Injectable({
  providedIn: "root",
})
export class ExternalDataService {
  URL = "https://localhost:44397/api/ExternalData/";

  constructor(private http: HttpClient) { }

  getExternalData(): Observable<ExternalData[]> {
    return this.http.get<ExternalData[]>(this.URL + "GetExternalData");
  }
  GetAllByclassId(id: number): Observable<ExternalData[]> {
    return this.http.get<ExternalData[]>(this.URL + "GetAllByClassId/" + id);
  }
  update(ka: ExternalData): Observable<boolean> {
    return this.http.put<boolean>(this.URL, ka);
  }
  AddUpdateExtData(ed: ExternalData): Observable<boolean> {
    return this.http.post<boolean>(this.URL + 'AddUpdateExtData', ed);
  }
  add(ka: ExternalData): Observable<boolean> {
    return this.http.post<boolean>(this.URL, ka);
  }
  delete(id: number): Observable<boolean> {
    return this.http.delete<boolean>(this.URL + id);
  }
}
