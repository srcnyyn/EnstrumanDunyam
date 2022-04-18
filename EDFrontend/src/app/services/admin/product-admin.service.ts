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
    @Inject('PRODUCTURL') private productUrl:string,
    
    private http:HttpClient
  ) { }

  add(product:Product):Observable<ResponseModel>{
    return this.http.post<ResponseModel>(this.apiUrl+ this.productUrl+'/add',product)
  }
  delete(id:string):Observable<ResponseModel>{
    return this.http.delete<ResponseModel>(this.apiUrl+this.productUrl+'/delete',{headers:{id}})
  }
  update(product:Product):Observable<ResponseModel>{
    return this.http.put<ResponseModel>(this.apiUrl+this.productUrl+'/update',product)
  }
  
}
