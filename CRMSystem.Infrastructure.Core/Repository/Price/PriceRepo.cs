using CRMSystem.Domains;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRMSystem.Infrastructure
{
    public class PriceRepo:IRepo<Price>
    {
        private readonly TContext _context;
        public PriceRepo(TContext context)
        {
            _context = context;
        }

        public Task<int> deleteAsync(Price data)
        {
            throw new NotImplementedException();
        }

        public Task<Price> getAsync(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<int> insertAsync(Price data)
        {
            int ID = 0;
            try
            {
                if (data != null)
                {
                    ID = data.ID;
                    data.DateCreated = DateTime.Now;
                    data.UserCreated = data.UserModified;
                    await _context.Prices.AddAsync(data);
                    await _context.SaveChangesAsync();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ID;
        }

        public Task<int> insertListAsync(List<Price> data)
        {
            throw new NotImplementedException();
        }

        public async Task<int> updateAsync(Price data)
        {
            int ID = 0;
            var newPrice = await _context.Prices.FindAsync(data.ID);
            try
            {
                if (newPrice != null)
                {
                    ID = data.ID;
                    newPrice.SalePrice = data.SalePrice;
                    newPrice.CostPrice = data.CostPrice;
                    newPrice.DateModified = DateTime.Now;
                    newPrice.UserModified = data.UserModified;

                    _context.Prices.Update(newPrice);
                    await _context.SaveChangesAsync();
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
