using Web.MiddleWares;

namespace Web.Extension
{
    public static class MiddleWareExtensions
    {
        public static void UseTransferBasket(this IApplicationBuilder applicationBuilder)
        {
            applicationBuilder.UseMiddleware<TransferBasketMiddleWare>();   
        }
    }
}
