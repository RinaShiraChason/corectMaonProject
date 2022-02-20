import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DayUpdateComponent } from './day-update.component';

describe('DayUpdateComponent', () => {
  let component: DayUpdateComponent;
  let fixture: ComponentFixture<DayUpdateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DayUpdateComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DayUpdateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
