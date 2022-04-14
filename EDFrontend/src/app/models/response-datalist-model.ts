import { ResponseModel } from "./response-model";

export interface ResponseDataListModel<T> extends ResponseModel{
    data:T[];
}