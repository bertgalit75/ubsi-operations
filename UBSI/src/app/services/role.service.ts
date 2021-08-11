import { HttpClient, HttpParams } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { PaginatedList } from '../core/paging/PaginatedList';
import { IRole } from '../models/role.model';

@Injectable({
  providedIn: 'root',
})
export class RoleService {
  readonly api: string = 'api/roles';

  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') public baseUrl: string
  ) {}

  create(role): Observable<IRole> {
    return this.http.post<IRole>(`${this.api}`, role);
  }

  getRoles(
    pageIndex: number,
    pageSize: number,
    sortField: string | null,
    sortOrder: string | null
  ): Observable<PaginatedList<IRole>> {
    let params = new HttpParams()
      .append('pageIndex', `${pageIndex}`)
      .append('pageSize', `${pageSize}`)
      .append('sort', `${sortField}`)
      .append('direction', `${sortOrder}`);
    return this.http.get<PaginatedList<IRole>>(`${this.api}`, {
      params,
    });
  }
}
