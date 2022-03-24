import { BaseModel } from "./basemodel";
export interface Product extends BaseModel{
    brandId:number;
    colorId:number;
    childCategoryId:number;
    unitPrice:number;
    quantity:number;
    productName:string;
}