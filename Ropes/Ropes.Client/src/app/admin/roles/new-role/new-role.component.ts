import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { markAllAsDirty } from 'src/app/core/functions';
import { RoleService } from 'src/app/services/role.service';

@Component({
  selector: 'app-new-role',
  templateUrl: './new-role.component.html',
  styleUrls: ['./new-role.component.less'],
})
export class NewRoleComponent implements OnInit {
  constructor(
    private fb: FormBuilder,
    private roleService: RoleService,
    private router: Router
  ) {}
  form: FormGroup = this.fb.group({
    name: [null, [Validators.required]],
  });
  isSaving: boolean = false;
  ngOnInit(): void {}
  save() {
    markAllAsDirty(this.form);
    if (!this.form.valid) {
      return;
    }
    this.isSaving = true;
    this.roleService.create(this.form.value).subscribe((result) => {
      this.isSaving = false;
    });
  }
  goToBack(): void {
    this.router.navigate(['/', 'roles']);
  }
}
