import { Component, OnInit } from '@angular/core';
import { ProductService } from 'src/app/services/common/product.service';

@Component({
  selector: 'app-product-delete',
  templateUrl: './product-delete.component.html',
  styleUrls: ['./product-delete.component.scss']
})
export class ProductDeleteComponent implements OnInit {

  constructor(
    private productService:ProductService
    ) { }

  ngOnInit(): void {
  }

  createProductDeleteForm(){
    
  }

}
