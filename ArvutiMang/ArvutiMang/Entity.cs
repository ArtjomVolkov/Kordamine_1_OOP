using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvutiMang
{
    internal interface Entity
    {
        int punktideArv()
        {
            throw new NotImplementedException();
        }
        string nimetus()
        {
            throw new NotImplementedException();
        }
    }
    public class Item
    {
        public string uusitem;
        public Item(string uusitem):base()
        {
            this.uusitem = uusitem;
        }
        public void Info()
        {
            Console.WriteLine("");
        }

        public string AddItem()
        {
            string i = uusitem;
            return i;
        }
    }
}
