using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class UserRepository
    {
        private readonly Exer3DbContext _context = new Exer3DbContext();

        public bool ValidateUser(string username, string password)
        {
            return _context.Users.Any(u => u.Username == username && u.Password == password);
        }
    }
}
