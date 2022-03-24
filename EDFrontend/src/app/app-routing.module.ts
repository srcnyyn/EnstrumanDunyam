import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './admin/admin-components/dashboard/dashboard.component';
import { AdminLayoutComponent } from './admin/admin-layout/admin-layout.component';
import { HomeComponent } from './user/user-components/home/home.component';

const routes: Routes = [
  {path:'admin', component:AdminLayoutComponent, children:[
    {path:'',component:DashboardComponent},
    {path:'customers', loadChildren:()=>import('./admin/admin-components/customers/customers.module').then(module=>module.CustomersModule)},
    {path:'orders', loadChildren:()=>import('./admin/admin-components/orders/orders.module').then(module =>module.OrdersModule)},
    {path:'products',loadChildren:()=>import('./admin/admin-components/products/products.module').then(module=>module.ProductsModule)}
  ] },
  {path:'', component:HomeComponent },
  {path:'carts', loadChildren:() => import('./user/user-components/carts/carts.module').then(module=>module.CartsModule)},
  {path:'product', loadChildren:()=> import('./user/user-components/products/products.module').then(module=>module.ProductsModule)},
  {path:'categories',loadChildren:()=> import('./user/user-components/categories/categories.module').then(module=>module.CategoriesModule)}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }


