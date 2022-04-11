import { Component, OnInit } from '@angular/core';
import { Category } from '../models/category';
import { Product } from '../models/products';
import { CategoryService } from '../services/common/category.service';
import { ProductService } from '../services/common/product.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.scss']
})
export class NavComponent implements OnInit {
  categories:Category[]=[];
  products:Product[]=[];

  constructor(
    private categoryService:CategoryService,
    private productService:ProductService
  ) { }

  ngOnInit(): void {
    this.getAllCategories();
    this.getAllProducts();

  }
  getAllProducts(){
    this.productService.getAll().subscribe(res=>{
      this.products = res.data
    })
  }
  getAllCategories(){
    this.categoryService.getAll().subscribe(res=>{
      this.categories =res.data})
  }
}
