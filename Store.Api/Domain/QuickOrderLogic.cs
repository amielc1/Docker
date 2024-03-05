using Serilog;
using Store.Api.ApiModels;
using Store.Api.Interfaces;

namespace Store.Api.Domain
{
    public class QuickOrderLogic : IQuickOrderLogic
    {

        public QuickOrderLogic(ILogger<QuickOrderLogic> logger)
        {
        }
        public Guid PlaceQuickOrder(QuickOrder order, int customerId)
        {
            Log.Information("Placing order and sending update for inventory...");
            // persist order to database or wherever

            // post "orderplaced" event to rabbitmq

            return Guid.NewGuid();
        }
    }
}
