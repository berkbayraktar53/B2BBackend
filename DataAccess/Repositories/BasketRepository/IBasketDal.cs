using Entities.Dtos;
using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Repositories.BasketRepository
{
    public interface IBasketDal : IEntityRepository<Basket>
    {
        Task<List<BasketListDto>> GetListByCustomerId(int customerId);
    }
}