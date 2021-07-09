import { NgModule } from '@angular/core';
import { AdminRoutingModule } from './admin-routing.module';
import { LayoutModule } from 'src/app/admin/layout/layout.module';
import { SharedModule } from 'src/app/shared/shared.module';
import { ImplementationOrdersComponent } from './implementation-orders/implementation-orders/implementation-orders.component';
import { NewImplementationOrderComponent } from './implementation-orders/new-implementation-order/new-implementation-order.component';
import { ViewImplementationOrderComponent } from './implementation-orders/view-implementation-order/view-implementation-order.component';
import { CustomersComponent } from './customers/customers/customers.component';
import { ViewCustomerComponent } from './customers/view-customer/view-customer.component';
import { NewAgencyComponent } from './agencies/new-agency/new-agency.component';
import { MediaAgenciesComponent } from './media-agencies/media-agencies/media-agencies.component';
import { NewMediaAgencyComponent } from './media-agencies/new-media-agency/new-media-agency.component';

@NgModule({
  declarations: [
    ImplementationOrdersComponent,
    NewImplementationOrderComponent,
    ViewImplementationOrderComponent,
    CustomersComponent,
    ViewCustomerComponent,
    NewAgencyComponent,
    MediaAgenciesComponent,
    NewMediaAgencyComponent,
  ],
  imports: [SharedModule, LayoutModule, AdminRoutingModule],
})
export class AdminModule {}
