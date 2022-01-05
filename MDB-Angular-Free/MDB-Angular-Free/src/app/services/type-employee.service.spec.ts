import { TestBed } from '@angular/core/testing';

import { TypeEmployeeService } from './type-employee.service';

describe('TypeEmployeeService', () => {
  let service: TypeEmployeeService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TypeEmployeeService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
