import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DashboardComponent } from './dashboard.component';
import { RouterModule } from '@angular/router';
import {MatTableModule} from '@angular/material/table';



@NgModule({
  declarations: [
    DashboardComponent
  ],
  imports: [
    CommonModule,
    MatTableModule,
    RouterModule.forChild([
      {path:'',component:DashboardComponent}
    ])
  ]
})
export class DashboardModule { }
