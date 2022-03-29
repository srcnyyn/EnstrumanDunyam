import { HttpClient } from '@angular/common/http';
import { Inject, Injectable, ResolvedReflectiveProvider } from '@angular/core';
import { Observable } from 'rxjs';
import {Image} from 'src/app/models/image';
import { ResponseDataModel } from 'src/app/models/response-data-model';

@Injectable({
  providedIn: 'root'
})
export class ImageService {

  constructor(
    @Inject('APIURL') private apiUrl:string,
    private http:HttpClient
  ) { }

getAll():Observable<ResponseDataModel<Image>>{
  return  this.http.get<ResponseDataModel<Image>>(this.apiUrl+'/image/getall')
}
getById(id:number):Observable<ResponseDataModel<Image>>{
  return this.http.get<ResponseDataModel<Image>>(this.apiUrl+'/image/getbyid?id='+id)
}
}
