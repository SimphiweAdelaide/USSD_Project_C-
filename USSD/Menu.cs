using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USSD
{
    class Menu
    {
        public int balance{ get; set; }
        public  StringBuilder List { get; set; }
        public void Menus()
        {
           var list = new StringBuilder();

            
            list.Append("1. Check balance\n");
            list.Append("2. Send Money\n");
            list.Append("3. Withdraw\n");
            list.Append("4. Exit/Cancel\n");
            Console.WriteLine(list);
            List = list;

            //Call select
           Selected sel = new Selected();
           sel.Select(List);
        }

    }
}
