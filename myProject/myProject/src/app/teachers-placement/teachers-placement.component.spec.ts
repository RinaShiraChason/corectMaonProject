import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TeachersPlacementComponent } from './teachers-placement.component';

describe('TeachersPlacementComponent', () => {
  let component: TeachersPlacementComponent;
  let fixture: ComponentFixture<TeachersPlacementComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TeachersPlacementComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TeachersPlacementComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
