using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRMSystem.Domains
{
    public interface IInvoiceNumberRepo
    {

        Task<int> insertAsync(InvoiceNumber data);
        Task<InvoiceNumber> getAsync();
    }
}
