import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';


@Injectable({
  providedIn: 'root'
})
export class ColorAdminService {

  constructor(
    @Inject('APIURL') private apiUrl:string,
    @Inject('COLORURL') private colorUrl:string,
    private http:HttpClient
  ) { }



}
