using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Product_Warehouse
{
    /// <summary>
    /// Класс описывающий администратора.
    /// </summary>
    [Serializable]
    public class Administrator :BaseUser
    {
        public Administrator(string login, string password): base(login, password)
        { }

        public override UserMode GetUserMode() => UserMode.Adminisrator;
        
    }
}
