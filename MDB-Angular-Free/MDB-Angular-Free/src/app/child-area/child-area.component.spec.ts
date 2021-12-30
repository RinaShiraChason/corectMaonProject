import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChildAreaComponent } from './child-area.component';

describe('ChildAreaComponent', () => {
  let component: ChildAreaComponent;
  let fixture: ComponentFixture<ChildAreaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ChildAreaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ChildAreaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
