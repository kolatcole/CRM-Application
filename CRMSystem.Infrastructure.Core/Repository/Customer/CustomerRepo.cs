using CRMSystem.Domains;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRMSystem.Infrastructure
{
    public class CustomerRepo : IRepo<Customer>
    {
        private readonly TContext _context;
        public CustomerRepo(TContext context)
        {
            _context = context;
        }
        public Task<int> deleteAsync(Customer data)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> getAsync(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<int> insertAsync(Customer data)
        {
            int ID = 0;
            try
            {
                if (data != null)
                {
                    data.DateCreated = DateTime.Now;
                    data.UserCreated = data.UserModified;
                    await _context.Customers.AddAsync(data);
                    ID = await _context.SaveChangesAsync();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ID;
        }

        public Task<int> insertListAsync(List<Customer> data)
        {
            throw new NotImplementedException();
        }

        public async Task<int> updateAsync(Customer data)
        {
            int ID = 0;
            var newCustomer = await _context.Customers.FindAsync(data.ID);
            try
            {
                if (newCustomer != null)
                {
                    newCustomer.Image = data.Image;
                    newCustomer.FirstName = data.FirstName;
                    newCustomer.Phone = data.Phone;
                    newCustomer.LastName = data.LastName;
                    newCustomer.DateModified = DateTime.Now;
                    newCustomer.UserModified = data.UserModified;
                    newCustomer.Gender = data.Gender;
                    newCustomer.Email = data.Email;
                    newCustomer.Address = data.Address;
                    

                    _context.Customers.Update(newCustomer);
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
