import { TestBed } from '@angular/core/testing';

import { KidsAttendanceService } from './kids-attendance.service';

describe('KidsAttendanceService', () => {
  let service: KidsAttendanceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(KidsAttendanceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
