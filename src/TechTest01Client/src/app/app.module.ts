import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductsComponent } from './components/products/products.component';
import { HttpClientModule } from '@angular/common/http';
import { RandomProductsComponent } from './components/random-products/random-products.component';
import { ProductsBySlugComponent } from './components/products-by-slug/products-by-slug.component';

@NgModule({
  declarations: [
    AppComponent,
    ProductsComponent,
    RandomProductsComponent,
    ProductsBySlugComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
