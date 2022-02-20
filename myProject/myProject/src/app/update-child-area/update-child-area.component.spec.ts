import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateChildAreaComponent } from './update-child-area.component';

describe('UpdateChildAreaComponent', () => {
  let component: UpdateChildAreaComponent;
  let fixture: ComponentFixture<UpdateChildAreaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UpdateChildAreaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UpdateChildAreaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
