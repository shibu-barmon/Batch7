using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using connectiontowebfrom.Repository;
using System.Data;

namespace connectiontowebfrom.BLL
{
    public class itemManager
    {
        itemRepository _itemRepository = new itemRepository();
        public bool Add(string itemName, double itemPrice)
        {
            return _itemRepository.Add(itemName, itemPrice);
        }
        public bool IsNameExist(string itemName)
        {
            return _itemRepository.IsNameExist(itemName);
        }
        public DataTable Display()
        {
            return _itemRepository.Display();
        }
        public bool Delete(int itemID)
        {
           
            return _itemRepository.Delete(itemID);
        }

        public bool Update(int itemID, string itemName, double itemPrice)
        {
            return _itemRepository.Update(itemID, itemName, itemPrice);
        }

        public DataTable Search(string itemName)
        {
            return _itemRepository.Search(itemName);
        }
    }
}
