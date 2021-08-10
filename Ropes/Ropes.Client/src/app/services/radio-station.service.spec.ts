import { TestBed } from '@angular/core/testing';

import { RadioStationService } from './radio-station.service';

describe('RadioStationService', () => {
  let service: RadioStationService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(RadioStationService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
