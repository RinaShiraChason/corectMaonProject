import { TestBed } from '@angular/core/testing';

import { DayCareService } from './day-care.service';

describe('DayCareService', () => {
  let service: DayCareService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DayCareService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
