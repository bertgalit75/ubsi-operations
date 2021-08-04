import { Component, OnInit } from '@angular/core';
import { NzTableQueryParams } from 'ng-zorro-antd/table';
import { IBillingStatement } from 'src/app/models/billing-statement.model';
import { BillingStatementService } from 'src/app/services/billing-statement.service';

@Component({
  selector: 'app-billing-statements',
  templateUrl: './billing-statements.component.html',
  styleUrls: ['./billing-statements.component.less'],
})
export class BillingStatementsComponent implements OnInit {
  dataSet: IBillingStatement[];
  total: number;
  loading = true;
  pageSize = 10;
  pageIndex = 0;
  constructor(private billingStatementService: BillingStatementService) {}
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
    this.billingStatementService
      .getBillingStatements(pageIndex, pageSize, sortField, sortOrder)
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
    this.List(pageIndex - 1, pageSize, sortField, sortOrder);
  }
}
