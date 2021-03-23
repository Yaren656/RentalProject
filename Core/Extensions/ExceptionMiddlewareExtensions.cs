using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureCustomExceptionMiddleware(this IApplicationBuilder app) //bu parametreyi extend ediyorum.
        {
            app.UseMiddleware<ExceptionMiddleware>();  //startup'dakilere ek olarak middleware getirdik, bu hata yakalamadır.
        }
    }
}
