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
    @Inject('IMAGEURL') private imageUrl:string,
    private http:HttpClient
  ) { }

getAll():Observable<ResponseDataListModel<Image>>{
  return  this.http.get<ResponseDataListModel<Image>>(this.apiUrl+this.imageUrl+'/getall')
}
getById(id:number):Observable<ResponseDataModel<Image>>{
  return this.http.get<ResponseDataModel<Image>>(this.apiUrl+this.imageUrl+'/getbyid?id='+id)
}
getByProductId(id:number):Observable<ResponseDataListModel<Image>>{
  return this.http.get<ResponseDataListModel<Image>>(this.apiUrl+this.imageUrl+'/getbyproductid?id='+id)
}
}
