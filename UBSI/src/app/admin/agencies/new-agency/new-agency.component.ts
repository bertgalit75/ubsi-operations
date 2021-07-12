import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { NzModalService } from 'ng-zorro-antd/modal';
import { delay, finalize } from 'rxjs/operators';
import { markAsDirty } from 'src/app/core/functions';
import { AgencyService } from 'src/app/services/agency.service';

@Component({
  selector: 'app-new-agency',
  templateUrl: './new-agency.component.html',
  styleUrls: ['./new-agency.component.less'],
})
export class NewAgencyComponent implements OnInit {
  isSaving: boolean = false;

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
    private modal: NzModalService,
    private readonly agencyService: AgencyService,
    private router: Router
  ) {}

  ngOnInit(): void {}

  save(): void {
    markAsDirty(this.form);
    if (!this.form.valid) return;

    this.isSaving = true;

    this.agencyService
      .create(this.form.value)
      .pipe(finalize(() => (this.isSaving = false)))
      .subscribe({
        next: () => {
          this.modal.success({
            nzTitle: 'Agency Added',
            nzContent: 'New agency has been added',
          });
          this.router.navigate(['/agencies']);
        },
      });
  }

  goToBack(): void {
    this.router.navigate(['/agencies']);
  }
}
