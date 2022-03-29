import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Color } from 'src/app/models/color';
import { ResponseDataModel } from 'src/app/models/response-data-model';

@Injectable({
  providedIn: 'root'
})
export class ColorService {

  constructor(
    @Inject('APIURL') private apiUrl:string,
    private http:HttpClient
  ) { }
  getAll():Observable<ResponseDataModel<Color>>{
    return this.http.get<ResponseDataModel<Color>>(this.apiUrl+'/color/getall')
  }
  getById(id:number):Observable<ResponseDataModel<Color>>{
    return this.http.get<ResponseDataModel<Color>>(this.apiUrl+'/color/getbyid?='+id)
  }
}
