import { BaseModel } from "./basemodel";

export interface Image extends BaseModel{
    productId:number;
    date:number;
    imagePath:string;
}