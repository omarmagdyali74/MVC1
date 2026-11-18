using System.Diagnostics;

namespace MVC1.Middlewares
{
    public class Requesttime
    {
        private readonly RequestDelegate Next;
        public Requesttime(RequestDelegate next)
        {
            Next = next;
        }


        public  async Task InvokeAsync(HttpContext context )
        {
            var stop=Stopwatch.StartNew();
           await Next.Invoke(context);
            stop.Stop();
            Console.WriteLine($"{context.Request.Path}: {stop.ElapsedMilliseconds}");
        }
    }
}
