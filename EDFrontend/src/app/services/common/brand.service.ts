import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Brand } from 'src/app/models/brand';
import { ResponseDataListModel } from 'src/app/models/response-datalist-model';
import { ResponseDataModel } from 'src/app/models/response-data-model';

@Injectable({
  providedIn: 'root'
})
export class BrandService {

  constructor(
    @Inject('APIURL') private apiUrl:string,
    @Inject('BRANDURL') private brandUrl:string,
    private http:HttpClient
  ) { }

getAll():Observable<ResponseDataListModel<Brand>>{
  return this.http.get<ResponseDataListModel<Brand>>(this.apiUrl+this.brandUrl+'/getall')
}
getById(id:number):Observable<ResponseDataModel<Brand>>{
  return this.http.get<ResponseDataModel<Brand>>(this.apiUrl+this.brandUrl+'/getbyid?id='+id)
}
}
