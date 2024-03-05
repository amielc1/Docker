using Store.Api.ApiModels;

namespace Store.Api.Interfaces
{
    public interface IProductLogic
    {
        IEnumerable<Product> GetProductsForCategory(string category);
    }
}
