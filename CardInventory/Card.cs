using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardInventory
{
    public class Card
    {
        public string name, descrip;
        public int health, power;

        public Card(string _name, int _health, int _power, string _descrip)
        {
            name = _name;
            health = _health;
            power = _power;
            descrip = _descrip;
        }
    }
}
