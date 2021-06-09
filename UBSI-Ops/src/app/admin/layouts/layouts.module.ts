import { NgModule } from '@angular/core';
import { SharedModule } from 'src/app/shared/shared.module';
import { MainComponent } from 'src/app/admin/layouts/main/main.component';
import { SidebarComponent } from 'src/app/admin/layouts/sidebar/sidebar.component';
import { SidenavComponent } from 'src/app/admin/layouts/sidenav/sidenav.component';
import { TopbarComponent } from 'src/app/admin/layouts/topbar/topbar.component';
import { MaterialModule } from 'src/app/shared/angular-material.module';

@NgModule({
  declarations: [
    MainComponent,
    SidebarComponent,
    SidenavComponent,
    TopbarComponent,
  ],
  imports: [SharedModule,MaterialModule],
})
export class LayoutsModule{}