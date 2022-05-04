import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Messages } from "../classes/Messages";

@Injectable({
  providedIn: "root",
})
export class MessagesService {
  URL = "https://localhost:44397/api/Messages/";

  constructor(private http: HttpClient) {}

  getMessagesByTo(id: number): Observable<Messages[]> {
    return this.http.get<Messages[]>(this.URL + "GetMessagesByTo/" + id);
  }
  getMessagesByFrom(id: number): Observable<Messages[]> {
    return this.http.get<Messages[]>(this.URL + "GetMessagesByFrom/" + id);
  }
  update(ka: Messages): Observable<boolean> {
    return this.http.put<boolean>(this.URL, ka);
  }
  add(ka: Messages): Observable<boolean> {
    return this.http.post<boolean>(this.URL, ka);
  }
  addUpdateMessage(ka: Messages): Observable<boolean> {
    return this.http.post<boolean>(this.URL + 'AddUpdateMessage', ka);
  }
  delete(id: number): Observable<boolean> {
    return this.http.delete<boolean>(this.URL + id);
  }
}
