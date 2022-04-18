import { BaseModel } from "./basemodel";
export class Product extends BaseModel{
    brandId:number;
    colorId:number;
    childCategoryId:number;
    categoryId:number;
    unitPrice:number;
    quantity:number;
    productName:string;
}