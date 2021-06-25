import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewImplementationOrderComponent } from './new-implementation-order.component';

describe('NewImplementationOrderComponent', () => {
  let component: NewImplementationOrderComponent;
  let fixture: ComponentFixture<NewImplementationOrderComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NewImplementationOrderComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NewImplementationOrderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
