import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './login/login.component';
import { AdminRoutingModule } from '../admin/admin-routing.module';
import { LayoutModule } from '../admin/layout/layout.module';
import { SharedModule } from '../shared/shared.module';



@NgModule({
  declarations: [LoginComponent],
  imports: [SharedModule, LayoutModule, AdminRoutingModule]
})
export class SiteModule { }
