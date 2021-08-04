import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import {
  NzDateMode,
  NzDatePickerComponent,
  NzDatePickerModule,
} from 'ng-zorro-antd/date-picker';
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
    year: [null],
    month: [null],
  });
  isSaving: boolean = false;

  displayIO: boolean = false;

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
    this.isSaving = true;
    this.displayIO = true;
    this.implementationOrderService.getIOFromDate(this.form.value);
  }
}
