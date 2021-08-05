import { HttpClient, HttpParams } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { PaginatedList } from '../core/paging/PaginatedList';
import { IBillingStatement } from '../models/billing-statement.model';

@Injectable({
  providedIn: 'root',
})
export class BillingStatementService {
  readonly api: string = 'api/billing-statements';
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') public baseUrl: string
  ) {}
  getBillingStatements(
    pageIndex: number,
    pageSize: number,
    sortField: string | null,
    sortOrder: string | null
  ): Observable<PaginatedList<IBillingStatement>> {
    let params = new HttpParams()
      .append('pageIndex', `${pageIndex}`)
      .append('pageSize', `${pageSize}`)
      .append('sort', `${sortField}`)
      .append('direction', `${sortOrder}`);
    return this.http.get<PaginatedList<IBillingStatement>>(`${this.api}`, {
      params,
    });
  }
}
