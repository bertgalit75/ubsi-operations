import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-new-implementation-order',
  templateUrl: './new-implementation-order.component.html',
  styleUrls: ['./new-implementation-order.component.less'],
})
export class NewImplementationOrderComponent implements OnInit {
  readonly DaysOfTheWeek: string[] = [
    'Mon',
    'Tue',
    'Wed',
    'Thu',
    'Fri',
    'Sat',
    'Sun',
  ];

  form: FormGroup = this.fb.group({
    ioNo: [null, Validators.required],
    agencyId: [],
    clientId: [null, Validators.required],
    date: [null, Validators.required],
    accountExecutiveId: [null, Validators.required],
    product: [null, Validators.required],
    tagline: [],
    bookingOrderNo: [],
    purchaseOrderNo: [],
    referenceCeNo: [],
    bookings: this.fb.array([]),
  });

  days: string[] = [];

  bookings: any[] = [];

  get bookingsArray(): FormArray {
    return this.form.get('bookings') as FormArray;
  }

  constructor(private fb: FormBuilder) {}

  ngOnInit(): void {}

  save(): void {
    for (const i in this.form.controls) {
      this.form.controls[i].markAsDirty();
      this.form.controls[i].updateValueAndValidity();
    }

    for (const bookingRow of this.bookingsArray.controls as FormGroup[]) {
      for (const i in bookingRow.controls) {
        bookingRow.controls[i].markAsDirty();
        bookingRow.controls[i].updateValueAndValidity();
      }
    }
  }

  addBooking(): void {
    this.bookingsArray.push(this.createBookingGroup());
    this.bookings = [...this.bookings, {}];
  }

  private createBookingGroup(): FormGroup {
    const group = this.fb.group({
      station: [null, Validators.required],
      period: [null, Validators.required],
      material: [],
      qty: [],
      duration: [],
      gross: [null, Validators.required],
    });

    return group;
  }
}
