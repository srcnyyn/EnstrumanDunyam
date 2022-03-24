import { HttpClient } from '@angular/common/http';
import { Inject, Injectable, ResolvedReflectiveProvider } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from 'src/app/models/products';
import { ResponseDataModel } from 'src/app/models/responseDataModel';

@Injectable({
  providedIn: 'root',
})
export class ProductService {
  constructor(
    @Inject('APIURL') private apiUrl: string,
    private http: HttpClient
  ) {}

  getAll(): Observable<ResponseDataModel> {
    return this.http.get<ResponseDataModel>(
      this.apiUrl + '/product/getall');
  }

  getByBrandId(id: number): Observable<ResponseDataModel> {
    return this.http.get<ResponseDataModel>(
      this.apiUrl + '/getbybrandid');
  }

  getByCategoryId(id: number): Observable<ResponseDataModel> {
    return this.http.get<ResponseDataModel>(
      this.apiUrl + '/getbycategoryid');
  }

  getByChildCategoryId(id: number): Observable<ResponseDataModel> {
    return this.http.get<ResponseDataModel>(
      this.apiUrl + 'getbychildcategoryid'
    );
  }

  getByColorId(id: number): Observable<ResponseDataModel> {
    return this.http.get<ResponseDataModel>(
      this.apiUrl + '/getbycolorid');
  }

  getByProductId(id:number): Observable<ResponseDataModel>{
    return this.http.get<ResponseDataModel>(
      this.apiUrl+'/getbyproductid');
  }
  
}
