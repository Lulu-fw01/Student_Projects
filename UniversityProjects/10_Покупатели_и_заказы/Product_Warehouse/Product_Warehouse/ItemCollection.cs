using System;
using System.Collections;
using System.Collections.Generic;


namespace Product_Warehouse
{
    /// <summary>
    /// Коллекция для хранения продуктов.
    /// </summary>
    [Serializable]
    public class ItemCollection: IList<Item>, ICollection<Item>, IEnumerable
    {
        /// <summary>
        /// Продукты.
        /// </summary>
        List<Item> items;
        public ItemCollection()
        {
            items = new List<Item>();
        }

        /// <summary>
        /// Метод для получения строк для csv-файла.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public List<string[]> GetCsvRows(int num, string path)
        {
            var list = new List<string[]>(items.Count);
            try
            {
                foreach (var e in items)
                {
                    if (e.NumInStock <= num)
                        list.Add(e.GetCsvRow(path));
                }
            }
            catch {}
            return list;
        }

        public Item this[int index] { get => items[index]; set => items[index] = value; }

        public int Count => items.Count;

        public bool IsReadOnly => ((ICollection<Item>)items).IsReadOnly;

        public void Add(Item item)
        {
            items.Add(item);
            item.RemoveThisItem += RemoveItemFromCollection;
        }

        public void Clear() => items.Clear();
        
        /// <summary>
        /// Удаление элемента.
        /// </summary>
        /// <param name="item"></param>
        private void RemoveItemFromCollection(Item item)
        {
            try
            {
                items.Remove(item);
            }
            catch { }
        }

        public bool Contains(Item item) => items.Contains(item);
        
        /// <summary>
        /// Проверяет содержится ли в коллекции товар с артикулом sku.
        /// </summary>
        /// <param name="sku"></param>
        /// <returns></returns>
        public bool Contains(string sku)
        {
            foreach (var e in items)
            {
                if (e.SKU == sku)
                    return true;
            }
            return false;  
        }

       

        public void CopyTo(Item[] array, int arrayIndex) => items.CopyTo(array, arrayIndex);


        public IEnumerator GetEnumerator()
        {
            foreach (var e in items)
                yield return e;
        }

        public int IndexOf(Item item) => items.IndexOf(item);
        

        public void Insert(int index, Item item) => items.Insert(index, item);


        public bool Remove(Item item) => items.Remove(item);
        

        public void RemoveAt(int index) => items.RemoveAt(index);


        IEnumerator<Item> IEnumerable<Item>.GetEnumerator() => items.GetEnumerator();
        
        
    }
}
