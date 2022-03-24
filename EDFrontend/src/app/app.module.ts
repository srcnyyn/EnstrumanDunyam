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
import { ProductsComponent } from './user/user-components/products/products.component';


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
    NgbModule

  ],
  
  providers: [{provide: "APIURL", useValue:"https://localhost:5001/api"}],
  bootstrap: [AppComponent]
})
export class AppModule { }
