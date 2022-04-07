import { Component, OnInit } from '@angular/core';

import { ProductDetails } from 'src/app/models/product-detail';
import { ProductDetailService } from '../../../services/common/product-detail.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss']
})
export class ProductsComponent implements OnInit {
  productDetails:ProductDetails[]=[]
 
  constructor(
    private productDetailService:ProductDetailService
  ) { }

  ngOnInit(): void {
    this.getProductWithDetails();
  }
  
  getProductWithDetails(){
    this.productDetailService.getAll().subscribe(res=>{
      this.productDetails=res.data
    })
  }
 
  
  

}
