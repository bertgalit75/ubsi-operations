import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IAgency } from '../models/agency.model';

@Injectable({
  providedIn: 'root',
})
export class AgencyService {
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') public baseUrl: string
  ) {}
  readonly api: string = 'api/agencies';

  newAgency(iAgencyModel: IAgency): Observable<IAgency> {
    return this.http.post<IAgency>(`${this.api}`, iAgencyModel);
  }
}
