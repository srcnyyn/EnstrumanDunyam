import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, FormsModule, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

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
import { ProductDetailService } from 'src/app/services/common/product-detail.service';

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
 product:Product

 currentCategoryId:number
 addButton:boolean=true;
 updateButton:boolean=false;

  
  

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
      productName:['',Validators.required],
      brandId:['',Validators.required],
      colorId:['',Validators.required],
      categoryId:['',Validators.required],
      childCategoryId:['',Validators.required],
      unitPrice:['',Validators.required],
      quantity:['',Validators.required],
    })
  }

  updateProductForm(productId:number)
{

  this.productDetailService.getById(productId).subscribe(res=>{
    this.productService.getByProductId(productId).subscribe(res=>{
      this.product = res.data
      this.getChCatBySelectedCategory(this.product.categoryId)
      this.productUpdateForm = this.formBuilder.group({
        "productName":[this.product.productName,Validators.required],
        "brandId":[this.product.brandId, Validators.required],
        "colorId":[this.product.colorId, Validators.required],
        "categoryId":[this.product.categoryId, Validators.required],
        "childCategoryId":[this.product.childCategoryId, Validators.required],
        "unitPrice":[this.product.unitPrice, Validators.required],
        "quantity":[this.product.quantity, Validators.required]
      })
    })
    this.productDetail=res.data
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

 getChCatBySelectedCategory(categoryId:number){
   this.childCategoryService.getByCategoryId(categoryId).subscribe(res=>{
     this.childCats=res.data
    });
   
  }
 
  add(){
    this.addButton=true;
    
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
        this.productAdminService.delete(productId.toString()).subscribe(res=>{
          this.toastrService.success(res.message,"Ürün Silindi")
          this.getProductWithDetails();
          this.createdProductAddForm();
          this.addButton=true;
          this.updateButton=false
          });
        }else{
          this.toastrService.error("Ürün Silinemedi")
        }
      });

  }
  updateScreen(productId:number){
    this.updateButton=true;
    this.updateProductForm(productId); 
    
  }

  update(){
    let product:Product = {
      id:this.product.id,
      productName:this.productUpdateForm.value['productName'],
      brandId:this.productUpdateForm.value['brandId'], 
      colorId:this.productUpdateForm.value['colorId'],
      categoryId:this.productUpdateForm.value['categoryId'],
      childCategoryId:this.productUpdateForm.value['childCategoryId'],
      unitPrice:this.productUpdateForm.value['unitPrice'],
      quantity:this.productUpdateForm.value['quantity']
    }
    this.productAdminService.update(product).subscribe(res=>{
      if(res.success){
        this.toastrService.success(res.message,"Ürün Güncellendi")
        this.getProductWithDetails();
        this.addButton=true;
        this.updateButton=false;
      }else{
        this.toastrService.error(res.message + "Güncelleme Hatalı")
      }
    })
  }
    
    
  

}
