import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AccountExecutivesComponent } from './account-executives.component';

describe('AccountExecutivesComponent', () => {
  let component: AccountExecutivesComponent;
  let fixture: ComponentFixture<AccountExecutivesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AccountExecutivesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AccountExecutivesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
