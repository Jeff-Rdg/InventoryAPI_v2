﻿namespace ProductAPI.Responses
{
    public class ResponseError : IResponseApi
    {
        public string Message { get; set; }

        public ResponseError(string message)
        {
            Message = message;
        }
    }
}