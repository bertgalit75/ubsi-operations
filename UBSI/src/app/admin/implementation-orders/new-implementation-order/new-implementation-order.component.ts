import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { finalize } from 'rxjs/operators';
import { markAllAsDirty } from 'src/app/core/functions';
import { AppSettingsService } from 'src/app/core/services/app-settings.service';
import { IAccountExecutive } from 'src/app/models/account-executive.model';
import { IAgency } from 'src/app/models/agency.model';
import { ICustomer } from 'src/app/models/customer.model';
import { IRadioStation } from 'src/app/models/radio-station.model';
import { AccountExecutiveService } from 'src/app/services/account-executive.service';
import { AgencyService } from 'src/app/services/agency.service';
import { CustomerService } from 'src/app/services/customer.service';
import { ImplementationOrderService } from 'src/app/services/implementation-order.service';
import { RadioStationService } from 'src/app/services/radio-station.service';

@Component({
  selector: 'app-new-implementation-order',
  templateUrl: './new-implementation-order.component.html',
  styleUrls: ['./new-implementation-order.component.less'],
})
export class NewImplementationOrderComponent implements OnInit {
  form: FormGroup = this.fb.group({
    code: [null, Validators.required],
    agencyCode: [],
    clientCode: [null, Validators.required],
    date: [null, Validators.required],
    accountExecutiveCode: [null, Validators.required],
    product: [null, Validators.required],
    tagline: [],
    bookingOrderNo: [],
    purchaseOrderNo: [],
    referenceCeNo: [],
    bookings: this.fb.array([]),
  });

  isSaving: boolean = false;

  bookings: any[] = [];

  agencies: IAgency[] = [];

  customers: ICustomer[] = [];

  accountExecutives: IAccountExecutive[] = [];

  radioStations: IRadioStation[] = [];

  get bookingsArray(): FormArray {
    return this.form.get('bookings') as FormArray;
  }

  constructor(
    public appSettings: AppSettingsService,
    private implementationOrderService: ImplementationOrderService,
    private agencyService: AgencyService,
    private customerService: CustomerService,
    private accountExecutiveService: AccountExecutiveService,
    private radioStationService: RadioStationService,
    private fb: FormBuilder,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.loadAgencies();
    this.loadCustomers();
    this.loadAccountExecutives();
    this.loadRadioStations();

    this.addBooking();
  }

  save(): void {
    markAllAsDirty(this.form);
    if (!this.form.valid) return;

    this.isSaving = true;

    this.implementationOrderService
      .create(this.form.value)
      .pipe(finalize(() => (this.isSaving = false)))
      .subscribe({
        next: () => {},
      });
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
      stationCode: [null, Validators.required],
      period: [null, Validators.required],
      material: [],
      monday: [false],
      tuesday: [false],
      wednesday: [false],
      thursday: [false],
      friday: [false],
      saturday: [false],
      sunday: [false],
      noOfSpots: [],
      duration: [],
      grossAmount: [null, Validators.required],
    });

    return group;
  }

  private loadAgencies(): void {
    this.agencyService
      .getAll()
      .subscribe((agencies) => (this.agencies = agencies));
  }

  private loadCustomers(): void {
    this.customerService
      .getAll()
      .subscribe((customers) => (this.customers = customers));
  }

  private loadAccountExecutives(): void {
    this.accountExecutiveService
      .getAll()
      .subscribe(
        (accountExecutives) => (this.accountExecutives = accountExecutives)
      );
  }

  private loadRadioStations(): void {
    this.radioStationService
      .getAll()
      .subscribe((radioStations) => (this.radioStations = radioStations));
  }
}
