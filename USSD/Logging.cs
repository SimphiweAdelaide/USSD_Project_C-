using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USSD;

namespace USSD
{
    class Logging
    {
        public bool Logged { get; set; }
        Login log = new Login();
        Selected sel = new Selected(); 
        //runs 3rd
        /// <summary>
        /// Checks if the login credentials exist in the database
        /// </summary>
    
        public void Comfirmation(string username, string password, string regPassword, string regUsername)
        {
            Menu menu1 = new Menu();
            bool logged = false;
            if (username == regUsername)
            {
                if (password == regPassword)
                { 
                    Console.WriteLine("You are logged in");
                   
                    Console.WriteLine("===Menus===");
                    sel.Menus();
                }
                else
                {
                    Console.WriteLine("Username or password is not correct");
                }
            }
            else
            {
                Console.WriteLine("Username or password is not correct"); 
            }
            Logged = logged;
        }
    }
}
