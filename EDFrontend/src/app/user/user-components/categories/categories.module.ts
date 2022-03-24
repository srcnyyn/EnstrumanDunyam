import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { CategoriesComponent } from './categories.component';

import {MatListModule} from '@angular/material/list';



@NgModule({
  declarations: [
    CategoriesComponent
  ],
  imports: [
    CommonModule,
    MatListModule,
    RouterModule.forChild([
      {path:'', component:CategoriesComponent}
    ])
  ]
})
export class CategoriesModule { }
