import { HttpClient } from '@angular/common/http';
import { Inject, Injectable, ResolvedReflectiveProvider } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from 'src/app/models/products';
import { ResponseModel } from 'src/app/models/responseModel';

@Injectable({
  providedIn: 'root',
})
export class ProductService {
  constructor(
    @Inject('APIURL') private apiUrl: string,
    private http: HttpClient
  ) {}

  getAll(): Observable<ResponseModel<Product>> {
    return this.http.get<ResponseModel<Product>>(
      this.apiUrl + '/product/getall');
  }

  getByBrandId(id: number): Observable<ResponseModel<Product>> {
    return this.http.get<ResponseModel<Product>>(
      this.apiUrl + '/product/getbybrandid?id='+id);
  }

  getByCategoryId(id: number): Observable<ResponseModel<Product>> {
    return this.http.get<ResponseModel<Product>>(
      this.apiUrl + '/product/getbycategoryid?id='+id);
  }

  getByChildCategoryId(id: number): Observable<ResponseModel<Product>> {
    return this.http.get<ResponseModel<Product>>(
      this.apiUrl + '/product/getbychildcategoryid?id='+id);
  }

  getByColorId(id: number): Observable<ResponseModel<Product>> {
    return this.http.get<ResponseModel<Product>>(
      this.apiUrl + '/product/getbycolorid?id='+id);
  }

  getByProductId(id:number): Observable<ResponseModel<Product>>{
    return this.http.get<ResponseModel<Product>>(
      this.apiUrl+'/product/getbyproductid?id='+id);
  }
  
}
