import { environment } from './../../environments/environment.prod';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

export class ApiBaseService {
  baseUrl: string;

  constructor(private http: HttpClient, controller: string) {
    this.baseUrl = `${environment.apiUrl}/${controller}`;
  }

  get<T>(id?: number): Observable<T> {
    const url = id ? `${this.baseUrl}/${id}` : this.baseUrl;
    return this.http.get<T>(url);
  }

  // post<T>(url: string, data: any, options?: any): Observable<T> {
  //   return this.http.post(url, data, options);
  // }

  // put<T>(url: string, data: any, options?: any): Observable<T> {
  //   return this.http.put(url, data, options);
  // }

  // delete(url: string, options?: any): Observable<T> {
  //   return this.http.delete(url, options);
  // }

}
