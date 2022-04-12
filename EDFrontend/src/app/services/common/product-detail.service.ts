import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ProductDetail } from 'src/app/models/product-detail';
import { ResponseDataModel } from 'src/app/models/response-data-model';

@Injectable({
  providedIn: 'root'
})
export class ProductDetailService {

  constructor(
    @Inject('APIURL') private apiUrl:string,
    private http:HttpClient

  ) { }

  getAll():Observable<ResponseDataModel<ProductDetail>>{
    return this.http.get<ResponseDataModel<ProductDetail>>(this.apiUrl+'/product/getproductdetail')
  }
  getById(id:number):Observable<ResponseDataModel<ProductDetail>>{
    return this.http.get<ResponseDataModel<ProductDetail>>(this.apiUrl+'/product/getproductdetailbyid?id='+id)
  }
  
}
