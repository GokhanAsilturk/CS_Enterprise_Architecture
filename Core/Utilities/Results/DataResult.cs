namespace Core.Utilities.Results
{
    public class DataResult<T> : Result,IDataResult<T>
    {

        public DataResult(T data, bool IsSuccess, string Message) : base(IsSuccess, Message)
        {

        }

        public DataResult(T data, bool IsSuccess):base(IsSuccess)
        {
            Data = data;
        }



        public T Data { get; }
    }
}
