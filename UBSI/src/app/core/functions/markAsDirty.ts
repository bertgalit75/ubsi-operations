import { FormArray, AbstractControl, FormGroup } from '@angular/forms';

export function markAsDirty(form: FormGroup): void {
  for (const i in form.controls) {
    _markAsDirty(form.controls[i]);
  }
}

export function markAllAsDirty(form: FormGroup): void {
  for (const i in form.controls) {
    const formControl = form.controls[i];

    if (formControl instanceof FormArray) {
      for (const subControl of formControl.controls as FormGroup[]) {
        markAllAsDirty(subControl);
      }
    } else {
      _markAsDirty(formControl);
    }
  }
}

function _markAsDirty(abstractControl: AbstractControl): void {
  abstractControl.markAsDirty();
  abstractControl.updateValueAndValidity();
}
