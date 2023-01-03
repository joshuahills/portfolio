import { Subscription } from 'rxjs';
import { ErrorData } from './../models/error-data.model';
import { ActivatedRoute } from '@angular/router';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-error-page',
  template: `
    <div class="d-flex flex-column align-items-center justify-content-center">
      <h1>{{errorData?.code}}</h1>
      <p>{{errorData?.message}}</p>
      <button mat-raised-button color="primary" routerLink="">
        <mat-icon fontIcon="home"></mat-icon>
        Back to home
      </button>
    </div>`,
  styles: [`
    h1 {
      font-size: 12em;
    }
  `]
})
export class ErrorPageComponent implements OnInit {
  errorData: ErrorData | undefined;
  subs: Subscription = new Subscription();

  constructor(private route: ActivatedRoute) {}

  ngOnInit(): void {
    this.subs.add(this.route.data.subscribe(data => this.errorData = data as ErrorData));
  }
}
