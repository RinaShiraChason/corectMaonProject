import { TestBed } from '@angular/core/testing';

import { PlacementOfATeacherService } from './placement-of-ateacher.service';

describe('PlacementOfATeacherService', () => {
  let service: PlacementOfATeacherService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PlacementOfATeacherService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
