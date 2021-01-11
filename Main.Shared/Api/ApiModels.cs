using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Main.Shared.Api
{
    public class ApiOutput<T>
    {
        public T Result { get; set; }
        public bool Success { get; set; }
        public ApiError Error { get; set; }
    }

    public class ApiArray<T>
    {
        public List<T> Items { get; set; }
    }
    public class ApiError
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }
        public string ValidationErrors { get; set; }
    }

    public struct ApiSucces
    {
        public string Message { get; set; }
        public bool Show { get; set; }
        public ApiSucces(bool show = false)
        {
            Message = "Succes action!";
            Show = show;
        }
        public ApiSucces(string message)
        {
            Message = message;
            Show = true;
        }
    }

    public class ApiIdInput : ApiIdInput<int>
    {
        public ApiIdInput(int id) : base(id)
        {
        }
    }

    public class ApiIdInput<T>
    {
        public ApiIdInput(T id)
        {
            Id = id;
        }
        public T Id { get; set; }
    }
    public class ApiNullOutput
    {

    }
}
