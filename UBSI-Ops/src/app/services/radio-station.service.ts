import { HttpClient } from '@angular/common/http';
import { Injectable, Inject } from '@angular/core';
import { Observable } from 'rxjs';
import { PageOptions } from '../core/pageoptions/PageOptions';
import { PaginatedList } from '../core/paging/PaginatedList';
import { RadioStationModel } from '../models/RadioStationModel';

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
  
  list(options: PageOptions): Observable<PaginatedList<RadioStationModel>> {
    const params = options.toObject();

    return this.http.get<PaginatedList<RadioStationModel>>(`${this.api}`, {
      params,
    });
  }
}
