import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './site/login/login.component';

const routes: Routes = [
  {
    path: "",
    redirectTo: "site",
    pathMatch: "full",
  },
  {
    path: "site",
    loadChildren: () => import("./site/site.module").then((m) => m.SiteModule),
  },
  {
    path: "admin",
    loadChildren: () => import("./admin/admin.module").then((m) => m.AdminModule),
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
