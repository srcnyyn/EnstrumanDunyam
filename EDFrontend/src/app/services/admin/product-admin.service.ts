import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from 'src/app/models/products';
import { ResponseModel } from 'src/app/models/response-model';

@Injectable({
  providedIn: 'root'
})
export class ProductAdminService {

  constructor(
    @Inject('APIURL') private apiUrl:string,
    private http:HttpClient
  ) { }

  add(product:Product):Observable<ResponseModel>{
    return this.http.post<ResponseModel>(this.apiUrl+'/product/add',product)
  }
  delete(product:Product):Observable<ResponseModel>{
    return this.http.delete<ResponseModel>(this.apiUrl+'/product/delete')
  }
  update(product:Product):Observable<ResponseModel>{
    return this.http.put<ResponseModel>(this.apiUrl+'/product/update',product)
  }
  
}
