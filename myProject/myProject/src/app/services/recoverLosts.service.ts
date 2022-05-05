import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { RecoverLosts } from "../classes/RecoverLosts";

@Injectable({
  providedIn: "root",
})
export class RecoverLostsService {
  URL = "https://localhost:44397/api/RecoverLosts/";
  URLBASE = "https://localhost:44397/api";

  constructor(private http: HttpClient) {}

  getAllׁׂׂׂׂׂׂ(): Observable<RecoverLosts[]> {
    let url = `${this.URL}GetAll`;
    return this.http.get<RecoverLosts[]>(url);
  }
  getById(id){
    let url = `${this.URL}GetById/${id}`;
    return this.http.get<RecoverLosts>(url);
  }
  update(p: RecoverLosts): Observable<RecoverLosts[]> {
    return this.http.put<RecoverLosts[]>(this.URL, p);
  }

  add(p: RecoverLosts): Observable<RecoverLosts[]> {
    return this.http.post<RecoverLosts[]>(this.URL, p);
  }

  delete(id : number): Observable<boolean> {
    return this.http.delete<boolean>(this.URL  + "delete/"+ id );
  }

  AddUpdateRecoverLost(rec) {
    let url = `${this.URL}AddUpdateRecoverLost`;
    return this.http.post(url, rec);
  }
  uploadImage(recId, image) {
    let formData: FormData = new FormData();
    formData.append('uploadFile', image, image.name);
    formData.append("RecoverLostId", recId);
    const headers = new HttpHeaders();//.set('Content-Type', 'multipart/form-data');
    return this.http.post(`${this.URLBASE}/Helper/UploadImage/${recId}/forms`, formData, { headers });
  }
}
