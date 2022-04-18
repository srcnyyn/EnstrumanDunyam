import { ResponseModel } from "./response-model";

export class ResponseDataModel<T> extends ResponseModel{
    data:T;
}