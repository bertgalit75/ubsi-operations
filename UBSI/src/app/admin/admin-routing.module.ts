import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ImplementationOrdersComponent } from 'src/app/admin/implementation-orders/implementation-orders/implementation-orders.component';
import { NewImplementationOrderComponent } from 'src/app/admin/implementation-orders/new-implementation-order/new-implementation-order.component';
import { ViewImplementationOrderComponent } from 'src/app/admin/implementation-orders/view-implementation-order/view-implementation-order.component';
import { MainComponent } from 'src/app/admin/layout/main/main.component';

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
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class AdminRoutingModule {}
