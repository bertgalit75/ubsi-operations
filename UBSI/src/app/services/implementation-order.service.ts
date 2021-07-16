import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IImplementationOrder } from 'src/app/models/implementation-order.model';

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
}
