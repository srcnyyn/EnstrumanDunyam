import { HttpClient } from '@angular/common/http';
import { Inject, Injectable, ResolvedReflectiveProvider } from '@angular/core';
import { Observable } from 'rxjs';
import { ChildCategory } from 'src/app/models/child-category';
import { ResponseModel } from 'src/app/models/responseModel';

@Injectable({
  providedIn: 'root'
})
export class ChildCategoryService {

  constructor(
    @Inject('APIURL') private apiUrl:string,
    private http:HttpClient
  ) { }

  getAll():Observable<ResponseModel<ChildCategory>>{
    return this.http.get<ResponseModel<ChildCategory>>(this.apiUrl+'/childcategory/getall')
  }
  getById(id:number):Observable<ResponseModel<ChildCategory>>{
    return this.http.get<ResponseModel<ChildCategory>>(this.apiUrl+'/childcategory/getbyid?='+id)
  }
}
