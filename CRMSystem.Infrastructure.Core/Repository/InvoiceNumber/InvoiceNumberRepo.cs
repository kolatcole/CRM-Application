using CRMSystem.Domains;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace CRMSystem.Infrastructure
{
    public class InvoiceNumberRepo : IInvoiceNumberRepo
    {
        TContext _context;
        public InvoiceNumberRepo(TContext context)
        { 
            _context=context;
        }
        

        public async Task<InvoiceNumber> getAsync()
        {
            InvoiceNumber number = new InvoiceNumber();
            try
            {
                number = _context.InvoiceNumbers.Last();
            }
            catch (Exception ex)
            {
                number = null;
            }
            
            return number;
        }

        public async Task<int> insertAsync(InvoiceNumber data)
        {
            int ID = 0;
            try
            {
                if (data != null)
                {
                    
                    ID = data.ID;
                    await _context.InvoiceNumbers.AddAsync(data);
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
