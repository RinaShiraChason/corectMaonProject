import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { HttpClient } from "@angular/common/http";
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

  delete(ParentId: number): Observable<RecoverLosts[]> {
    return this.http.delete<RecoverLosts[]>(this.URL + ParentId);
  }

  AddUpdateRecoverLost(rec) {
    let url = `${this.URL}AddUpdateRecoverLost`;
    return this.http.post(url, rec);
  }
  uploadImage(recId, image) {
    let formData: FormData = new FormData();
    formData.append("file", image);
    formData.append("RecoverLostId", recId);
    return this.http.post(`${this.URLBASE}/Helper/UploadImage`, formData);
  }
}
