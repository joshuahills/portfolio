import { RoleGuard } from './../shared/guards/role.guard';
import { MsalGuard } from '@azure/msal-angular';
import { BlogAdminComponent } from './../blog-admin/blog-admin/blog-admin.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';

import { BlogPostListComponent } from './blog-post-list/blog-post-list.component';
import { BlogPostComponent } from './blog-post/blog-post.component';
import { BlogComponent } from './blog/blog.component';
import { AppRoles } from '../models';

const routes: Routes = [
  { 
    path: '', component: BlogComponent, children: [
      {
        path: ':id/edit',
        component: BlogAdminComponent,
        // MsalGuard checks we're signed into AD configured in AppModule, RoleGuard checks we have the requiredRole in the data object.
        canActivate: [MsalGuard, RoleGuard],
        data: { requiredRole: AppRoles.Author },
        loadChildren: () => import('../blog-admin/blog-admin.module').then(m => m.BlogAdminModule)
      },
      { path: ':id', component: BlogPostComponent },
      { path: '', component: BlogPostListComponent, title: 'Latest Posts | Josh Hills | Blog' },
    ],
  },
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
  ],
  exports: [
    RouterModule,
  ]
})
export class BlogRoutingModule { }
