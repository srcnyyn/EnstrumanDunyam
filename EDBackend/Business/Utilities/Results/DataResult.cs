namespace Business.Utilities.Results
{
    public class DataResult<T>:Result
    {
        T Data{get;}
        public DataResult(T data,bool success,string message):base(success,message){ Data = data;}
        public DataResult(T data,bool success):base(success){Data=data;}
    }
}