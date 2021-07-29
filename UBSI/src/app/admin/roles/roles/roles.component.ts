import { Component, OnInit } from '@angular/core';
import { NzTableQueryParams } from 'ng-zorro-antd/table';
import { IRole } from 'src/app/models/role.model';
import { RoleService } from 'src/app/services/role.service';

@Component({
  selector: 'app-roles',
  templateUrl: './roles.component.html',
  styleUrls: ['./roles.component.less'],
})
export class RolesComponent implements OnInit {
  constructor(private roleService: RoleService) {}

  dataSet: IRole[];

  total: number;
  loading = true;
  pageSize = 10;
  pageIndex = 0;
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
    this.roleService
      .getRoles(pageIndex, pageSize, sortField, sortOrder)
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
