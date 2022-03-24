import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Category } from 'src/app/models/category';
import { Product } from 'src/app/models/products';
import { CategoryService } from '../../user-services/category.service';
import { ProductService } from '../../user-services/product.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
categories:Category[]=[];

products:Product[]=[];

currentCategory:Category={id:0,categoryName:''};

  constructor(
    private categoryService:CategoryService,
    private productService:ProductService,
    private activatedRoute:ActivatedRoute) { }

  ngOnInit(): void {
    
      
    
        this.listProducts()
     
        this.listCategory()
  }
listCategory(){
  return this.categoryService.getCategories().subscribe(res=>this.categories=res.data)
}


listProducts(){
  return this.productService.getAll().subscribe(res=>this.products=res.data)
}

}
