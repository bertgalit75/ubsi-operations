import { HttpClient, HttpParams } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { NzTableQueryParams } from 'ng-zorro-antd/table';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { PageOptions } from '../core/pageoptions/PageOptions';
import { PaginatedList } from '../core/paging/PaginatedList';
import { ICustomer } from '../models/customer.model';

@Injectable({
  providedIn: 'root',
})
export class CustomerService {
  readonly api: string = 'api/customers';

  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') public baseUrl: string
  ) {}

  getAll(): Observable<ICustomer[]> {
    return this.http
      .get<PaginatedList<ICustomer>>(`${this.api}?all=true`)
      .pipe(map((data) => data.items));
  }

  getCustomers(
    pageIndex: number,
    pageSize: number,
    sortField: string | null,
    sortOrder: string | null
  ): Observable<PaginatedList<ICustomer>> {
    let params = new HttpParams()
      .append('pageIndex', `${pageIndex}`)
      .append('pageSize', `${pageSize}`)
      .append('sort', `${sortField}`)
      .append('direction', `${sortOrder}`);
    return this.http.get<PaginatedList<ICustomer>>(`${this.api}`, {
      params,
    });
  }

  getCustomerDetails(code: string): Observable<ICustomer> {
    return this.http.get<ICustomer>(`${this.api}/${code}`);
  }
}
