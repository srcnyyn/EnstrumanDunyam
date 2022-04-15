import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {Image} from 'src/app/models/image';
import { ResponseDataListModel } from 'src/app/models/response-datalist-model';
import { ResponseDataModel } from 'src/app/models/response-data-model';

@Injectable({
  providedIn: 'root'
})
export class ImageService {

  constructor(
    @Inject('APIURL') private apiUrl:string,
    private http:HttpClient
  ) { }

getAll():Observable<ResponseDataListModel<Image>>{
  return  this.http.get<ResponseDataListModel<Image>>(this.apiUrl+'/image/getall')
}
getById(id:number):Observable<ResponseDataModel<Image>>{
  return this.http.get<ResponseDataModel<Image>>(this.apiUrl+'/image/getbyid?id='+id)
}
getByProductId(id:number):Observable<ResponseDataListModel<Image>>{
  return this.http.get<ResponseDataListModel<Image>>(this.apiUrl+'/image/getbyproductid?id='+id)
}
}
