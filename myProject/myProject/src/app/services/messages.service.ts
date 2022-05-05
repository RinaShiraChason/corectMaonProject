import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Messages } from "../classes/Messages";

@Injectable({
  providedIn: "root",
})
export class MessagesService {
  URL = "https://localhost:44397/api/Messages/";

  constructor(private http: HttpClient) { }

  getMessagesByTo(id: number, kidId: number): Observable<Messages[]> {
    return this.http.get<Messages[]>(this.URL + "GetMessagesByTo/" + id + "/" + kidId);
  }
  getMessagesByFrom(id: number, kidId: number): Observable<Messages[]> {
    return this.http.get<Messages[]>(this.URL + "GetMessagesByFrom/" + id + "/" + kidId);
  }
  getMessagesNews(): Observable<Messages[]> {
    return this.http.get<Messages[]>(this.URL + "getMessagesNews");
  }
  saveNews(news): Observable<Messages[]> {
    return this.http.post<Messages[]>(this.URL + "saveNews", news);
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
    return this.http.delete<boolean>(this.URL + 'Delete/' + id);
  }
}
