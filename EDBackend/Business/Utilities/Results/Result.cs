namespace Business.Utilities.Results
{
    public class Result 
    {
        public bool Success { get; }
        public string Message { get; }

        public Result(bool success,string message):this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
    }
}