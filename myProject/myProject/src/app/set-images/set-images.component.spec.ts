import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SetImagesComponent } from './set-images.component';

describe('SetImagesComponent', () => {
  let component: SetImagesComponent;
  let fixture: ComponentFixture<SetImagesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SetImagesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SetImagesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
