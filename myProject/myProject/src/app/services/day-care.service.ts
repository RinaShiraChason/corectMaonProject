import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http'
import { DayCare } from '../classes/DayCare';

@Injectable({
  providedIn: 'root'
})
export class DayCareService {
  URL = "https://localhost:44397/api/DayCare/";

  constructor(private http: HttpClient) { }

  getDayCareByKids(id: number): Observable<DayCare> {
    return this.http.get<DayCare>(this.URL + "GetDayCareByKids/" + id)
  }

  update(dc: DayCare): Observable<DayCare[]> {
    return this.http.put<DayCare[]>(this.URL, dc)
  }

  add(dc: DayCare): Observable<DayCare[]> {
    return this.http.post<DayCare[]>(this.URL, dc)
  }
  addUpdateKidCare(dc: DayCare): Observable<DayCare> {
    return this.http.post<DayCare>(this.URL + 'addUpdateKidCare', dc)
  }

  delete(idDayCare: number): Observable<DayCare[]> {
    return this.http.delete<DayCare[]>(this.URL + idDayCare)
  }
}
