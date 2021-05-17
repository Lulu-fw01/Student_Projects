
using System.Windows.Forms;

namespace Product_Warehouse
{
    /// <summary>
    /// Ошибка возникающая, если поле заполнено неерно.
    /// </summary>
    class FieldFilledIncorrectlyException: FieldException
    {
        public FieldFilledIncorrectlyException(Control ctrl, string message): base(ctrl, message)
        { }
    }
}
