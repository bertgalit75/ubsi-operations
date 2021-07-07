import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewMediaAgencyComponent } from './new-media-agency.component';

describe('NewMediaAgencyComponent', () => {
  let component: NewMediaAgencyComponent;
  let fixture: ComponentFixture<NewMediaAgencyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NewMediaAgencyComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NewMediaAgencyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
