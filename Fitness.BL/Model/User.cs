﻿using System;

namespace Fitness.BL.Model
{/// <summary>
/// Пользователь
/// </summary>
    public class User
    {
        #region Свойства
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Пол.
        /// </summary>
        public Gender Gender { get; }
        /// <summary>
        /// Дата рождения.
        /// </summary>
        public DateTime BirthDate { get; }
        /// <summary>
        /// Вес.
        /// </summary>
        public double Weigth { get; set; }
        /// <summary>
        /// Рост.
        /// </summary>
        public double Heigth { get; set; }
        #endregion
        /// <summary>
        /// Создать нового пользователя.
        /// </summary>
        /// <param name="name"> Имя. </param>
        /// <param name="gender"> Пол. </param>
        /// <param name="birthDate"> Дата рождения. </param>
        /// <param name="weigth"> Вес. </param>
        /// <param name="heigth"> Рост. </param>
        public User(string name,
                    Gender gender,
                    DateTime birthDate,
                    double weigth,
                    double heigth)
        {
            #region Проверка условий
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или null", nameof(name));
            }
            if(gender == null)
            {
                throw new ArgumentNullException("Пол не может быть null", nameof(gender));
            }
            if(birthDate<DateTime.Parse("01.01.1900") || birthDate>=DateTime.Now)
            {
                throw new ArgumentException("Невозможная дата рождения", nameof(birthDate));
            }
            if(weigth<=0)
            {
                throw new ArgumentException("Вес не может быть меньше либо равен нулю", nameof(weigth));
            }
            if(heigth<=0)
            {
                throw new ArgumentException("Рост не может быть меньше либо равен нулю",nameof(heigth));
            }
            #endregion
            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weigth = weigth;
            Heigth = heigth;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
