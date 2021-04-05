import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductsBySlugComponent } from './components/products-by-slug/products-by-slug.component';
import { ProductsComponent } from './components/products/products.component';
import { RandomProductsComponent } from './components/random-products/random-products.component';

const routes: Routes = [
  { path: '', component: RandomProductsComponent },
  { path: 'products', component: ProductsComponent },
  { path: 'product/:id', component: ProductsBySlugComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
