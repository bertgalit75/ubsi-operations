import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { markAllAsDirty } from 'src/app/core/functions';
import { AppSettingsService } from 'src/app/core/services/app-settings.service';

@Component({
  selector: 'app-new-implementation-order',
  templateUrl: './new-implementation-order.component.html',
  styleUrls: ['./new-implementation-order.component.less'],
})
export class NewImplementationOrderComponent implements OnInit {
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

  isSaving: boolean = false;

  bookings: any[] = [];

  get bookingsArray(): FormArray {
    return this.form.get('bookings') as FormArray;
  }

  constructor(
    public appSettings: AppSettingsService,
    private fb: FormBuilder,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.addBooking();
  }

  save(): void {
    markAllAsDirty(this.form);
    if (!this.form.valid) return;

    this.isSaving = true;
  }

  addBooking(): void {
    this.bookingsArray.push(this.createBookingGroup());
    this.bookings = [...this.bookings, {}];
  }

  removeBookingGroup(index: number): void {
    this.bookingsArray.removeAt(index);
  }

  goToBack(): void {
    this.router.navigate(['/', 'implementation-orders']);
  }

  private createBookingGroup(): FormGroup {
    const group = this.fb.group({
      station: [null, Validators.required],
      period: [null, Validators.required],
      material: [],
      monday: [],
      tuesday: [],
      wednesday: [],
      thursday: [],
      friday: [],
      saturday: [],
      sunday: [],
      qty: [],
      duration: [],
      gross: [null, Validators.required],
    });

    return group;
  }
}
