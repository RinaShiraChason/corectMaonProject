import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddTecherComponent } from './add-techer.component';

describe('AddTecherComponent', () => {
  let component: AddTecherComponent;
  let fixture: ComponentFixture<AddTecherComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddTecherComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddTecherComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
