import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AdminFooterComponent } from './admin-footer/admin-footer.component';
import { AdminSidebarComponent } from './admin-sidebar/admin-sidebar.component';
import { AdminHeaderComponent } from './admin-header/admin-header.component';



@NgModule({
  declarations: [
    AdminFooterComponent,
    AdminSidebarComponent,
    AdminHeaderComponent
  ],
  imports: [
    CommonModule
  ],
  exports:[
    AdminFooterComponent,
    AdminSidebarComponent,
    AdminHeaderComponent
  ]
})
export class AdminLayoutComponentsModule { }
