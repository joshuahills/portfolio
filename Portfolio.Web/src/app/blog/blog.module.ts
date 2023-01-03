import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { SharedModule } from './../shared/shared.module';
import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { MatCardModule } from '@angular/material/card';

import { BlogPostComponent } from './blog-post/blog-post.component';
import { BlogComponent } from './blog/blog.component';
import { BlogRoutingModule } from './blog-routing.module';
import { BlogPostListComponent } from './blog-post-list/blog-post-list.component';

@NgModule({
  declarations: [
    BlogComponent,
    BlogPostComponent,
    BlogPostListComponent,
  ],
  imports: [
    CommonModule,
    MatCardModule,
    BlogRoutingModule,
    SharedModule,
    MatButtonModule,
    MatIconModule,
  ]
})
export class BlogModule { }
