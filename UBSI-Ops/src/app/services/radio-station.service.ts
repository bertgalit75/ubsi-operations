import { HttpClient } from '@angular/common/http';
import { Injectable, Inject } from '@angular/core';
import { Observable } from 'rxjs';
import { PageOptions } from '../core/pageoptions/PageOptions';
import { PaginatedList } from '../core/paging/PaginatedList';
import { IRadioStation } from '../models/RadioStationModel';

@Injectable({
  providedIn: 'root',
})

export class RadioStationService {
  api: string;
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') public baseUrl: string
  ) {
    this.api = 'api/radiostation';
  }
  
  list(options: PageOptions): Observable<PaginatedList<IRadioStation>> {
    const params = options.toObject();

    return this.http.get<PaginatedList<IRadioStation>>(`${this.api}`, {
      params,
    });
  }
  view(stn_code: string):Observable<IRadioStation>{
    return this.http.get<IRadioStation>(`${this.api}/${stn_code}`);
  }
}
