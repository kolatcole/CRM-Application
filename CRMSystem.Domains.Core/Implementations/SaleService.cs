using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRMSystem.Domains 
{ 
    public class SaleService:ISaleService
    {
        private readonly IRepo<Sale> _repo;
        private readonly IInvoiceNumberRepo _iRepo;
        public SaleService(IRepo<Sale> repo, IInvoiceNumberRepo iRepo)
        {
            _repo = repo;
            _iRepo = iRepo;
        }
        public async Task<int> Save(Sale data)
        {
            // generate invoice No
            int invoiceNo=1;
            var lastNumber = await _iRepo.getAsync();
            if (lastNumber != null)
                invoiceNo += 1;

            // create a new object with the newly generated number

            var newInvoiceNo = new InvoiceNumber
            {
                Number=invoiceNo
            };

            // save the InvoiceNumber Object

            await _iRepo.insertAsync(newInvoiceNo);

            // stringify the invoice Number

            var stringInv = "000" + invoiceNo.ToString();
            data.InvoiceNo = stringInv;


            // save sale record

            var result = await _repo.insertAsync(data);
            return result;

        }
    }
}
