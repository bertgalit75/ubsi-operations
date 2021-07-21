import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { PaginatedList } from 'src/app/core/paging/PaginatedList';
import { IRadioStation } from 'src/app/models/radio-station.model';

@Injectable({
  providedIn: 'root',
})
export class RadioStationService {
  private readonly api: string = 'api/radio-stations';

  constructor(private httpClient: HttpClient) {}

  getAll(): Observable<IRadioStation[]> {
    return this.httpClient
      .get<PaginatedList<IRadioStation>>(this.api)
      .pipe(map((data) => data.items));
  }
}
