import { MsalService, MsalBroadcastService } from '@azure/msal-angular';
import { Injectable } from '@angular/core';
import { filter } from 'rxjs';
import { InteractionStatus } from '@azure/msal-browser';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private msalService: MsalService,
    private msalBroadcastService: MsalBroadcastService,
  ) {
    this.msalBroadcastService.inProgress$
      .pipe(
        filter((status: InteractionStatus) => status === InteractionStatus.None)
      )
      .subscribe(() => {
        this.checkAndSetActiveAccount();
      })
  }

  checkAndSetActiveAccount(){
    const activeAccount = this.msalService.instance.getActiveAccount();

    if (!activeAccount && this.msalService.instance.getAllAccounts().length > 0) {
      let accounts = this.msalService.instance.getAllAccounts();
      this.msalService.instance.setActiveAccount(accounts[0]);
    }
  }

}
