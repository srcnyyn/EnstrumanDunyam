import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Brand } from 'src/app/models/brand';
import { ResponseDataModel } from 'src/app/models/response-data-model';

@Injectable({
  providedIn: 'root'
})
export class BrandService {

  constructor(
    @Inject('APIURL') private apiUrl:string,
    private http:HttpClient
  ) { }

getAll():Observable<ResponseDataModel<Brand>>{
  return this.http.get<ResponseDataModel<Brand>>(this.apiUrl+'/brand/getall')
}
getById(id:number):Observable<ResponseDataModel<Brand>>{
  return this.http.get<ResponseDataModel<Brand>>(this.apiUrl+'/brand/getbyid?id='+id)
}
}
