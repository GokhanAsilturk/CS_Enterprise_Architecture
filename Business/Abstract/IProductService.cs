using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();

        IDataResult<List<Product>> GetByCategoryId(int id);

        IDataResult<List<Product>> GetByUnitPrice(int min, int max);

        IDataResult<List<ProductDetailDto>> GetProductDetails();

        IResult Add(Product product);

        IDataResult<Product> GetById(int id);
    }
}
