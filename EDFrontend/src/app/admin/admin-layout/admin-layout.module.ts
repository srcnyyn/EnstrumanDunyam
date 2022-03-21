import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AdminLayoutComponent } from './admin-layout.component';
import { AdminLayoutComponentsModule } from './admin-layout-components/admin-layout-components.module';



@NgModule({
  declarations: [
    AdminLayoutComponent
  ],
  imports: [
    CommonModule,
    AdminLayoutComponentsModule
  ],
  exports:[
    AdminLayoutComponent
  ]

})
export class AdminLayoutModule { }
