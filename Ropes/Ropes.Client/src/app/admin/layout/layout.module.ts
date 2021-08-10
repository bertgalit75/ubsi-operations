import { NgModule } from '@angular/core';
import { MainComponent } from './main/main.component';
import { SharedModule } from 'src/app/shared/shared.module';
import { SidebarComponent } from './sidebar/sidebar.component';

@NgModule({
  declarations: [MainComponent, SidebarComponent],
  imports: [SharedModule],
})
export class LayoutModule {}
