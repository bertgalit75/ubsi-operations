import { NgModule } from '@angular/core';
import { AdminRoutingModule } from './admin-routing.module';
import { LayoutModule } from 'src/app/admin/layout/layout.module';
import { SharedModule } from 'src/app/shared/shared.module';
import { ImplementationOrdersComponent } from './implementation-orders/implementation-orders/implementation-orders.component';
import { NewImplementationOrderComponent } from './implementation-orders/new-implementation-order/new-implementation-order.component';
import { ViewImplementationOrderComponent } from './implementation-orders/view-implementation-order/view-implementation-order.component';
import { CustomersComponent } from './customers/customers/customers.component';
import { ViewCustomerComponent } from './customers/view-customer/view-customer.component';
import { NewAgenciesComponent } from './agencies/new-agencies/new-agencies.component';

@NgModule({
  declarations: [ImplementationOrdersComponent, NewImplementationOrderComponent, ViewImplementationOrderComponent, CustomersComponent, ViewCustomerComponent, NewAgenciesComponent],
  imports: [SharedModule, LayoutModule, AdminRoutingModule],
})
export class AdminModule {}
