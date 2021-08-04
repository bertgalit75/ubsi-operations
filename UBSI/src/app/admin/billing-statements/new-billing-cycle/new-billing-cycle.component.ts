import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import {
  NzDateMode,
  NzDatePickerComponent,
  NzDatePickerModule,
} from 'ng-zorro-antd/date-picker';
import { NzTableQueryParams } from 'ng-zorro-antd/table';
import { markAllAsDirty } from 'src/app/core/functions';
import { PageOptions } from 'src/app/core/pageoptions/PageOptions';
import { IImplementationOrder } from 'src/app/models/implementation-order.model';
import { ImplementationOrderService } from 'src/app/services/implementation-order.service';

@Component({
  selector: 'app-new-billing-cycle',
  templateUrl: './new-billing-cycle.component.html',
  styleUrls: ['./new-billing-cycle.component.less'],
})
export class NewBillingCycleComponent implements OnInit {
  constructor(
    private router: Router,
    private fb: FormBuilder,
    private implementationOrderService: ImplementationOrderService
  ) {}
  form: FormGroup = this.fb.group({
    year: [null, Validators.required],
    month: [null, Validators.required],
  });
  isSearching: boolean = false;

  displayIO: boolean = false;

  isSaving: boolean = false;

  total: number;
  loading = true;
  pageSize = 10;
  pageIndex = 0;

  sortField: string = null;
  sortOrder: string = null;

  dataSet: IImplementationOrder[];
  months = [
    { id: 1, name: 'January' },
    { id: 2, name: 'February' },
    { id: 3, name: 'March' },
    { id: 4, name: 'April' },
    { id: 5, name: 'May' },
    { id: 6, name: 'June' },
    { id: 7, name: 'July' },
    { id: 8, name: 'August' },
    { id: 9, name: 'September' },
    { id: 10, name: 'October' },
    { id: 11, name: 'November' },
    { id: 12, name: 'December' },
  ];

  ngOnInit(): void {}

  goToBack(): void {
    this.router.navigate(['/', 'billing-statements']);
  }

  search() {
    markAllAsDirty(this.form);
    if (!this.form.valid) return;
    this.isSearching = true;
    this.displayIO = true;
    const options = new PageOptions(
      this.pageIndex,
      this.pageSize,
      this.sortOrder,
      this.sortField
    );
    this.filter(options);
  }

  onQueryParamsChange(params: NzTableQueryParams): void {
    const { pageSize, pageIndex, sort, filter } = params;
    const currentSort = sort.find((item) => item.value !== null);
    const sortField = (currentSort && currentSort.key) || null;
    const sortOrder = (currentSort && currentSort.value) || null;
    const options = new PageOptions(
      pageIndex - 1,
      pageSize,
      sortField,
      sortOrder
    );
    this.filter(options);
  }
  filter(options: PageOptions) {
    this.implementationOrderService
      .getIOFromDate(
        options,
        this.form.value.month,
        this.form.value.year.getFullYear()
      )
      .subscribe((data) => {
        this.loading = false;
        this.total = data.totalCount; // mock the total data here
        this.dataSet = data.items;
        this.isSearching = false;
      });
  }
}
