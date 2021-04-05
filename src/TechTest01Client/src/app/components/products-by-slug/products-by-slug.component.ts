import { Component, ComponentFactoryResolver, OnInit } from '@angular/core';

import { ProductService } from '../../services/product.service';

import { Product } from '../../models/product';
import { ProductsComponent } from '../products/products.component';
import { ActivatedRoute, Params } from '@angular/router';

@Component({
  selector: 'app-products-by-slug',
  templateUrl: './products-by-slug.component.html',
  styleUrls: ['./products-by-slug.component.less']
})
export class ProductsBySlugComponent implements OnInit {
  slug!: string;
  product!: Product;
  constructor(private productService: ProductService, private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {
    this.slug = this.activatedRoute.snapshot.params.id;
    this.getBySlug(this.slug);
  }

    // tslint:disable-next-line:typedef
    getBySlug(slug: string){
      this.productService.getProductBySlug(slug).subscribe((result: Product) => this.product = result);
    }

}
