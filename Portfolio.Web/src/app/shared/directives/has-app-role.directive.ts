import { MsalBroadcastService, MsalService } from '@azure/msal-angular';
import { Directive, ElementRef, Input, TemplateRef, ViewContainerRef, OnInit } from '@angular/core';
import { filter, Subject, takeUntil } from 'rxjs';
import { InteractionStatus } from '@azure/msal-browser';

@Directive({
  selector: '[hasAppRole]'
})
export class HasAppRoleDirective implements OnInit {
  permission: string = '';

  private readonly destroying$: Subject<void> = new Subject<void>();
  
  constructor(
    private templateRef: TemplateRef<any>,
    private viewContainer: ViewContainerRef,
    private msalService: MsalService,
    private msalBroadcastService: MsalBroadcastService,
  ) { }

  ngOnInit(): void {
    this.msalBroadcastService.inProgress$
    .pipe(
      filter((status: InteractionStatus) => status === InteractionStatus.None),
      takeUntil(this.destroying$)
    )
    .subscribe(() => {
      this.checkAndSetActiveAccount();
    })
  }

  @Input()
  set hasAppRole(role: string) {
    this.permission = role;
    this.updateView();
  }

  private checkAndSetActiveAccount(){
    const activeAccount = this.msalService.instance.getActiveAccount();

    if (!activeAccount && this.msalService.instance.getAllAccounts().length > 0) {
      let accounts = this.msalService.instance.getAllAccounts();
      this.msalService.instance.setActiveAccount(accounts[0]);
    }
  }

  private updateView() {
    if (this.checkPermission()) {
        this.viewContainer.createEmbeddedView(this.templateRef);
    } else {
      this.viewContainer.clear();
    }
  }

  private checkPermission() {
    const activeAccount = this.msalService.instance.getActiveAccount();
    console.log("checking account", activeAccount)
    if (activeAccount && activeAccount.idTokenClaims?.roles?.includes(this.permission)) {
      return true;
    }

    return false;
  }

}
