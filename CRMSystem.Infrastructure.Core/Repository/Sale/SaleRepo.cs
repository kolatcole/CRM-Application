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
            
            var obj = new Sale();
            try
            {
                if (data != null)
                {
                    obj = new Sale 
                    {
                        DateCreated = DateTime.Now,
                        UserCreated = data.UserModified,
                        ProductID=data.ProductID,
                        CustomerID=data.CustomerID,
                        Quantity=data.Quantity,
                        Amount=data.Amount,
                        InvoiceNo=data.InvoiceNo
                        
                    };
                    await _context.Sales.AddAsync(obj);
                    await _context.SaveChangesAsync();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return obj.ID;
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
