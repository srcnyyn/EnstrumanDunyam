import { Component, Input, OnInit } from '@angular/core';
import { Category } from 'src/app/models/category';
import { CategoryService } from '../../user-services/category.service';

@Component({
  selector: 'app-categories',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.scss']
})
export class CategoriesComponent implements OnInit {
  categories:Category[]=[];
  constructor(private categoryService:CategoryService) { }
  ngOnInit(): void {
    this.getAll()
  }

  getAll(){
    this.categoryService.getCategories().subscribe(res=>this.categories=res.data);
    
  }
  
}
