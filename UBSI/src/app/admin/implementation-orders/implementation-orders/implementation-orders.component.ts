import { Component, OnInit } from '@angular/core';
import { NzTableQueryParams } from 'ng-zorro-antd/table';
import { IImplementationOrder } from 'src/app/models/implementation-order.model';
import { ImplementationOrderService } from 'src/app/services/implementation-order.service';

@Component({
  selector: 'app-implementation-orders',
  templateUrl: './implementation-orders.component.html',
  styleUrls: ['./implementation-orders.component.less'],
})
export class ImplementationOrdersComponent implements OnInit {
  constructor(private implementationOrderService: ImplementationOrderService) {}
  dataSet: IImplementationOrder[];

  total: number;
  loading = true;
  pageSize = 10;
  pageIndex = 1;
  ngOnInit(): void {
    this.list(this.pageIndex, this.pageSize, null, null);
  }
  list(
    pageIndex: number,
    pageSize: number,
    sortField: string | null,
    sortOrder: string | null
  ): void {
    this.loading = true;
    this.implementationOrderService
      .getImplementationOrder(pageIndex, pageSize, sortField, sortOrder)
      .subscribe((data) => {
        this.loading = false;
        this.total = data.totalCount; // mock the total data here
        this.dataSet = data.items;
      });
  }
  onQueryParamsChange(params: NzTableQueryParams): void {
    const { pageSize, pageIndex, sort, filter } = params;
    const currentSort = sort.find((item) => item.value !== null);
    const sortField = (currentSort && currentSort.key) || null;
    const sortOrder = (currentSort && currentSort.value) || null;
    this.list(pageIndex - 1, pageSize, sortField, sortOrder);
  }
}
