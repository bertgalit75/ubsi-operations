import { Component, OnInit } from '@angular/core';
import { NzTableQueryParams } from 'ng-zorro-antd/table';
import { IUser } from 'src/app/models/user.model';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.less'],
})
export class UsersComponent implements OnInit {
  constructor(private userService: UserService) {}

  dataSet: IUser[];
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
    this.userService
      .getUsers(pageIndex, pageSize, sortField, sortOrder)
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
    this.List(pageIndex, pageSize, sortField, sortOrder);
  }
}
