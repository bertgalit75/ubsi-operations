import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-new-agencies',
  templateUrl: './new-agencies.component.html',
  styleUrls: ['./new-agencies.component.less']
})
export class NewAgenciesComponent implements OnInit {


  form: FormGroup = this.fb.group({
    code: [null, Validators.required],
    name: [null, Validators.required],
    contractNo: [null],
    fax: [null],
    email: [null, Validators.required],
    remarks: [null],
  });

  constructor(private fb: FormBuilder) {}

  ngOnInit(): void {
  }

  save(): void {
    for (const i in this.form.controls) {
      this.form.controls[i].markAsDirty();
      this.form.controls[i].updateValueAndValidity();
    }
  }

}
