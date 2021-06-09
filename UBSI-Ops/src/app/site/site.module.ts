import { NgModule } from "@angular/core";
import { MaterialModule } from "../shared/angular-material.module";
import { SharedModule } from "../shared/shared.module";
import { LoginComponent } from "./login/login.component";
import { SiteRoutingModule } from "./site-routing.module";

import { SiteComponent } from "./site/site.component";
import { ForgotPasswordComponent } from './forgot-password/forgot-password.component';

@NgModule({
  declarations: [LoginComponent, SiteComponent, ForgotPasswordComponent],
  imports: [SiteRoutingModule, SharedModule,MaterialModule],
})
export class SiteModule {}
