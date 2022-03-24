import { Product } from "./products";

export interface ResponseDataModel{
    data:Product[];
    success:boolean;
    message:string;
}