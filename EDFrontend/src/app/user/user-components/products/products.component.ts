import { Component, Inject, OnInit } from '@angular/core';
import { Category } from 'src/app/models/category';
import { Product } from 'src/app/models/products';
import { ProductService } from '../../user-services/product.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss'],
})
export class ProductsComponent implements OnInit {
  products: Product[] = [];
  constructor(private productService: ProductService) {}

  ngOnInit(): void {
   
    this.getAll();
    
  }

  getAll() {
    this.productService.getAll().subscribe(res => this.products=res.data)
  }
  getByBrandId(id:number){
    this.productService.getByBrandId(id).subscribe(res=>this.products=res.data)
  }
  getByCategoryId(id:number){
    this.productService.getByCategoryId(id).subscribe(res=>this.products=res.data)
  }
}
