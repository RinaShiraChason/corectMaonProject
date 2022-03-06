import { TestBed } from '@angular/core/testing';

import { ParentsMessgesService } from './parents-messges.service';

describe('ParentsMessgesService', () => {
  let service: ParentsMessgesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ParentsMessgesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
