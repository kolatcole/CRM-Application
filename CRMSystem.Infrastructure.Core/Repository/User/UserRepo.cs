using CRMSystem.Domains;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRMSystem.Infrastructure
{
    public class UserRepo : IRepo<User>
    {
        private readonly TContext _context;
        public UserRepo(TContext context)
        {
            _context = context;
        }
        public Task<int> deleteAsync(User data)
        {
            throw new NotImplementedException();
        }

        public Task<User> getAsync(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<int> insertAsync(User data)
        {
            int ID = 0;
            try
            {
                if (data != null)
                {
                    await _context.AppUsers.AddAsync(data);
                    ID = await _context.SaveChangesAsync();
                }
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ID;
        }

        public Task<int> insertListAsync(List<User> data)
        {
            throw new NotImplementedException();
        }

        public async Task<int> updateAsync(User data)
        {
            int ID=0;
            var newUser = await _context.AppUsers.FindAsync(data.ID);
            try
            {
                if (newUser!=null)
                {
                    newUser.Image = data.Image;
                    newUser.Name = data.Name;
                    newUser.Phone = data.Phone;
                    newUser.Post = data.Post;
                    newUser.DateModified = DateTime.Now;
                    newUser.Gender = data.Gender;

                    _context.Update(newUser);
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
