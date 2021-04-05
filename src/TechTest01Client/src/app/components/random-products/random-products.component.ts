import { Component, OnInit } from '@angular/core';

import { ProductService } from '../../services/product.service';

import { Product } from '../../models/product';

@Component({
  selector: 'app-random-products',
  templateUrl: './random-products.component.html',
  styleUrls: ['./random-products.component.less']
})
export class RandomProductsComponent implements OnInit {
  products: Product[] = [];
  constructor(private productService: ProductService) { }

  ngOnInit(): void {
    this.getTwoProducts();
  }

   // tslint:disable-next-line:typedef
   getTwoProducts() {
    // tslint:disable-next-line:max-line-length
    this.productService.getProducts().subscribe((result: Array<Product>) => this.products = result.sort((a, b) => 0.5 - Math.random()).slice(0, 2));
  }


}
