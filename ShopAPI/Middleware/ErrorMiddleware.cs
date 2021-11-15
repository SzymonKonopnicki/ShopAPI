using Microsoft.AspNetCore.Http;
using ShopAPI.Exceptions;
using System;
using System.Threading.Tasks;

namespace ShopAPI.Middleware
{
    public class ErrorMiddleware
    {
        private readonly RequestDelegate next;

        public ErrorMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next.Invoke(context);
            }
            catch (NotFoundException nf)
            {
                context.Response.StatusCode = 404;
                await context.Response.WriteAsync(nf.Message);
            }
            catch (Exception exception)
            {
                context.Response.StatusCode = 500;
                await context.Response.WriteAsync("Nastąpił błąd");
            }
        }
    }
}
