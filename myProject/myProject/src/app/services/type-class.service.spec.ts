import { TestBed } from '@angular/core/testing';

import { TypeClassService } from './type-class.service';

describe('TypeClassService', () => {
  let service: TypeClassService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TypeClassService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
