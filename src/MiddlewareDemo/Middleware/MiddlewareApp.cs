using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MiddlewareDemo.Middleware
{
    public class MiddlewareApp
    {

        private readonly RequestDelegate _next;//声明RequestDelegate,用于保存下一个中间件

        public MiddlewareApp(RequestDelegate next)
        {
            _next = next;
        }

        //中间件方法,用于接受httpContext参数并返回
        public async Task Invoke(HttpContext context)
        {
            //  return _next(context);//直接调用下一个中间件
            await _next.Invoke(context);
            await context.Response.WriteAsync(context.Request.Method);
        }
    }
}
