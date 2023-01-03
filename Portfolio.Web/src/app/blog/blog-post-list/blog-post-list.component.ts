import { BlogApiService } from './../blog-api.service';
import { Component, OnInit } from '@angular/core';

import { BlogPost } from '../../models';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-blog-post-list',
  templateUrl: './blog-post-list.component.html',
  styles: [
  ]
})
export class BlogPostListComponent implements OnInit {
  posts$: Observable<BlogPost[]> = new Observable();

  constructor(private blogApiService: BlogApiService) {}

  ngOnInit(): void {
    this.posts$ = this.blogApiService.getAllPosts();
  }
}
