using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserRepository
    {
        private readonly Exer2DbContext _context;

        public UserRepository()
        {
            _context = new Exer2DbContext();
        }

        public bool ValidateUser(string username, string password)
        {
            return _context.Users.Any(u => u.Username == username && u.Password == password);
        }

        // Optional CRUD methods (for future expansion)
        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        // Add similar methods for GetUserById, GetAllUsers, UpdateUser, DeleteUser if needed
    }
}
