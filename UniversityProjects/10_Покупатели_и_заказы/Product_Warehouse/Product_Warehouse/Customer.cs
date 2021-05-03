using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Warehouse
{
    /// <summary>
    /// Класс, описывающий покупателя.
    /// </summary>
    [Serializable]
    class Customer:BaseUser
    {
       
        /// <summary>
        /// Полное имя пользователя.
        /// </summary>
        public FullUserName FullName { get; }

        /// <summary>
        /// Адресс.
        /// </summary>
        public string Adress { get; set; }

        public Customer(string login, string password):base(login, password)
        { }

        public Customer(string login, string password, FullUserName fullName, string adress ): base(login, password)
        {
            FullName = fullName;
            Adress = adress;
        }

        public override UserMode GetUserMode() => UserMode.Customer;
     
    }
}
