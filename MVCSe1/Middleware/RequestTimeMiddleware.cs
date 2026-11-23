namespace MVCSe1.Middleware
{
    public class RequestTimeMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestTimeMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            var startTime = DateTime.Now;
            await _next(context);
            var endTime = DateTime.Now;
            var processingTime = endTime - startTime;
            context.Response.Headers.Add("X-Processing-Time", processingTime.TotalMilliseconds.ToString());
        }
    }
}
