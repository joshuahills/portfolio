import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HasAppRoleDirective } from './directives/has-app-role.directive';

@NgModule({
  declarations: [
    HasAppRoleDirective,
  ],
  imports: [
    CommonModule,
  ],
  exports: [
    HasAppRoleDirective,
  ]
})
export class SharedModule { }
