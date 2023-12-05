namespace ProductAPI.Responses
{
    public class ResponseError : IResponseApi
    {
        public string Message { get; set; }
        
        public string[] Errors { get; set; }
    }
}