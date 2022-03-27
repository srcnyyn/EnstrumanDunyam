import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Color } from 'src/app/models/color';
import { ResponseModel } from 'src/app/models/responseModel';

@Injectable({
  providedIn: 'root'
})
export class ColorService {

  constructor(
    @Inject('APIURL') private apiUrl:string,
    private http:HttpClient
  ) { }
  getAll():Observable<ResponseModel<Color>>{
    return this.http.get<ResponseModel<Color>>(this.apiUrl+'/color/getall')
  }
  getById(id:number):Observable<ResponseModel<Color>>{
    return this.http.get<ResponseModel<Color>>(this.apiUrl+'/color/getbyid?='+id)
  }
}
