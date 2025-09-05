using MockSample.Interface;

namespace MockSample.Service
{
    public class ProductService
    {
        private readonly IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public int GetProductCount() => _repository.GetAll().Count();
    }
}
