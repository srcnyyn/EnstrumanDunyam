import { ResponseModel } from "./response-model";

export class ResponseDataListModel<T> extends ResponseModel{
    data:T[];
}