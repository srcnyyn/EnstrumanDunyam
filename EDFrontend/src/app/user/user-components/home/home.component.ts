import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Category } from 'src/app/models/category';
import { ResponseModel } from 'src/app/models/responseModel';
import { CategoryService } from '../../user-services/category.service';
import { CategoriesComponent } from '../categories/categories.component';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
categories:Category[]=[];
currentCategory:Category={id:0,categoryName:''};
  constructor(
    private categoryService:CategoryService) { }

  ngOnInit(): void {
this.listCategory();
  }
listCategory(){
  return this.categoryService.getCategories().subscribe(res=>this.categories=res.data)
}
setCurrentCategory(category:Category){
  this.currentCategory=category;
}
getCurrentCategory(category:Category){
  if(category == this.currentCategory){

    return "row list-group item active"
  }else{

    return "row list-group-active"
  }
}
}
