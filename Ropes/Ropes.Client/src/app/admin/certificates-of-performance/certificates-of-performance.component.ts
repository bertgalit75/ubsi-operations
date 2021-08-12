import { Component, OnInit } from '@angular/core';
import { NzTableQueryParams } from 'ng-zorro-antd/table';
import { ICertificateOfPerformance } from 'src/app/models/certificate-of-performace.model';
import { CertificateOfPerformanceService } from 'src/app/services/certificate-of-performance.service';

@Component({
  selector: 'app-certificates-of-performance',
  templateUrl: './certificates-of-performance.component.html',
  styleUrls: ['./certificates-of-performance.component.less'],
})
export class CertificatesOfPerformanceComponent implements OnInit {
  constructor(
    private certificateOfPerformanceService: CertificateOfPerformanceService
  ) {}

  dataSet: ICertificateOfPerformance[];
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
    this.certificateOfPerformanceService
      .getCPs(pageIndex, pageSize, sortField, sortOrder)
      .subscribe((data) => {
        console.log(data);
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
