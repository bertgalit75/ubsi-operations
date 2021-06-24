import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ImplementationOrdersComponent } from './implementation-orders.component';

describe('ImplementationOrdersComponent', () => {
  let component: ImplementationOrdersComponent;
  let fixture: ComponentFixture<ImplementationOrdersComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ImplementationOrdersComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ImplementationOrdersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
