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
    private http:HttpClient
  ) { }

  getAll():Observable<ResponseDataListModel<ChildCategory>>{
    return this.http.get<ResponseDataListModel<ChildCategory>>(this.apiUrl+'/childcategory/getall')
  }
  getById(id:number):Observable<ResponseDataModel<ChildCategory>>{
    return this.http.get<ResponseDataModel<ChildCategory>>(this.apiUrl+'/childcategory/getbyid?='+id)
  }
  getByCategoryId(categoryId:number):Observable<ResponseDataListModel<ChildCategory>>{

    return this.http.get<ResponseDataListModel<ChildCategory>>(this.apiUrl+'/childcategory/getbycategoryid?categoryId='+categoryId)
  }
}
