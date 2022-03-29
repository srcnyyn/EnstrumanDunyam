import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';



@Injectable({
  providedIn: 'root'
})
export class ChildCategoryAdminService {

  constructor(
    @Inject('APIURL') private apiUrl:string,
    private http:HttpClient
  ) { }

 
  
}
