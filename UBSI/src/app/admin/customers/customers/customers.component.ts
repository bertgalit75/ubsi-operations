import { Component, OnInit } from '@angular/core';
import {
  NzTableQueryParams,
  NzTableSortFn,
  NzTableSortOrder,
} from 'ng-zorro-antd/table';
import { PageOptions } from 'src/app/core/pageoptions/PageOptions';
import { ICustomer } from 'src/app/models/customer.model';
import { CustomerService } from 'src/app/services/customer.service';

@Component({
  selector: 'app-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.less'],
})
export class CustomersComponent implements OnInit {
  constructor(private customerService: CustomerService) {}
  dataSet: ICustomer[];
  total: number;
  loading = true;
  pageSize = 10;
  pageIndex = 1;

  ngOnInit(): void {
    this.List(this.pageIndex, this.pageSize, null, null);
  }
  List(
    pageIndex: number,
    pageSize: number,
    sortField: string | null,
    sortOrder: string | null
  ): void {
    this.loading = true;
    this.customerService
      .getCustomers(pageIndex, pageSize, sortField, sortOrder)
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
    this.List(pageIndex, pageSize, sortField, sortOrder);
  }
}
