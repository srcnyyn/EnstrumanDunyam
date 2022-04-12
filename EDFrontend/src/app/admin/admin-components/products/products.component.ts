import { convertUpdateArguments } from '@angular/compiler/src/compiler_util/expression_converter';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, FormsModule, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { throwIfEmpty } from 'rxjs';

import { Brand } from 'src/app/models/brand';
import { Category } from 'src/app/models/category';
import { ChildCategory } from 'src/app/models/child-category';
import { Color } from 'src/app/models/color';
import { ProductDetail } from 'src/app/models/product-detail';
import { Product } from 'src/app/models/products';

import { ProductAdminService } from 'src/app/services/admin/product-admin.service';
import { BrandService } from 'src/app/services/common/brand.service';
import { CategoryService } from 'src/app/services/common/category.service';
import { ChildCategoryService } from 'src/app/services/common/child-category.service';
import { ColorService } from 'src/app/services/common/color.service';
import { ProductService } from 'src/app/services/common/product.service';
import { ProductDetailService } from '../../../services/common/product-detail.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss']
})
export class ProductsComponent implements OnInit {

  productAddForm:FormGroup;
  productUpdateForm:FormGroup;

  productDetails:ProductDetail[]=[]
  productDetail:ProductDetail

  brands:Brand[]=[]
  colors:Color[]=[]
  categories:Category[]=[]
  childCats:ChildCategory[]=[]
  product:Product[]=[]

  changeScreen:boolean=true;

  currentCategoryId:number;
  

  constructor(
    private formBuilder:FormBuilder,
    private toastrService:ToastrService,

    private productDetailService:ProductDetailService,
    private productAdminService:ProductAdminService,

    private brandService:BrandService,
    private colorService:ColorService,
    private categoryService:CategoryService,
    private childCategoryService:ChildCategoryService,
    private productService:ProductService
  ) { }

  ngOnInit(): void {
    this.getBrands();
    this.getColors();
    this.getCategories();

    this.getProductWithDetails();
    this.createdProductAddForm();
  }
  createdProductAddForm(){
    this.productAddForm = this.formBuilder.group({
      id:0,
      productName:['',Validators.required],
      brandId:['',Validators.required],
      colorId:['',Validators.required],
      categoryId:['',Validators.required],
      childCategoryId:['',Validators.required],
      unitPrice:['',Validators.required],
      quantity:['',Validators.required],
    })
  }
  
 
 
  
  
  
  getProductWithDetails(){
    this.productDetailService.getAll().subscribe(res=>{
      this.productDetails=res.data
    })
  }
  getBrands(){
    this.brandService.getAll().subscribe(res=>{
      this.brands=res.data
    })
  }
  getColors(){
 this.colorService.getAll().subscribe(res=>{
   this.colors=res.data
  })
}
getCategories(){
  this.categoryService.getAll().subscribe(res=>{
      this.categories = res.data
    })
  }
 getChCatBySelectedCategory(){
   this.currentCategoryId=this.categories[0].id
  console.log(this.currentCategoryId)
   this.childCategoryService.getByCategoryId(this.currentCategoryId).subscribe(res=>{
     this.childCats=res.data
    });
  }
  add(){
    if(this.productAddForm.valid){
      let productModel = Object.assign({},this.productAddForm.value);
      this.productAdminService.add(productModel).subscribe(res=>{
        this.toastrService.success(res.message,"Ürün Eklendi")
        this.getProductWithDetails();
        this.productAddForm.reset();

      })
    }else{
      this.toastrService.error("Hatalı Giriş")
    }
  }
  delete(productId:number){
      this.productService.getByProductId(productId).subscribe(res=>{
        this.product=res.data
        if(this.product!=null){
          this.productAdminService.delete(this.product).subscribe(res=>{
            this.toastrService.success(res.message,"Ürün Silindi")
            this.getProductWithDetails();
          });
        }else{
          this.toastrService.error("Ürün Silinemedi")
        }
      });

  }
  updateScreen(productId:number){
    this.changeScreen=false;

     this.productDetailService.getById(productId).subscribe(res=>{
      this.productDetail=res.data[0]
      console.log(this.productDetail)
      this.getBrands();
      
      
    })
  }

    
    
  

}
