import { HttpClient, HttpParams } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { PaginatedList } from 'src/app/core/paging/PaginatedList';
import { IMediaAgency } from 'src/app/models/media-agency.model';
import { IAgency } from '../models/agency.model';

@Injectable({
  providedIn: 'root',
})
export class AgencyService {
  readonly api: string = 'api/agencies';

  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') public baseUrl: string
  ) {}

  create(iAgencyModel: IAgency): Observable<IAgency> {
    return this.http.post<IAgency>(`${this.api}`, iAgencyModel);
  }

  getAll(): Observable<IAgency[]> {
    return this.http
      .get<PaginatedList<IAgency>>(`${this.api}?all=true`)
      .pipe(map((data) => data.items));
  }

  list(
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
