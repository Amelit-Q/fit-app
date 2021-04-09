using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FitnessAppBL.Controller
{
    public class UserController
    {
        public User User { get; }

        public UserController(User user)
        {
            User = user ?? throw new ArgumentNullException(nameof(user), "user can't be null or white space");
        }

        public void Save()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }

        public User Load()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                var user = formatter.Deserialize(fs) as User;
            }
        }
    }
}