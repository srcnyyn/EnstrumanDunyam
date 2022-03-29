import { BaseModel } from "./basemodel";

export interface ProductDetails extends BaseModel{
    productName:string;
    brandName:string;
    colorName:string;
    categoryName:string;
    childCategoryName:string;
    unitPrice:number;
    quantity:string;
}