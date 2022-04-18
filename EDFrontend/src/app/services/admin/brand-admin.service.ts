import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';



@Injectable({
  providedIn: 'root'
})
export class BrandAdminService {

  constructor(
    @Inject('APIURL') private apiUrl:string,
    @Inject('BRANDURL') private brandUrl:string,
    private http:HttpClient
  ) { }
  
  
}
