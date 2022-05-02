using System;
using System.Net;
using System.Threading.Tasks;
using Coterie.Api.Models;
using Coterie.Api.Models.Responses;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace Coterie.Api.ExceptionHelpers
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var response = context.Response;

            var appContext = context.Features.Get<IExceptionHandlerPathFeature>();

            BaseExceptionResponse ex = default;

            switch (appContext.Error)
            {
                case IndexOutOfRangeException:
                case NullReferenceException:
                case ArgumentException:
                    // Bad Request status
                    response.StatusCode = (int) HttpStatusCode.BadRequest;
                    break;
                default:
                    // unhandled error
                    response.StatusCode = (int) HttpStatusCode.InternalServerError;
                    break;
            }

            ex = new BaseExceptionResponse
            {
                Message = appContext.Error.Message
            };

            await response.WriteAsJsonAsync(ex);
        }
    }
}