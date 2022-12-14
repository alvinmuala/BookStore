import { environment } from './../../environments/environment';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class BookClient {
  constructor(private http: HttpClient) {}

  getBookData(): Observable<any> {
    return this.http.get(environment.apiUrl + '/books');
  }
}