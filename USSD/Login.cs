using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USSD;

namespace USSD
{
    class Login
    {


        public string Username { get; set; }
        public string Password { get; set; }
        
        public bool IsLoggedIn = false;
        public string RegUser { get; set; }
        public string RegPass { get; set; }
        public  bool Registerd { get; set; }
        public bool PassLength{ get; set; }
        //runs second
        /// <summary>
        /// User tries to login after registering
        /// </summary>
        public void Log()
        {
            Console.WriteLine("====|Login|====\n");
            Console.WriteLine("Enter your username");
            Username = Console.ReadLine();

            Console.WriteLine("===|Password|===\n");
            Console.WriteLine("Enter your password");
            Password = Console.ReadLine();

            
            //object of a class(Logging)
            Logging logging = new Logging();
            //call the confirmation method 
            logging.Comfirmation(Username,Password, RegPass, RegUser);
            
        }

       //runs first
       /// <summary>
       /// Registration of a user
       /// </summary>
        public void Reg()
        {
            Console.WriteLine("===|Register Your Credentials|===");
            Console.WriteLine("Register your username");
            RegUser = Console.ReadLine();

            Console.WriteLine("Register your password");
            RegPass = Console.ReadLine();

            if (RegPass.Length < 4 || RegPass.Length > 8)
            {
                     Console.WriteLine("Minimum password is between 4 and 8 characters ");
                     Console.WriteLine("Try again");
                     Console.WriteLine("Register your password");
                     RegPass = Console.ReadLine();
            }

        }
       
    }
}
