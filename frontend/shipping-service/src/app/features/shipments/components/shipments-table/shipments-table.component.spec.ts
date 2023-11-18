import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShipmentsTableComponent } from './shipments-table.component';

describe('ShipmentsTableComponent', () => {
  let component: ShipmentsTableComponent;
  let fixture: ComponentFixture<ShipmentsTableComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ShipmentsTableComponent]
    });
    fixture = TestBed.createComponent(ShipmentsTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
