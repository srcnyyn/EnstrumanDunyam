import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CartsModule } from './carts/carts.module';
import { HomeComponent } from './home/home.component';
import { HomeModule } from './home/home.module';




@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    CartsModule,
    HomeModule,
    CartsModule
  ]
})
export class UserComponentsModule { }
