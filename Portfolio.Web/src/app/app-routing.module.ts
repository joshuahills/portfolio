import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { LoginComponent } from './auth/login/login.component';
import { BlogComponent } from './blog/blog/blog.component';
import { ErrorPageComponent } from './error-page/error-page.component';

const routes: Routes = [
  { path: 'login', component: LoginComponent, title: 'Login - Josh Hills' },
  { path: 'blog', component: BlogComponent, loadChildren: () => import('./blog/blog.module').then(m => m.BlogModule) },
  { path: '404', component: ErrorPageComponent, data: { code: 404, message: 'Not Found' }, title: 'Not Found - Josh Hills' },
  { path: '', redirectTo: 'blog', pathMatch: 'full', title: 'Josh Hills | Portfolio' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
