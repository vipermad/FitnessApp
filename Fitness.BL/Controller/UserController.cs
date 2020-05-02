using Fitness.BL.Model;
using System;


namespace Fitness.BL.Controller
{
    public class UserController
    {
        public User User { get; }
        public UserController(User user)
        {
            User = user ?? throw new ArgumentNullException("Пользователь не может быть равен null", nameof(user));
        }
        public bool Save()
        {

        }
    }
}
