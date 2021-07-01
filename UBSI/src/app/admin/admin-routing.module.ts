import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ImplementationOrdersComponent } from 'src/app/admin/implementation-orders/implementation-orders/implementation-orders.component';
import { NewImplementationOrderComponent } from 'src/app/admin/implementation-orders/new-implementation-order/new-implementation-order.component';
import { ViewImplementationOrderComponent } from 'src/app/admin/implementation-orders/view-implementation-order/view-implementation-order.component';
import { MainComponent } from 'src/app/admin/layout/main/main.component';
import { CustomersComponent } from './customers/customers/customers.component';
import { ViewCustomerComponent } from './customers/view-customer/view-customer.component';

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
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class AdminRoutingModule {}
