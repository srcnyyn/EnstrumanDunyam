import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ProductDetail } from 'src/app/models/product-detail';
import { ResponseDataListModel } from 'src/app/models/response-datalist-model';
import { ResponseDataModel } from 'src/app/models/response-data-model';


@Injectable({
  providedIn: 'root'
})
export class ProductDetailService {

  constructor(
    @Inject('APIURL') private apiUrl:string,
    @Inject('PRODUCTURL') private productUrl: string,

    private http:HttpClient

  ) { }

  getAll():Observable<ResponseDataListModel<ProductDetail>>{
    return this.http.get<ResponseDataListModel<ProductDetail>>(this.apiUrl+ this.productUrl+'/getproductdetail')
  }
  getById(id:number):Observable<ResponseDataModel<ProductDetail>>{
    return this.http.get<ResponseDataModel<ProductDetail>>(this.apiUrl+ this.productUrl+'/getproductdetailbyid?id='+id)
  }
  
}
