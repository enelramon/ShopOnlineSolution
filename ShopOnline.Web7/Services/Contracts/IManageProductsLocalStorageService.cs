using ShopOnline.Models.Dtos;

namespace ShopOnline.Web7.Services.Contracts
{
    public interface IManageProductsLocalStorageService
    {
        Task<IEnumerable<ProductDto>> GetCollection();
        Task RemoveCollection();
    }
}
