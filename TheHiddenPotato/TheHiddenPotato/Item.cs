using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHiddenPotato
{
    public class Item
    {
        public string itemName;
        public string itemType;
        public int itemPower;

    }

    public class HealthPotion : Item
    {
        public HealthPotion(string _type, int _power)
        {
            itemType = _type;
            itemName = "Health Potion";
        }
    }
}
