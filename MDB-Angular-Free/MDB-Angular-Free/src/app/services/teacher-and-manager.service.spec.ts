import { TestBed } from '@angular/core/testing';

import { TeacherAndManagerService } from './teacher-and-manager.service';

describe('TeacherAndManagerService', () => {
  let service: TeacherAndManagerService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TeacherAndManagerService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
