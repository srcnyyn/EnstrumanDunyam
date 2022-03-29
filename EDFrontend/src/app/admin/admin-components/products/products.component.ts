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
    private brandService:BrandService,
  ) { }

  ngOnInit(): void {
    this.getBrand()
  }
  
 
  
  getBrand(){
    this.brandService.getAll().subscribe(res=>{
      this.brands=res.data
    })
  }

}
