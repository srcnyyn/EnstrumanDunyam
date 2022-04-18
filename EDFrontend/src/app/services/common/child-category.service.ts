import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ChildCategory } from 'src/app/models/child-category';
import { ResponseDataListModel } from 'src/app/models/response-datalist-model';
import { ResponseDataModel } from 'src/app/models/response-data-model';

@Injectable({
  providedIn: 'root'
})
export class ChildCategoryService {

  constructor(
    @Inject('APIURL') private apiUrl:string,
    @Inject('CHILDCATEGORYURL') private childCategoryUrl:string,
    private http:HttpClient
  ) { }

  getAll():Observable<ResponseDataListModel<ChildCategory>>{
    return this.http.get<ResponseDataListModel<ChildCategory>>(this.apiUrl+ this.childCategoryUrl+'/getall')
  }
  getById(id:number):Observable<ResponseDataModel<ChildCategory>>{
    return this.http.get<ResponseDataModel<ChildCategory>>(this.apiUrl+this.childCategoryUrl+'/getbyid?='+id)
  }
  getByCategoryId(categoryId:number):Observable<ResponseDataListModel<ChildCategory>>{

    return this.http.get<ResponseDataListModel<ChildCategory>>(this.apiUrl+this.childCategoryUrl+'/getbycategoryid?categoryId='+categoryId)
  }
}
