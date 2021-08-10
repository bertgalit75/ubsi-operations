import { TestBed } from '@angular/core/testing';

import { ImplementationOrderService } from './implementation-order.service';

describe('ImplementationOrderService', () => {
  let service: ImplementationOrderService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ImplementationOrderService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
