using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRMSystem.Domains
{
    public class ProductService : IProductService
    {
        private readonly IRepo<Product> _pRepo;
        private readonly IRepo<Price> _pcrepo;
        public ProductService(IRepo<Price> pcrepo, IRepo<Product> pRepo)
        {
            _pRepo = pRepo;
            _pcrepo = pcrepo;
        }

        public async Task<int> insertProductAsync(Product data)
        {
            
            var PID=await _pcrepo.insertAsync(data.Price);

            // save a product
            data.PriceID = PID;
            int PRID = await _pRepo.insertAsync(data);

            return PRID;

            
        }
    }
}
