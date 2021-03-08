import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GoldCalcComponent } from './gold-calc.component';

describe('GoldCalcComponent', () => {
  let component: GoldCalcComponent;
  let fixture: ComponentFixture<GoldCalcComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GoldCalcComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GoldCalcComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
