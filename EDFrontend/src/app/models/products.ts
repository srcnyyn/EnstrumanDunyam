import { BaseModel } from "./basemodel";
export interface Product extends BaseModel{
    brandId:number;
    colorId:number;
    childCategoryId:number;
    categoryId:number;
    unitPrice:number;
    quantity:number;
    productName:string;
}