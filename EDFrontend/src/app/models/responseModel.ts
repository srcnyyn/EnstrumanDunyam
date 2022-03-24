export interface ResponseModel<T>{
    data:T[];
    success:boolean;
    message:string;
}