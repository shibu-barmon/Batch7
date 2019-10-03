using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee_Shop_withDB.Repository;
using System.Data;
using Coffee_Shop_withDB.Model;

namespace Coffee_Shop_withDB.BLL
{
    public class ItemManager
    {
        ItemsRepository _itemsRepository = new ItemsRepository();

        public bool ItemsAdd(Item item)
        {
            return _itemsRepository.ItemsAdd(item);
        }

        public bool IsNameExists(Item item)
        {
            return _itemsRepository.IsNameExists(item);
        }

        public bool Delete(int itemId)
        {
            return _itemsRepository.Delete(itemId);
        }

        public bool Update(string itemName, double itemPrice, int itemId)
        {
            return _itemsRepository.Update(itemName, itemPrice, itemId);
        }

        public DataTable Display()
        {
            return _itemsRepository.Display();
        }

        public DataTable Search(string itemName)
        {
            return _itemsRepository.Search(itemName);
        }

        public DataTable ItemCombo()
        {
            return _itemsRepository.ItemCombo();
        }
    }
}
