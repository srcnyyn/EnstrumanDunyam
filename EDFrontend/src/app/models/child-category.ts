import { BaseModel } from "./basemodel";

export interface ChildCategory extends BaseModel{

    categoryId:number;
    childCategoryName: string;
    

}