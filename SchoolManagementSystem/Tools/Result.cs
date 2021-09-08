namespace SchoolManagementSystem.Tools
{
    public class Result
    {
        protected Result(bool isSuccess, string error)
        {
            IsSuccess = isSuccess;
            Error = error;
        }
        public bool IsSuccess { get; set; }
        public string Error { get; set; }

        public bool IsFailure => !IsSuccess;

        public static Result Failure(string message)
            => new Result(false, message);

        public static Result<T> Failure<T>(string message)
            => new Result<T>(default(T), false, message);

        public static Result Success()
            => new Result(true, string.Empty);

        public static Result<T> Success<T>(T value)
            => new Result<T>(value, true, string.Empty);
    }
}