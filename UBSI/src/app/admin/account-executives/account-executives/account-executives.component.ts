import { Component, OnInit } from '@angular/core';
import { NzTableQueryParams } from 'ng-zorro-antd/table';
import { IAccountExecutive } from 'src/app/models/account-executive.model';
import { AccountExecutiveService } from 'src/app/services/account-executive.service';

@Component({
  selector: 'app-account-executives',
  templateUrl: './account-executives.component.html',
  styleUrls: ['./account-executives.component.less'],
})
export class AccountExecutivesComponent implements OnInit {
  constructor(private accountExecutiveService: AccountExecutiveService) {}

  dataSet: IAccountExecutive[];
  total: number;
  loading = true;
  pageSize = 10;
  pageIndex = 0;

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
    this.accountExecutiveService
      .list(pageIndex, pageSize, sortField, sortOrder)
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
