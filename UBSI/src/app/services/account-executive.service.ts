import { HttpClient } from '@angular/common/http';
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
}
