import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { ForgotPasswordComponent } from "./forgot-password/forgot-password.component";
import { LoginComponent } from "./login/login.component";
import { SiteComponent } from "./site/site.component";

const routes: Routes = [
    {
      path: "",
      component: SiteComponent,
      children: [
        {
          path: "",
          redirectTo: "login",
          pathMatch: "full",
        },
        {
          path: "login",
          component: LoginComponent,
        },
        {
          path: "forgot",
          component: ForgotPasswordComponent,
        },
      
      ],
    },
  ];
@NgModule({
imports: [RouterModule.forChild(routes)],
exports: [RouterModule],
})
export class SiteRoutingModule{
    
}