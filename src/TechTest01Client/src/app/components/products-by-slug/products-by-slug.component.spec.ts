import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductsBySlugComponent } from './products-by-slug.component';

describe('ProductsBySlugComponent', () => {
  let component: ProductsBySlugComponent;
  let fixture: ComponentFixture<ProductsBySlugComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProductsBySlugComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductsBySlugComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
