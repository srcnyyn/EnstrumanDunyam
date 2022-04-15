import { Component, Inject, OnInit } from '@angular/core';
import { ProductDetail } from 'src/app/models/product-detail';
import { Image } from 'src/app/models/image';
import { ImageService } from 'src/app/services/common/image.service';
import { ProductDetailService } from 'src/app/services/common/product-detail.service';
import { Product } from 'src/app/models/products';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss'],
})
export class ProductsComponent implements OnInit {

  productDetail: ProductDetail[] = [];
  images:Image[]=[];
  products:ProductDetail;
  imageUrl=this.apiUrl;
  constructor(
    @Inject('APIURL') private apiUrl:string,
    private productDetailService: ProductDetailService,
    private imageService:ImageService
    ) {}

  ngOnInit(): void {
    this.getProductsWithDetail();
    this.getProductImages(2);
    
  }
  
  getProductsWithDetail() {
    this.productDetailService.getAll().subscribe(res => {
      
      this.productDetail=res.data
    })
    
    
  }
  getProductImages(id:number){
    this.imageService.getByProductId(id).subscribe(res=>{
        this.images = res.data
        console.log(this.images);
      })
  }

 
}
