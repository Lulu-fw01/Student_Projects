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

        /// <summary>
        /// Номер телефона пользователя.
        /// </summary>
        public string PhoneNumber { get; set; }
        public Customer(string login, string password):base(login, password)
        { }

        public Customer(string login, string password, string phoneNumber, FullUserName fullName, string adress ): base(login, password)
        {
            PhoneNumber = phoneNumber;
            FullName = fullName;
            Adress = adress;
        }

        public override UserMode GetUserMode() => UserMode.Customer;
     
    }
}
