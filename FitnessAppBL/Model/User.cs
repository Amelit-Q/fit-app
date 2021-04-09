using System;

namespace FitnessAppBL.Model
{
    /// <summary>
    /// Class User
    /// </summary>
    [Serializable]
    public class User
    {
        /// <summary>
        /// Name of the user
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// User's gender (string)
        /// </summary>
        public Gender Gender { get; }

        /// <summary>
        /// User's birthday 
        /// </summary>
        public DateTime BirthDay { get; }

        /// <summary>
        /// Weight of the user
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        ///  User's height
        /// </summary>
        public double Height { get; set; }


        /// <summary>Constructor for new user</summary>
        public User(string name, Gender gender, DateTime birthDay, double weight, double height)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name), "Name can't be empty or null");
            }

            if (gender == null)
            {
                throw new ArgumentNullException(nameof(gender), "gender field can't be null");
            }

            if (birthDay < DateTime.Parse("01.01.1940") || birthDay >= DateTime.Now)
            {
                throw new ArgumentException("Birthday incorrect", nameof(birthDay));
            }

            if (weight <= 20)
            {
                throw new ArgumentException("Weight can't be under 20", nameof(weight));
            }

            if (height <= 100)
            {
                throw new ArgumentException("Height can't be less than 100, or equals it", nameof(height));
            }


            Name = name;
            Gender = gender;
            BirthDay = birthDay;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}