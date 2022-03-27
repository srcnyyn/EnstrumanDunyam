import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductsComponent } from './products.component';
import { RouterModule } from '@angular/router';
import {MatSelectModule} from '@angular/material/select';




@NgModule({
  declarations: [
    ProductsComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild([
      {path:'',component:ProductsComponent}
    ]),
    MatSelectModule
  ]
})
export class ProductsModule { }
