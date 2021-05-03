using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Warehouse
{
    /// <summary>
    /// Ошибка, покаывающаяя, что данный товар уже существует.
    /// </summary>
    class ThisItemIsAlreadyExistsException: Exception
    {
        public ThisItemIsAlreadyExistsException(string message): base(message)
        { }
    }
}
