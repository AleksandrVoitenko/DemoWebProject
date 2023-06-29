﻿namespace Debtors.WebApi.MiddleWare
{
    public static  class CustomExceptionHandlerMiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomExceptionHandler(this IApplicationBuilder app) 
        {
            return app.UseMiddleware<CustomExceptionHandlerMiddleware>();
        }
    }
}
