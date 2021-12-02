import { TestBed } from '@angular/core/testing';

import { ChildrenOfManagerService } from './children-of-manager.service';

describe('ChildrenOfManagerService', () => {
  let service: ChildrenOfManagerService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ChildrenOfManagerService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
