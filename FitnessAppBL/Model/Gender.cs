using System;

namespace FitnessAppBL.Model
{
    /// <summary>
    /// Пол.
    /// </summary>
    [Serializable]
    public class Gender
    {
        /// <summary>
        /// Название пола.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Конструктор. Создать новый пол
        /// </summary>
        /// <param name="name">Название пола</param>
        /// <exception cref="ArgumentNullException"></exception>
        public Gender(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name), "Is Empty please enter your name");
            }

            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}