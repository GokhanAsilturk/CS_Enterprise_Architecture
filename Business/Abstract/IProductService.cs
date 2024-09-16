using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();

        List<Product> GetByCategoryId(int id);

        List<Product> GetByUnitPrice(int min, int max);
    }
}
