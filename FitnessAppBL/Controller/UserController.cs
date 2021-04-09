using System;

namespace FitnessAppBL.Controller
{
    public class UserController
    {
        public User User { get; }

        public UserController(User user)
        {
            User = user ?? throw new ArgumentNullException(nameof(user), "user can't be null or white space");
        }

        // public bool Save() 1.17
        // {
        //     
        // }
    }
}