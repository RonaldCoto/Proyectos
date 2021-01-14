import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ArkassComponent } from './arkass.component';

describe('ArkassComponent', () => {
  let component: ArkassComponent;
  let fixture: ComponentFixture<ArkassComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ArkassComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ArkassComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
