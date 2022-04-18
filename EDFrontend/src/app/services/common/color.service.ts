import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Color } from 'src/app/models/color';
import { ResponseDataListModel } from 'src/app/models/response-datalist-model';
import { ResponseDataModel } from 'src/app/models/response-data-model';

@Injectable({
  providedIn: 'root'
})
export class ColorService {

  constructor(
    @Inject('APIURL') private apiUrl:string,
    @Inject('COLORURL') private colorUrl:string,
    private http:HttpClient
  ) { }
  getAll():Observable<ResponseDataListModel<Color>>{
    return this.http.get<ResponseDataListModel<Color>>(this.apiUrl+ this.colorUrl+'/getall')
  }
  getById(id:number):Observable<ResponseDataModel<Color>>{
    return this.http.get<ResponseDataModel<Color>>(this.apiUrl+this.colorUrl+'/getbyid?='+id)
  }
}
