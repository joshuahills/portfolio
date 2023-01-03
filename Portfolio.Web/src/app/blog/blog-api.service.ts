import { ErrorHandlingService } from './../core/error-handling.service';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { ApiBaseService } from './../core/api-base.service';
import { BlogPost } from '../models';

@Injectable({
  providedIn: 'root'
})
export class BlogApiService extends ApiBaseService {

  constructor(http: HttpClient) {
    super(http, 'posts');
  }

  getAllPosts(): Observable<BlogPost[]> {
    return this.get<BlogPost[]>()
  }

  getPostById(id: number): Observable<BlogPost> {
    return this.get<BlogPost>(id);
  }

}
