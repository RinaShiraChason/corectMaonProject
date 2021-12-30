import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TecherAreaComponent } from './techer-area.component';

describe('TecherAreaComponent', () => {
  let component: TecherAreaComponent;
  let fixture: ComponentFixture<TecherAreaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TecherAreaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TecherAreaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
