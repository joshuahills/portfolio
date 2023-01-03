import { ErrorHandlingService, TitleService } from 'src/app/core';
import { BlogApiService } from './../blog-api.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { switchMap, Observable, catchError, EMPTY, tap } from 'rxjs';
import { BlogPost } from 'src/app/models';

@Component({
  selector: 'app-blog-post',
  templateUrl: './blog-post.component.html',
})
export class BlogPostComponent implements OnInit {
  post$: Observable<BlogPost | undefined> = new Observable();

  constructor(private route: ActivatedRoute,
    private blogApiService: BlogApiService,
    private errorHandling: ErrorHandlingService,
    private titleService: TitleService,
  ) {}

  ngOnInit(): void {
    this.post$ = this.route.params.pipe(
      switchMap(params => this.blogApiService.getPostById(params['id'])),
      tap(post => this.titleService.setTitle(post.title, 'Blog')),
      catchError(err => {
        this.errorHandling.handleError(err);
        return EMPTY;
      })
    )
  }
}
