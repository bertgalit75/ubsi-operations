import { Component, OnInit } from '@angular/core';
import { NzTableQueryParams } from 'ng-zorro-antd/table';
import { IMediaAgency } from 'src/app/models/media-agency.model';
import { AgencyService } from 'src/app/services/agency.service';

@Component({
  selector: 'app-agencies',
  templateUrl: './agencies.component.html',
  styleUrls: ['./agencies.component.less'],
})
export class AgenciesComponent implements OnInit {
  dataSet: IMediaAgency[];

  total: number;
  loading = true;
  pageSize = 10;
  pageIndex = 0;

  constructor(private agencyService: AgencyService) {}

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
    this.agencyService
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
    this.list(pageIndex, pageSize, sortField, sortOrder);
  }
}
