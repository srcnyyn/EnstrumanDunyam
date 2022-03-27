import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Brand } from 'src/app/models/brand';
import { Product } from 'src/app/models/products';
import { ResponseModel } from 'src/app/models/responseModel';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(
    @Inject('APIURL') private apiUrl:string,
    private http:HttpClient
  ) { }

  add(product:Product):Observable<ResponseModel<Product>>{
    return this.http.post<ResponseModel<Product>>(this.apiUrl+'/product/add',product)
  }
  
}
