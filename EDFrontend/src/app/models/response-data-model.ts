import { ResponseModel } from "./response-model";

export interface ResponseDataModel<T> extends ResponseModel{
    data:T[];
}