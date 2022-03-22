import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Images } from "../classes/Images";

@Injectable({
  providedIn: "root",
})
export class ImagesService {
  URL = "https://localhost:44397/api/Images/";

  constructor(private http: HttpClient) {}

  getImages(): Observable<Images[]> {
    return this.http.get<Images[]>(this.URL + "GetImages");
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
    return this.http.delete<boolean>(this.URL + id);
  }
}
