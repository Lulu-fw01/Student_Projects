using System;
using System.Windows.Forms;


namespace Product_Warehouse
{
    /// <summary>
    /// Ошибка, вылетающая, если есть незаполненное обязательное поле.
    /// </summary>
    public class RequiredFieldsAreEmptyException : FieldException
    {
        protected RequiredFieldsAreEmptyException() : base()
        { }

        /// <summary>
        /// Объект, поле которого пусто.
        /// </summary>
        Control control;

        public RequiredFieldsAreEmptyException(Control ctrl, string name) : base(ctrl, $"Required field {name} is empty.")
        {
        }

        
    }
}
