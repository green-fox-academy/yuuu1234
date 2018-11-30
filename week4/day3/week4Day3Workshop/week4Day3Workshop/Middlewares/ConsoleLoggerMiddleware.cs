using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using week4Day3Workshop.Interfaces;
using week4Day3Workshop.Models;
using week4Day3Workshop.Services;

namespace week4Day3Workshop.Middlewares
{
    public class ConsoleLoggerMiddleware:IMiddleware
    {
        private readonly IPrinter printer;
        private readonly IColor color;
        public ConsoleLoggerMiddleware(IPrinter printer,IColor red)
        {
            this.printer = printer;
            this.color = red;
        }
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine("Hi from the middleware");
            next(context);
            //return context.Response.WriteAsync(printer.Log("hello"));
            return context.Response.WriteAsync(color.PrintColor());
            //return next(context);
        }
    }
}
