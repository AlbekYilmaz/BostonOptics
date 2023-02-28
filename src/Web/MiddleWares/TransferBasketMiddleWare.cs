using Web.Interfaces;

namespace Web.MiddleWares
{
    public class TransferBasketMiddleWare
    {
        private readonly RequestDelegate _next;

        public TransferBasketMiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context,IBasketViewModelService basketViewModelService)
        {
            //basketviewmodelservice'a sepetleri eğer gerekiyorsa taşı metodu yaz ve burada çağır
            await basketViewModelService.TransferBasketIfNecessary();
                

            await _next(context);
        }
    }
}
