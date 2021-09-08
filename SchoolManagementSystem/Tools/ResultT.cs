namespace SchoolManagementSystem.Tools
{
    public class Result<T> : Result
    {
        private T _value;

        public T Value 
        {
            get => _value;
            private set => _value = value;
        }

        protected internal Result(T value, 
                        bool isSuccess, string error) 
            : base(isSuccess, error)
        {
            Value = value;
        }
    }
}