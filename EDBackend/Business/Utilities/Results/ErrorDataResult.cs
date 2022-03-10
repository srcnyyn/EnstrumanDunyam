namespace Business.Utilities.Results
{
    public class ErrorDataresult<T>:DataResult<T>
    {
    public ErrorDataresult():base(default,false){}
    public ErrorDataresult(T data):base(data,false){}
    public ErrorDataresult(string message):base(default,false,message){}
    public ErrorDataresult(T data, string message):base(data,false,message){}        
    }
}