import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Product } from '../models/product';

const httpOptions = {
 headers : new HttpHeaders({ 'Content-Type' : 'application/json'})
};

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  private domain = '${environment.serverUrl}';
  constructor(private http: HttpClient) { }

  getProducts(): Observable<Product[]> {
    return this.http.get<Product[]>('https://localhost:44354/api/products');
  }

  getProductBySlug(slug: string): Observable<Product> {
    return this.http.get<Product>('https://localhost:44354/api/products/' + slug);
  }
}
