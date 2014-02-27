namespace SqlToJson
{
    public class Response
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public Response()
        {
            IsSuccess = false;
            Message = string.Empty;
        }
    }

    public class Response<T> : Response
    {
        public T Item { get; set; }
    }
}
