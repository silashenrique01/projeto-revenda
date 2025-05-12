using System;
using System.Collections.Generic;

namespace API.Responses
{
    public class ApiResponse<T>
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public List<string> Errors { get; set; }
        public DateTime Timestamp { get; set; }

        public ApiResponse(int statusCode, string message, T data = default, List<string> errors = null)
        {
            StatusCode = statusCode;
            Message = message;
            Data = data;
            Errors = errors ?? new List<string>();
            Timestamp = DateTime.UtcNow;
        }

        public static ApiResponse<T> Success(T data, string message = "Operação realizada com sucesso.")
        {
            return new ApiResponse<T>(200, message, data);
        }

        public static ApiResponse<T> Error(int statusCode, string message, List<string> errors = null)
        {
            return new ApiResponse<T>(statusCode, message, default, errors);
        }
    }
}