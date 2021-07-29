import { HttpClient, HttpParams } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { PaginatedList } from 'src/app/core/paging/PaginatedList';
import { IRadioStation } from 'src/app/models/radio-station.model';

@Injectable({
  providedIn: 'root',
})
export class RadioStationService {
  private readonly api: string = 'api/radio-stations';

  constructor(
    private httpClient: HttpClient,
    @Inject('BASE_URL') public baseUrl: string
  ) {}

  getAll(): Observable<IRadioStation[]> {
    return this.httpClient
      .get<PaginatedList<IRadioStation>>(this.api)
      .pipe(map((data) => data.items));
  }

  getRadioStations(
    pageIndex: number,
    pageSize: number,
    sortField: string | null,
    sortOrder: string | null
  ): Observable<PaginatedList<IRadioStation>> {
    let params = new HttpParams()
      .append('pageIndex', `${pageIndex}`)
      .append('pageSize', `${pageSize}`)
      .append('sort', `${sortField}`)
      .append('direction', `${sortOrder}`);
    return this.httpClient.get<PaginatedList<IRadioStation>>(`${this.api}`, {
      params,
    });
  }
}
