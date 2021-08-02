import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ImplementationOrdersComponent } from 'src/app/admin/implementation-orders/implementation-orders/implementation-orders.component';
import { NewImplementationOrderComponent } from 'src/app/admin/implementation-orders/new-implementation-order/new-implementation-order.component';
import { ViewImplementationOrderComponent } from 'src/app/admin/implementation-orders/view-implementation-order/view-implementation-order.component';
import { MainComponent } from 'src/app/admin/layout/main/main.component';
import { CustomersComponent } from './customers/customers/customers.component';
import { ViewCustomerComponent } from './customers/view-customer/view-customer.component';
import { NewAgencyComponent } from 'src/app/admin/agencies/new-agency/new-agency.component';
import { AgenciesComponent } from 'src/app/admin/agencies/agencies/agencies.component';
import { RolesComponent } from './roles/roles/roles.component';
import { AccountExecutivesComponent } from './account-executives/account-executives/account-executives.component';
import { UsersComponent } from './users/users/users.component';
import { NewRoleComponent } from './roles/new-role/new-role.component';
import { RadioStationsComponent } from './radio-stations/radio-stations/radio-stations.component';
import { BillingStatementsComponent } from './billing-statements/billing-statements/billing-statements.component';

const routes: Routes = [
  {
    path: '',
    component: MainComponent,
    children: [
      {
        path: 'implementation-orders',
        component: ImplementationOrdersComponent,
      },
      {
        path: 'implementation-orders/new',
        component: NewImplementationOrderComponent,
      },
      {
        path: 'implementation-orders/:code',
        component: ViewImplementationOrderComponent,
      },
      {
        path: 'customers',
        component: CustomersComponent,
      },
      {
        path: 'customers/:code',
        component: ViewCustomerComponent,
      },
      {
        path: 'roles',
        component: RolesComponent,
      },
      {
        path: 'roles/new',
        component: NewRoleComponent,
      },
      {
        path: 'agencies',
        component: AgenciesComponent,
      },
      {
        path: 'agencies/new',
        component: NewAgencyComponent,
      },
      {
        path: 'roles',
        component: RolesComponent,
      },
      {
        path: 'account-executives',
        component: AccountExecutivesComponent,
      },
      {
        path: 'users',
        component: UsersComponent,
      },
      {
        path: 'radio-stations',
        component: RadioStationsComponent,
      },
      {
        path: 'billing-statements',
        component: BillingStatementsComponent,
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class AdminRoutingModule {}
