import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Category } from 'src/app/models/category';
import { Product } from 'src/app/models/products';
import { CategoryService } from '../../../services/common/category.service';
import { ProductService } from '../../../services/common/product.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

categories:Category[]=[];
products:Product[]=[];



  constructor(
    private categoryService:CategoryService,
    private productService:ProductService) { }

  ngOnInit(): void {
        this.listProducts()
        this.listCategory()
  }
listCategory(){
  return this.categoryService.getAll().subscribe(res=>this.categories=res.data)
}


listProducts(){
  return this.productService.getAll().subscribe(res=>this.products=res.data)
}

}
