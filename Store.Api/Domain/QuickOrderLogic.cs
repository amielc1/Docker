using Store.Api.ApiModels;
using Store.Api.Interfaces;

namespace Store.Api.Domain
{
    public class QuickOrderLogic : IQuickOrderLogic
    {
        private readonly ILogger<QuickOrderLogic> _logger;

        public QuickOrderLogic(ILogger<QuickOrderLogic> logger)
        {
            _logger = logger;
        }
        public Guid PlaceQuickOrder(QuickOrder order, int customerId)
        {
            _logger.LogInformation("Placing order and sending update for inventory...");
            // persist order to database or wherever

            // post "orderplaced" event to rabbitmq

            return Guid.NewGuid();
        }
    }
}
