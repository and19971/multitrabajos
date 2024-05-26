import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class ExternalServiceService {
  private apiUrlCountry = 'https://restcountries.com/v3.1/all?fields=name,flags';
  constructor(private http: HttpClient) { }
  getData(): Observable<any> {
    return this.http.get<any>(this.apiUrlCountry);
  }
}
