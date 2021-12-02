import { TestBed } from '@angular/core/testing';

import { TeacherOfManagerService } from './teacher-of-manager.service';

describe('TeacherOfManagerService', () => {
  let service: TeacherOfManagerService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TeacherOfManagerService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
