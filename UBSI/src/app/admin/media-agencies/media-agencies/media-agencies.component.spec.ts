import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MediaAgenciesComponent } from './media-agencies.component';

describe('MediaAgenciesComponent', () => {
  let component: MediaAgenciesComponent;
  let fixture: ComponentFixture<MediaAgenciesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MediaAgenciesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MediaAgenciesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
