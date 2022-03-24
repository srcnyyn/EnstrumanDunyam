import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home.component';
import { RouterModule } from '@angular/router';
import {MatTabsModule} from '@angular/material/tabs';



@NgModule({
  declarations: [
    HomeComponent
  ],
  imports: [
    CommonModule,
    MatTabsModule,
    RouterModule.forChild([
      {path:'',component:HomeComponent}
    ])
  ]
})
export class HomeModule { }
