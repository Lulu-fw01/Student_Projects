using System.Windows.Forms;

namespace Product_Warehouse
{
    /// <summary>
    /// Ошибка, возникающая, если в строке есть запрещенный символ.
    /// </summary>
    class ExtraCharacterInTheFieldException: FieldException
    {
        protected ExtraCharacterInTheFieldException() : base()
        { }

        /// <summary>
        /// Конструктор с двумя параметрами.
        /// </summary>
        /// <param name="ctrl">
        /// Контроллер.
        /// </param>
        /// <param name="symbol">
        /// Запрещенный символ.
        /// </param>
        public ExtraCharacterInTheFieldException(Control ctrl, char symbol) : base(ctrl, $"Forbidden character <{symbol}> in the field")
        { }

        
        
    }
}
