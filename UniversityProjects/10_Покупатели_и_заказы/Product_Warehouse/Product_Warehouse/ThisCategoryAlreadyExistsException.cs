using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Warehouse
{
    /// <summary>
    /// Ошибка показывающая, что категория с данным именем уже существует.
    /// </summary>
    class ThisCategoryAlreadyExistsException: Exception
    {
        public ThisCategoryAlreadyExistsException(string m): base(m)
        { }

        public ThisCategoryAlreadyExistsException() : base()
        { }
    }
}
