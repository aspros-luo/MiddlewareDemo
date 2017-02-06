using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace MiddlewareDemo.Middleware
{
    public class MiddlewareApp : AuthenticationMiddleware<DemoOptions>
    {

        private readonly RequestDelegate _next;//声明RequestDelegate,用于保存下一个中间件

        public MiddlewareApp(RequestDelegate next, IOptions<DemoOptions> options, ILoggerFactory loggerFactory, UrlEncoder encoder) : base(next, options, loggerFactory, encoder)
        {
            _next = next;
        }

        ////中间件方法,用于接受httpContext参数并返回
        //public new async Task Invoke(HttpContext context)
        //{
        //    //  return _next(context);//直接调用下一个中间件
        //    await _next.Invoke(context);
        //    await context.Response.WriteAsync(context.Request.Method);
        //}

        protected override AuthenticationHandler<DemoOptions> CreateHandler()
        {
            return new DemoHandler();
        }
    }
}
