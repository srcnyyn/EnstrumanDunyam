import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';


@Injectable({
  providedIn: 'root'
})
export class CategoryAdminService {

  constructor(
    @Inject('APIURL') private apiUrl:string,
    @Inject('CATEGORYURL') private categoryUrl:string,
    
    private http:HttpClient
  ) { }

 
}
