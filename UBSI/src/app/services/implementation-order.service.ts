import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { IImplementationOrder } from 'src/app/models/implementation-order.model';
import { PageOptions } from '../core/pageoptions/PageOptions';
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

  getIOFromDate(
    options: PageOptions,
    year: number,
    month: number
  ): Observable<PaginatedList<IImplementationOrder>> {
    const params = options.toObject();
    return this.httpClient.get<PaginatedList<IImplementationOrder>>(
      `${this.api}/${month}/${year}/filter`,
      {
        params,
      }
    );
  }
}
