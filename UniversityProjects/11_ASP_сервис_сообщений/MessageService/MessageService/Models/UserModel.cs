using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;
using System.IO;
using System.ComponentModel.DataAnnotations;


namespace MessageService.Models
{
    /// <summary>
    /// Модель для описания пользователя.
    /// </summary>
    [Serializable]
    public class UserModel: IEquatable<UserModel>, IDataworker<UserModel>
    {

        /// <summary>
        /// Имя пользователя.
        /// </summary>
        [Required()]
        public string UserName { get; set; }
        /// <summary>
        /// Адрес электронной почты.
        /// </summary>
        [Required()]
        public string Email { get; set; }

        /// <summary>
        /// Конструктор для создания пользователя.
        /// </summary>
        /// <param name="name">
        /// Имя пользователя.
        /// </param>
        /// <param name="email">
        /// Почта пользователя.
        /// </param>
        public UserModel(string name, string email)
        {
            UserName = name;
            Email = email;
        }

        static UserModel()
        {
            usersPath = @$"./data{Path.DirectorySeparatorChar}users.json";
        }

        static string usersPath;


        public bool Equals([AllowNull] UserModel other) => other.Email == this.Email;


        /// <summary>
        /// Считывание пользователей из файла.
        /// </summary>
        /// <returns></returns>
        public static List<UserModel> GetUsers() => IDataworker<UserModel>.LoadData(usersPath);


        /// <summary>
        /// Запись всех пользователей в файл.
        /// </summary>
        /// <param name="users"></param>
        public static void SaveUsers(List<UserModel> users) => IDataworker<UserModel>.SaveData(usersPath, users.OrderBy(x => x.Email).ToList());

        


    }
}
