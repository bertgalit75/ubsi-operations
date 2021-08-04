import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewBillingCycleComponent } from './new-billing-cycle.component';

describe('NewBillingCycleComponent', () => {
  let component: NewBillingCycleComponent;
  let fixture: ComponentFixture<NewBillingCycleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NewBillingCycleComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NewBillingCycleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
