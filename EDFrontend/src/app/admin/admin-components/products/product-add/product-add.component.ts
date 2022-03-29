import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, FormControl, Validators,} from '@angular/forms';
import { ToastrService } from 'ngx-toastr';


import { BrandService } from '../../../../services/brand.service';
import { ChildCategoryService } from '../../../../services/child-category.service';
import { ColorService } from '../../../../services/color.service';
import { CategoryService } from '../../../../services/category.service';
import { ProductAdminService } from '../../../admin-services/product-admin.service'

import { Brand } from 'src/app/models/brand';
import { ChildCategory } from 'src/app/models/child-category';
import { Color } from 'src/app/models/color';
import { Category } from 'src/app/models/category';

@Component({
  selector: 'app-product-add',
  templateUrl: './product-add.component.html',
  styleUrls: ['./product-add.component.scss'],
})
export class ProductAddComponent implements OnInit {
  productAddForm: FormGroup;

  brands: Brand[] = [];
  colors: Color[] = [];
  childCats: ChildCategory[] = [];
  categories: Category[] = [];

  currentCategoryId: number;
  chCatBySelectedCats:ChildCategory[];

  constructor(
    private formBuilder: FormBuilder,
    private brandService: BrandService,
    private colorService: ColorService,
    private childCategoryService: ChildCategoryService,
    private categoryService: CategoryService,
    private productAdminService:ProductAdminService,
    private toastrService:ToastrService
  ) {}

  ngOnInit() {
    this.getBrands();
    this.getColors();
    this.createProductAddForm();
    this.getCategories();
  }
  createProductAddForm() {
    this.productAddForm = this.formBuilder.group({
      id:0,
      productName: ['', Validators.required],
      brandId: ['', Validators.required],
      colorId: ['', Validators.required],
      categoryId: ['', Validators.required],
      childCategoryId: ['', Validators.required],
      unitPrice: ['', Validators.required],
      quantity: ['', Validators.required]
      
    });
  }
  
  getBrands() {
    this.brandService.getAll().subscribe(res => {
      this.brands = res.data;
    });
  }
  getColors() {
    this.colorService.getAll().subscribe(res => {
      this.colors = res.data;
    });
  }
  
  getCategories() {
    this.categoryService.getAll().subscribe(res => {
      this.categories = res.data;
    });
  }
  getChCatBySelectedCategory(){
    this.childCategoryService.getByCategoryId(this.currentCategoryId).subscribe(res=>{
      this.childCats=res.data
    });
  }
  
  add() {
    if(this.productAddForm.valid){

      let productModel = Object.assign({}, this.productAddForm.value);
      this.productAdminService.add(productModel).subscribe(res=>{
        console.log(res)
        this.toastrService.success(res.message,"ürün eklendi");
      })
    }else{
      this.toastrService.error("Hatalı Giriş")

    }
  }
  delete(){
    let productModel=Object.assign({}, this.productAddForm.value);
    this.productAdminService.delete(productModel).subscribe(res=>{
      this.toastrService.success(res.message,"Ürün Silindi")
    })
    
  }
}
