import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FirstIndexComponent } from './first-index.component';

describe('FirstIndexComponent', () => {
  let component: FirstIndexComponent;
  let fixture: ComponentFixture<FirstIndexComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [FirstIndexComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(FirstIndexComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
