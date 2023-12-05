namespace ProductAPI.Responses
{
    public class ResponseSuccess<T> : IResponseApi
    {
        public string Message { get; set; }
        
        public T Response { get; set; }
    }
}