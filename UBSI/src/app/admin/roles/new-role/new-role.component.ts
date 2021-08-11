import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ComplexInnerSubscriber } from 'rxjs/internal/innerSubscribe';
import { markAllAsDirty } from 'src/app/core/functions';
import { IPermission } from 'src/app/models/permission.model';
import { PermissionService } from 'src/app/services/permission.service';
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
    private router: Router,
    private permissionService: PermissionService
  ) {}
  form: FormGroup = this.fb.group({
    name: [null, [Validators.required]],
  });
  dataSet: IPermission[];

  isSaving: boolean = false;
  ngOnInit(): void {
    this.loadPermission();
  }
  save() {
    markAllAsDirty(this.form);
    if (!this.form.valid) {
      return;
    }
    const newRole = {
      name: this.form.value.name,
      rolePermissions: this.dataSet,
    };
    this.isSaving = true;
    this.roleService.create(newRole).subscribe((result) => {
      this.isSaving = false;
    });
  }
  goToBack(): void {
    this.router.navigate(['/', 'roles']);
  }
  loadPermission() {
    this.permissionService.getAll().subscribe((permissions) => {
      console.log(permissions);
      this.dataSet = permissions;
    });
  }
  onViewChecked(permission: IPermission, event: any): void {
    if (event == true) {
      permission.view = true;
    } else {
      permission.view = false;
    }
  }
  onCreateChecked(permission: IPermission, event: any): void {
    if (event == true) {
      permission.add = true;
      permission.view = true;
    } else {
      permission.add = false;
    }
  }
  onEditChecked(permission: IPermission, event: any): void {
    if (event == true) {
      permission.edit = true;
      permission.view = true;
    } else {
      permission.edit = false;
    }
  }
  onDeleteChecked(permission: IPermission, event: any): void {
    if (event == true) {
      permission.delete = true;
      permission.view = true;
    } else {
      permission.delete = false;
    }
  }
}
