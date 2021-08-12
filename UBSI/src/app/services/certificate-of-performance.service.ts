import { HttpClient, HttpParams } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { PaginatedList } from '../core/paging/PaginatedList';
import { ICertificateOfPerformance } from '../models/certificate-of-performace.model';
import { IUser } from '../models/user.model';

@Injectable({
  providedIn: 'root',
})
export class CertificateOfPerformanceService {
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') public baseUrl: string
  ) {}
  readonly api: string = 'api/certificate-of-performance';

  getCPs(
    pageIndex: number,
    pageSize: number,
    sortField: string | null,
    sortOrder: string | null
  ): Observable<PaginatedList<ICertificateOfPerformance>> {
    let params = new HttpParams()
      .append('pageIndex', `${pageIndex}`)
      .append('pageSize', `${pageSize}`)
      .append('sort', `${sortField}`)
      .append('direction', `${sortOrder}`);
    return this.http.get<PaginatedList<ICertificateOfPerformance>>(
      `${this.api}`,
      {
        params,
      }
    );
  }
}
