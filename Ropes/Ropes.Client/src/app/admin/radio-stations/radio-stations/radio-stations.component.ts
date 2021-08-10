import { Component, OnInit } from '@angular/core';
import { NzTableQueryParams } from 'ng-zorro-antd/table';
import { IRadioStation } from 'src/app/models/radio-station.model';
import { RadioStationService } from 'src/app/services/radio-station.service';

@Component({
  selector: 'app-radio-stations',
  templateUrl: './radio-stations.component.html',
  styleUrls: ['./radio-stations.component.less'],
})
export class RadioStationsComponent implements OnInit {
  constructor(private radioStationService: RadioStationService) {}

  dataSet: IRadioStation[];
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
    this.radioStationService
      .getRadioStations(pageIndex, pageSize, sortField, sortOrder)
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
