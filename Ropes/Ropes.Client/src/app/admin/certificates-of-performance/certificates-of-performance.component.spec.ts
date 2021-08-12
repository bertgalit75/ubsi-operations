import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CertificatesOfPerformanceComponent } from './certificates-of-performance.component';

describe('CertificatesOfPerformanceComponent', () => {
  let component: CertificatesOfPerformanceComponent;
  let fixture: ComponentFixture<CertificatesOfPerformanceComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CertificatesOfPerformanceComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CertificatesOfPerformanceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
