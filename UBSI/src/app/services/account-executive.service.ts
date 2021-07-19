import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { PaginatedList } from 'src/app/core/paging/PaginatedList';
import { IAccountExecutive } from 'src/app/models/account-executive.model';

@Injectable({
  providedIn: 'root',
})
export class AccountExecutiveService {
  private readonly api: string = '/api/account-executives';

  constructor(private httpClient: HttpClient) {}

  getAll(): Observable<IAccountExecutive[]> {
    return this.httpClient
      .get<PaginatedList<IAccountExecutive>>(`${this.api}?all=true`)
      .pipe(map((data) => data.items));
  }
  list(
    pageIndex: number,
    pageSize: number,
    sortField: string | null,
    sortOrder: string | null
  ): Observable<PaginatedList<IAccountExecutive>> {
    let params = new HttpParams()
      .append('pageIndex', `${pageIndex}`)
      .append('pageSize', `${pageSize}`)
      .append('sort', `${sortField}`)
      .append('direction', `${sortOrder}`);
    return this.httpClient.get<PaginatedList<IAccountExecutive>>(
      `${this.api}`,
      {
        params,
      }
    );
  }
}
