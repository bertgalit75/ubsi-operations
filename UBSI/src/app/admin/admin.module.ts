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
import { AgenciesComponent } from './agencies/agencies/agencies.component';
import { AccountExecutivesComponent } from './account-executives/account-executives/account-executives.component';
import { UsersComponent } from './users/users/users.component';
import { NewRoleComponent } from './roles/new-role/new-role.component';
import { RolesComponent } from './roles/roles/roles.component';
import { RadioStationsComponent } from './radio-stations/radio-stations/radio-stations.component';
import { BillingStatementsComponent } from './billing-statements/billing-statements/billing-statements.component';

@NgModule({
  declarations: [
    ImplementationOrdersComponent,
    NewImplementationOrderComponent,
    ViewImplementationOrderComponent,
    CustomersComponent,
    ViewCustomerComponent,
    NewAgencyComponent,
    AgenciesComponent,
    AccountExecutivesComponent,
    RolesComponent,
    UsersComponent,
    NewRoleComponent,
    RadioStationsComponent,
    BillingStatementsComponent,
  ],
  imports: [SharedModule, LayoutModule, AdminRoutingModule],
})
export class AdminModule {}
