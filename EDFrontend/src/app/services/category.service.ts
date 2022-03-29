import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Category } from 'src/app/models/category';
import { ResponseDataModel } from 'src/app/models/response-data-model';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  constructor(
    @Inject('APIURL') private apiUrl:string,
    private http:HttpClient
  ) { }

  getAll():Observable<ResponseDataModel<Category>>{
     return this.http.get<ResponseDataModel<Category>>(this.apiUrl+'/category/getall');
  }
  getById(id:number):Observable<ResponseDataModel<Category>>{
    return this.http.get<ResponseDataModel<Category>>(this.apiUrl+'/category/getbyid?id='+id)
  }
}
