import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewImplementationOrderComponent } from './view-implementation-order.component';

describe('ViewImplementationOrderComponent', () => {
  let component: ViewImplementationOrderComponent;
  let fixture: ComponentFixture<ViewImplementationOrderComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ViewImplementationOrderComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewImplementationOrderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
