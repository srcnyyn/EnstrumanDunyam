import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from "@angular/common/http";

import { AdminModule } from './admin/admin.module';
import { UserModule } from './user/user.module';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { NavComponent } from './nav/nav.component';
import {MatButtonModule} from '@angular/material/button';

import { ToastrModule } from 'ngx-toastr';




@NgModule({
  declarations: [
    AppComponent,
    NavComponent
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    AdminModule,
    UserModule,
    BrowserAnimationsModule,
    HttpClientModule,
    NgbModule,
    MatButtonModule,
    ToastrModule.forRoot({
      positionClass:"toast-bottom-right"
    })
  ],
  
  
  providers: [
    {provide: "APIURL", useValue:"https://localhost:5001"},
    {provide:"PRODUCTURL", useValue:"/product"},
    {provide:"BRANDURL", useValue:"/brand"},
    {provide:"COLORURL", useValue:"/color"},
    {provide:"CATEGORYURL", useValue:"/category"},
    {provide:"CHILDCATEGORYURL", useValue:"/childcategory"},
    {provide:"IMAGEURL", useValue:"/image"}
],
  bootstrap: [AppComponent]
})
export class AppModule { }
