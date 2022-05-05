import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Images } from "../classes/Images";

@Injectable({
  providedIn: "root",
})
export class ImagesService {
  URL = "https://localhost:44397/api/Images/";
  URLBASE = "https://localhost:44397/api";
  constructor(private http: HttpClient) {}

  getImages(): Observable<Images[]> {
    return this.http.get<Images[]>(this.URL + "GetImages");
  }
  getById(id): Observable<Images> {
    return this.http.get<Images>(this.URL + "getById/"+ id);
  }
  GetAllByclassId(id: number): Observable<Images[]> {
    return this.http.get<Images[]>(this.URL + "GetAllByclassId/" + id);
  }
  update(ka: Images): Observable<boolean> {
    return this.http.put<boolean>(this.URL, ka);
  }
  add(ka: Images): Observable<boolean> {
    return this.http.post<boolean>(this.URL, ka);
  }
  delete(id: number): Observable<boolean> {
    return this.http.delete<boolean>(this.URL + "Delete/" + id);
  }

  AddUpdateImage(img) {
    let url = `${this.URL}AddUpdateImage`;
    return this.http.post(url, img);
  }
  uploadImage(imgId, image) {
    let formData: FormData = new FormData();
    formData.append('uploadFile', image, image.name);
    formData.append("RecoverLostId", imgId);
    const headers = new HttpHeaders();//.set('Content-Type', 'multipart/form-data');
    return this.http.post(`${this.URLBASE}/Helper/UploadImageTable/${imgId}/forms`, formData, { headers });
  }


}
