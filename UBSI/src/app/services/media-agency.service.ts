import { HttpClient, HttpParams } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { PaginatedList } from '../core/paging/PaginatedList';
import { IMediaAgency } from '../models/media-agency.model';
@Injectable({
  providedIn: 'root',
})
export class MediaAgencyService {
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') public baseUrl: string
  ) {}
  readonly api: string = 'api/media-agencies';

  getMediaAgencies(
    pageIndex: number,
    pageSize: number,
    sortField: string | null,
    sortOrder: string | null
  ): Observable<PaginatedList<IMediaAgency>> {
    let params = new HttpParams()
      .append('pageIndex', `${pageIndex}`)
      .append('pageSize', `${pageSize}`)
      .append('sort', `${sortField}`)
      .append('direction', `${sortOrder}`);
    return this.http.get<PaginatedList<IMediaAgency>>(`${this.api}`, {
      params,
    });
  }
}
