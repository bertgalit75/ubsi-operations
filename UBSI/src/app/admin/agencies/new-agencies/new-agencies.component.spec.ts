import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewAgenciesComponent } from './new-agencies.component';

describe('NewAgenciesComponent', () => {
  let component: NewAgenciesComponent;
  let fixture: ComponentFixture<NewAgenciesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NewAgenciesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NewAgenciesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
