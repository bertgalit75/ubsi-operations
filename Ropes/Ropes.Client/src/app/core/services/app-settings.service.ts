import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class AppSettingsService {
  public readonly DateFormat: string = 'MM/dd/yyyy';
}
