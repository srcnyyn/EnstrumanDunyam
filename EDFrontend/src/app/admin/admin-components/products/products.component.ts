import { Component, OnInit } from '@angular/core';
import { Brand } from 'src/app/models/brand';
import { Product } from 'src/app/models/products';
import { BrandService } from '../../admin-services/brand.service';
import { ProductService } from '../../admin-services/product.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss']
})
export class ProductsComponent implements OnInit {
  products: Product[]=[];
  brands:Brand[]=[];
 
  constructor(
    private productService:ProductService,
    private brandService:BrandService
  ) { }

  ngOnInit(): void {
    this.getBrand()
  }
  add(productName:HTMLInputElement, brandId:HTMLInputElement, colorId:HTMLInputElement,childCategoryId:HTMLInputElement,
    categoryId:HTMLInputElement,unitPrice:HTMLInputElement,quantity:HTMLInputElement ){
    alert("Ürün Eklendi");

    let postProduct:Product={
      id:0,
      productName:productName.value,
      brandId:brandId.valueAsNumber,
      colorId:colorId.valueAsNumber,
      childCategoryId:childCategoryId.valueAsNumber,
      categoryId:categoryId.valueAsNumber,
      unitPrice:unitPrice.valueAsNumber,
      quantity:quantity.valueAsNumber
    };
    this.productService.add(postProduct).subscribe((res:any)=>{
     
        
        this.products=res.data as Product[];
      
    });
  }
  getBrand(){
    this.brandService.getAll().subscribe(res=>{
      this.brands=res.data
    })
  }

}
