import { HttpClient } from '@angular/common/http';
import { Inject, Injectable, ResolvedReflectiveProvider } from '@angular/core';
import { Observable } from 'rxjs';
import { ResponseModel } from 'src/app/models/responseModel';
import {Image} from 'src/app/models/image';

@Injectable({
  providedIn: 'root'
})
export class ImageService {

  constructor(
    @Inject('APIURL') private apiUrl:string,
    private http:HttpClient
  ) { }

getAll():Observable<ResponseModel<Image>>{
  return  this.http.get<ResponseModel<Image>>(this.apiUrl+'/image/getall')
}
getById(id:number):Observable<ResponseModel<Image>>{
  return this.http.get<ResponseModel<Image>>(this.apiUrl+'/image/getbyid?id='+id)
}
}
