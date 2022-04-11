import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AdminFooterComponent } from './admin-footer/admin-footer.component';
import { AdminSidebarComponent } from './admin-sidebar/admin-sidebar.component';
import { AdminHeaderComponent } from './admin-header/admin-header.component';
import {MatListModule} from '@angular/material/list';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [
    AdminFooterComponent,
    AdminSidebarComponent,
    AdminHeaderComponent
    
  ],
  imports: [
    CommonModule,
    RouterModule,
    MatListModule
  ],
  exports:[
    AdminFooterComponent,
    AdminSidebarComponent,
    AdminHeaderComponent
  ]
})
export class AdminLayoutComponentsModule { }
