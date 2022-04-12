import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ProductDetails } from 'src/app/models/product-detail';
import { ResponseDataModel } from 'src/app/models/response-data-model';

@Injectable({
  providedIn: 'root'
})
export class ProductDetailService {

  constructor(
    @Inject('APIURL') private apiUrl:string,
    private http:HttpClient

  ) { }

  getAll():Observable<ResponseDataModel<ProductDetails>>{
    return this.http.get<ResponseDataModel<ProductDetails>>(this.apiUrl+'/product/getproductdetail')
  }
  getById(id:number):Observable<ResponseDataModel<ProductDetails>>{
    return this.http.get<ResponseDataModel<ProductDetails>>(this.apiUrl+'/product/getproductdetailbyid?id='+id)
  }
  
}
