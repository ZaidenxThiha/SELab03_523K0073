using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;

namespace BLL
{
    public class UserService
    {
        private readonly UserRepository _repository = new UserRepository();

        public bool ValidateUser(string username, string password)
        {
            return _repository.ValidateUser(username, password);
        }
    }
}