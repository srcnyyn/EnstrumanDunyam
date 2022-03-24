import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CartsModule } from './carts/carts.module';
import { HomeModule } from './home/home.module';
import { ProductsModule } from './products/products.module';
import { ProductsComponent } from './products/products.component';





@NgModule({
  declarations: [
  ],
  imports: [
    CommonModule,
    CartsModule,
    HomeModule,
    CartsModule,
    ProductsModule
    
  ]
})
export class UserComponentsModule { }
