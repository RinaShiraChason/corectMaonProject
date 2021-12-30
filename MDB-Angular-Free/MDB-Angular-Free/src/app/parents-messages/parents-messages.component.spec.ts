import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ParentsMessagesComponent } from './parents-messages.component';

describe('ParentsMessagesComponent', () => {
  let component: ParentsMessagesComponent;
  let fixture: ComponentFixture<ParentsMessagesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ParentsMessagesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ParentsMessagesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
