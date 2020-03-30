using CRMSystem.Domains;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRMSystem.Infrastructure
{
    public class ProductRepo : IRepo<Product>
    {
        private readonly TContext _context;
        public ProductRepo(TContext context)
        {
            _context = context;
        }
        public Task<int> deleteAsync(Product data)
        {
            throw new NotImplementedException();
        }

        public Task<Product> getAsync(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<int> insertAsync(Product data)
        {
            int ID = 0;
            try
            {
                if (data != null)
                {
                    ID = data.ID;
                    data.DateCreated = DateTime.Now;
                    data.UserCreated = data.UserModified;
                    await _context.Products.AddAsync(data);
                    await _context.SaveChangesAsync();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ID;
        }

        public Task<int> insertListAsync(List<Product> data)
        {
            throw new NotImplementedException();
        }

        public async Task<int> updateAsync(Product data)
        {
            int ID = 0;
            var newProduct = await _context.Products.FindAsync(data.ID);
            try
            {
                if (newProduct != null)
                {
                    newProduct.DateModified = DateTime.Now;
                    newProduct.UserModified = data.UserModified;
                    newProduct.Quantity = data.Quantity;
                    newProduct.Name = data.Name;
                    newProduct.Image = data.Image;
                    
                    _context.Products.Update(newProduct);
                    ID = await _context.SaveChangesAsync();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ID;
        }
    }
}
