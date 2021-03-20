import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FederadoComponent } from './federado.component';

describe('FederadoComponent', () => {
  let component: FederadoComponent;
  let fixture: ComponentFixture<FederadoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FederadoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FederadoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
