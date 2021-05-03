using System;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace Product_Warehouse
{
    [Serializable]
    public class Item
    {
        /// <summary>
        /// Артикул.
        /// </summary>
        readonly string sku;
        /// <summary>
        /// Название продукта.
        /// </summary>
        readonly string name;
        /// <summary>
        /// Цена продукта.
        /// </summary>
        decimal price;
        /// <summary>
        /// Количество товара в наличии.
        /// </summary>
        int numInStock;
        /// <summary>
        /// Описание товара.
        /// </summary>
        string description;
        /// <summary>
        /// Изображение товара.
        /// </summary>
        Image image;

        /// <summary>
        /// Форма для редактирования продукта.
        /// </summary>
        [NonSerialized]
        EditItemForm eif;

        /// <summary>
        /// Артикул.
        /// </summary>
        [Required]
        public string SKU { get => sku; }
        /// <summary>
        /// Название товара.
        /// </summary>
        [Required]
        public string Name { get => name; }
        /// <summary>
        /// Цена за штуку.
        /// </summary>
        public decimal Price
        {
            get => price;
            set
            {
                price = value;
                // Установка цены у контроллера.
                if(control != null)
                    control.SetPrice(value);
            }
        }
        /// <summary>
        /// Количество оставшихся экземпляров товара.
        /// </summary>
        public int NumInStock
        {
            get => numInStock;
            set
            {
                numInStock = value;
                // Установка параметра "количество в наличии" у контроллера.
                if (control != null)
                    control.SetNumInStock(value);
            }
        }

        /// <summary>
        /// Дополнительное описание товара.
        /// </summary>
        public string Description
        {
            get => description;
            set
            {
                description = value;
                // Установка описания у контроллера.
                if (control != null)
                    control.SetDescription(value);
            }
        }
        /// <summary>
        /// Изображение.
        /// </summary>
        public Image Image
        {
            get => image;
            set
            {
                image = value;
                // Установка изображения у контроллера.
                if (control != null)
                    control.SetImage(value);
            }
        }

        /// <summary>
        /// Объект для визуализации продукта.
        /// </summary>
        [NonSerialized]
        ProductControl control;

        /// <summary>
        /// Продукт.
        /// </summary>
        /// <param name="sku">
        /// Артикул.
        /// </param>
        /// <param name="name">
        /// Название.
        /// </param>
        public Item(string sku, string name)
        {
            this.sku = sku;
            this.name = name;
            control = new ProductControl(sku, name);
            control.RemoveThisControl += GetRemoveRequest;
            control.EditButtonClicked = () => { ShowEditForm(); };
        }


        /// <summary>
        /// Метод, возвращающий объект визуализирубщий продукт. 
        /// </summary>
        /// <returns></returns>
        public ProductControl GetControl()
        {
            try
            {
                if (control == null)
                    SetFullControl();

                return control;
            }
            catch { return null; }
        }

        /// <summary>
        /// Метод для настройки элемента отображения.
        /// Вызываться должен, если данные загрузили в программу.
        /// </summary>
        private void SetFullControl()
        {
            control = new ProductControl(sku, name);
            control.SetPrice(Price);
            control.SetNumInStock(numInStock);
            if (description != null)
                control.SetDescription(description);
            if (image != null)
                control.SetImage(Image);
            control.RemoveThisControl += GetRemoveRequest;
            control.EditButtonClicked = () => { ShowEditForm(); };
        }

        /// <summary>
        /// Метод, который используется, если на контроллере была нажата кнопку delete.
        /// </summary>
        /// <param name="pc"></param>
        private void GetRemoveRequest(ProductControl pc) => RemoveThisItem?.Invoke(this);

        /// <summary>
        /// Событие, показывающее, что надо удалить данный продукт.
        /// </summary>
        public Action<Item> RemoveThisItem;

        /// <summary>
        /// Получение массива строк для записи в csv файл.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public string[] GetCsvRow(string path) => new[] {path, sku, name, numInStock.ToString() };

        /// <summary>
        /// Вывод формы для редактирования данного продукта.
        /// </summary>
        private void ShowEditForm()
        {
            if (eif == null)
            {
                eif = new EditItemForm();
            }
            eif.ShowDialog(this);
        }

        
    }

    
}
