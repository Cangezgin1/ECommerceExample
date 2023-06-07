using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserService _userService;

        public void Create(User user)
        {
            _userService.Create(user);
        }

        public void Delete(User user)
        {
            _userService.Delete(user);
        }

        public List<User> GetAll()
        {
            return _userService.GetAll();
        }

        public User GetById(int id)
        {
            return _userService.GetById(id);
        }

        public void Update(User user)
        {
            _userService.Update(user);
        }
    }
}
