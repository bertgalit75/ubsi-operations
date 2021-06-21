import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewRadioStationComponent } from './view-radio-station.component';

describe('ViewRadioStationComponent', () => {
  let component: ViewRadioStationComponent;
  let fixture: ComponentFixture<ViewRadioStationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ViewRadioStationComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewRadioStationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
