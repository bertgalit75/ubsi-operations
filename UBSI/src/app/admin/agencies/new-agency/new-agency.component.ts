import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AgencyService } from 'src/app/services/agency.service';

@Component({
  selector: 'app-new-agency',
  templateUrl: './new-agency.component.html',
  styleUrls: ['./new-agency.component.less'],
})
export class NewAgencyComponent implements OnInit {
  form: FormGroup = this.fb.group({
    code: [null, Validators.required],
    name: [null, Validators.required],
    contactNo: [null],
    fax: [null],
    email: [null],
    remarks: [null],
  });

  constructor(
    private fb: FormBuilder,
    private readonly agencyService: AgencyService
  ) {}

  ngOnInit(): void {}

  save(): void {
    for (const i in this.form.controls) {
      this.form.controls[i].markAsDirty();
      this.form.controls[i].updateValueAndValidity();
    }

    if (!this.form.valid) {
      return;
    }

    this.agencyService.newAgency(this.form.value).subscribe({
      next: () => {},
    });
  }
}
