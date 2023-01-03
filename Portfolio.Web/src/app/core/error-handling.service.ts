import { HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class ErrorHandlingService {

  constructor(private router: Router) { }

  handleError(error: HttpErrorResponse): void {
    switch (error.status) {
      case 404:
        this.router.navigate(['/404']);
        break;
    }
  }
}
