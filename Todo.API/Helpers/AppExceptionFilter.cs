using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Net;
using Todo.Api.Exceptions;

namespace Todo.Api.Helpers
{
    public class AppExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            HttpStatusCode status = HttpStatusCode.InternalServerError;
            String message = String.Empty;

            var exceptionType = context.Exception.GetType();

            if (exceptionType == typeof(RecordNotFoundException))
            {
                status = HttpStatusCode.NotFound;
                message = "Record not found";
            }

            context.ExceptionHandled = true;

            HttpResponse response = context.HttpContext.Response;
            response.StatusCode = (int)status;
            response.ContentType = "application/json";
            response.WriteAsync(JsonConvert.SerializeObject( new
            {
                message,
                status
            }));
        }
    }
}
