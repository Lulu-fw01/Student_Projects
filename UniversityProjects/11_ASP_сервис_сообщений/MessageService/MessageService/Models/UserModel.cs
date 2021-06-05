using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MessageService.Models
{
    [Serializable]
    public class UserModel
    {

        /// <summary>
        /// Имя пользователя.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Адрес электронной почты.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Id пользователя.
        /// </summary>
        public int ID { get; set; }

        public UserModel(string name, string email)
        {
            Name = name;
            Email = email;
            ID = 0;
        }

    }
}
