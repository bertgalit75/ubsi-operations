import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
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
  getIOFromDate(form) {
    const dateFilter = {
      year: form.year.getFullYear(),
      month: form.month,
    };
    console.log(dateFilter);
  }
}
