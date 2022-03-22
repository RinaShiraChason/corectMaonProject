import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SetExternalDataComponent } from './set-external-data.component';

describe('SetExternalDataComponent', () => {
  let component: SetExternalDataComponent;
  let fixture: ComponentFixture<SetExternalDataComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SetExternalDataComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SetExternalDataComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
