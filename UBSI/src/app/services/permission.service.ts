import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { PaginatedList } from '../core/paging/PaginatedList';
import { IPermission } from '../models/permission.model';

@Injectable({
  providedIn: 'root',
})
export class PermissionService {
  private readonly api: string = '/api/permissions';
  constructor(private httpClient: HttpClient) {}
  getAll(): Observable<IPermission[]> {
    return this.httpClient
      .get<PaginatedList<IPermission>>(`${this.api}?all=true`)
      .pipe(map((data) => data.items));
  }
}
