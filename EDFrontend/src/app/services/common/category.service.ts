import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Category } from 'src/app/models/category';
import { ResponseDataListModel } from 'src/app/models/response-datalist-model';
import { ResponseDataModel } from 'src/app/models/response-data-model';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  constructor(
    @Inject('APIURL') private apiUrl:string,
    @Inject('CATEGORYURL') private categoryUrl:string,
    private http:HttpClient
  ) { }

  getAll():Observable<ResponseDataListModel<Category>>{
     return this.http.get<ResponseDataListModel<Category>>(
       this.apiUrl+ this.categoryUrl+'/getall');
  }
  getById(id:number):Observable<ResponseDataModel<Category>>{
    return this.http.get<ResponseDataModel<Category>>(
      this.apiUrl+this.categoryUrl+'/getbyid?id='+id)
  }
}
