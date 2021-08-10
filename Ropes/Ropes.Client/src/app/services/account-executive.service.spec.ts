import { TestBed } from '@angular/core/testing';

import { AccountExecutiveService } from './account-executive.service';

describe('AccountExecutiveService', () => {
  let service: AccountExecutiveService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AccountExecutiveService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
