import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PageChildPlacementComponent } from './page-child-placement.component';

describe('PageChildPlacementComponent', () => {
  let component: PageChildPlacementComponent;
  let fixture: ComponentFixture<PageChildPlacementComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PageChildPlacementComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PageChildPlacementComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
