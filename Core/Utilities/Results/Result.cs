namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        public Result(bool IsSuccess, string Message) : this(IsSuccess)
        {// 2 parametre gönderildiğinde IsSuccess parametreli const. da çalışsın.
            this.Message = Message;
        }

        public Result(bool IsSuccess)
        {
            this.IsSuccess = IsSuccess;
        }
        public bool IsSuccess { get; }

        public string Message { get; }
    }
}
