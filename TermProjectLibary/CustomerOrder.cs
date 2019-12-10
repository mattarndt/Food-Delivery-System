using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProjectLibary
{
    public class CustomerOrder
    {
        string ItemName = "";
        float ItemPrice = 0;
        string ItemType = "";

        public CustomerOrder()
        {

        }
        public CustomerOrder(string name, float price, string type)
        {
            this.ItemName = name;
            this.ItemPrice = price;
            this.ItemType = type;
        }
        public string Name
        {
            get { return ItemName; }
            set { ItemName = value; }
        }
        public float Price
        {
            get { return ItemPrice; }
            set { ItemPrice = value; }
        }
        public string Type
        {
            get { return ItemType; }
            set { ItemType = value; }
        }
    }
}