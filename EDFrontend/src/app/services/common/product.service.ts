import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from 'src/app/models/products';
import { ResponseDataListModel } from 'src/app/models/response-datalist-model';
import { ResponseDataModel } from 'src/app/models/response-data-model';

@Injectable({
  providedIn: 'root',
})
export class ProductService {
  constructor(
    @Inject('APIURL') private apiUrl: string,
    @Inject('PRODUCTURL') private productUrl: string,
    private http: HttpClient
  ) {}

  getAll(): Observable<ResponseDataListModel<Product>> {
    return this.http.get<ResponseDataListModel<Product>>(
      this.apiUrl + this.productUrl+'/getall');
  }

  getByBrandId(id: number): Observable<ResponseDataListModel<Product>> {
    return this.http.get<ResponseDataListModel<Product>>(
      this.apiUrl + this.productUrl+'/getbybrandid?id='+id);
  }

  getByCategoryId(id: number): Observable<ResponseDataListModel<Product>> {
    return this.http.get<ResponseDataListModel<Product>>(
      this.apiUrl + this.productUrl+'/getbycategoryid?id='+id);
  }

  getByChildCategoryId(id: number): Observable<ResponseDataListModel<Product>> {
    return this.http.get<ResponseDataListModel<Product>>(
      this.apiUrl + this.productUrl+'/getbychildcategoryid?id='+id);
  }

  getByColorId(id: number): Observable<ResponseDataListModel<Product>> {
    return this.http.get<ResponseDataListModel<Product>>(
      this.apiUrl + this.productUrl+'/getbycolorid?id='+id);
  }

  getByProductId(id:number): Observable<ResponseDataModel<Product>>{
    return this.http.get<ResponseDataModel<Product>>(
      this.apiUrl+this.productUrl+'/getbyproductid?id='+id);
  }
  
}
