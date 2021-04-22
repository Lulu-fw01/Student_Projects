using System;
using System.Windows.Forms;

namespace Product_Warehouse
{
    /// <summary>
    /// Класс ошибки для описания ошибок в заполнении полей.
    /// </summary>
    public abstract class FieldException : Exception
    {

        Control control;
        protected FieldException() : base()
        { }

        /// <summary>
        /// Конструктор с двумя параметрами.
        /// </summary>
        /// <param name="ctrl">
        /// Контроллер.
        /// </param>
        /// <param name="str">
        /// Строка.
        /// </param>
        public FieldException(Control ctrl, string str) : base(str)
        {
            control = ctrl;
        }

        /// <summary>
        /// Объект, в поле которого допущена ошибка.
        /// </summary>
        public Control Control
        { get => control; }

    }
}
