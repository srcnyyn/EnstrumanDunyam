import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from 'src/app/models/products';
import { ResponseDataModel } from 'src/app/models/response-data-model';

@Injectable({
  providedIn: 'root',
})
export class ProductService {
  constructor(
    @Inject('APIURL') private apiUrl: string,
    private http: HttpClient
  ) {}

  getAll(): Observable<ResponseDataModel<Product>> {
    return this.http.get<ResponseDataModel<Product>>(
      this.apiUrl + '/product/getall');
  }

  getByBrandId(id: number): Observable<ResponseDataModel<Product>> {
    return this.http.get<ResponseDataModel<Product>>(
      this.apiUrl + '/product/getbybrandid?id='+id);
  }

  getByCategoryId(id: number): Observable<ResponseDataModel<Product>> {
    return this.http.get<ResponseDataModel<Product>>(
      this.apiUrl + '/product/getbycategoryid?id='+id);
  }

  getByChildCategoryId(id: number): Observable<ResponseDataModel<Product>> {
    return this.http.get<ResponseDataModel<Product>>(
      this.apiUrl + '/product/getbychildcategoryid?id='+id);
  }

  getByColorId(id: number): Observable<ResponseDataModel<Product>> {
    return this.http.get<ResponseDataModel<Product>>(
      this.apiUrl + '/product/getbycolorid?id='+id);
  }

  getByProductId(id:number): Observable<ResponseDataModel<Product>>{
    return this.http.get<ResponseDataModel<Product>>(
      this.apiUrl+'/product/getbyproductid?id='+id);
  }
  
}
