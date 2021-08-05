import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IImplementationOrder } from 'src/app/models/implementation-order.model';
import { PaginatedList } from '../core/paging/PaginatedList';

@Injectable({
  providedIn: 'root',
})
export class ImplementationOrderService {
  private readonly api: string = 'api/implementation-orders';

  constructor(private httpClient: HttpClient) {}

  create(
    implementationOrder: IImplementationOrder
  ): Observable<IImplementationOrder> {
    return this.httpClient.post<IImplementationOrder>(
      `${this.api}`,
      implementationOrder
    );
  }

  getImplementationOrder(
    pageIndex: number,
    pageSize: number,
    sortField: string | null,
    sortOrder: string | null
  ): Observable<PaginatedList<IImplementationOrder>> {
    let params = new HttpParams()
      .append('pageIndex', `${pageIndex}`)
      .append('pageSize', `${pageSize}`)
      .append('sort', `${sortField}`)
      .append('direction', `${sortOrder}`);
    return this.httpClient.get<PaginatedList<IImplementationOrder>>(
      `${this.api}`,
      {
        params,
      }
    );
  }
}
