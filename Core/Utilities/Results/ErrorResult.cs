namespace Core.Utilities.Results
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(false, message) //çift parametreli base const u çalıştır.
        {

        }
        public ErrorResult() : base(false)//tek parametreliyi çalıştır
        {

        }
    }
}
