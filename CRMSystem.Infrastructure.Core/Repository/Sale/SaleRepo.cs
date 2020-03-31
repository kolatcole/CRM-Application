using CRMSystem.Domains;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRMSystem.Infrastructure
{
    public class SaleRepo : IRepo<Sale>
    {
        private readonly TContext _context;
        public SaleRepo(TContext context)
        {
            _context = context;
        }
        public Task<int> deleteAsync(Sale data)
        {
            throw new NotImplementedException();
        }

        public Task<Sale> getAsync(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<int> insertAsync(Sale data)
        {
            int ID = 0;
            try
            {
                if (data != null)
                {
                    data.DateCreated = DateTime.Now;
                    data.UserCreated = data.UserModified;
                    ID = data.ID;
                    await _context.Sales.AddAsync(data);
                    await _context.SaveChangesAsync();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ID;
        }

        public Task<int> insertListAsync(List<Sale> data)
        {
            throw new NotImplementedException();
        }

        public  Task<int> updateAsync(Sale data)
        {

            throw new NotImplementedException();
        }
    }
}
