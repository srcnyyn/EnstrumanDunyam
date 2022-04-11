import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AdminLayoutComponent } from './admin-layout.component';
import { AdminLayoutComponentsModule } from './admin-layout-components/admin-layout-components.module';
import {MatSidenavModule} from '@angular/material/sidenav';
import { RouterModule } from '@angular/router';




@NgModule({
  declarations: [
    AdminLayoutComponent
  ],
  imports: [
    CommonModule,
    AdminLayoutComponentsModule,
    RouterModule,
    MatSidenavModule
    
  ],
  exports:[
    AdminLayoutComponent
  ]

})
export class AdminLayoutModule { }
