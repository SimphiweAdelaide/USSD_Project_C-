using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USSD;

namespace USSD
{
    class Selected
    {



        //Late class
        private int balance = 1500;
        public void Select(StringBuilder list)
        {
          
            for (int i = 0; i < list.Length; i++)
            {
                
                  string amount;
                Console.WriteLine("======Enter your choice======");
                string choice = Console.ReadLine();
                
                //string num = s.Substring(0, 1);
                if (choice == "1")
                {
                    Console.WriteLine("Your balance is: " + balance);
                    Console.WriteLine(List);
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Enter amount to send\n");
                    amount = Console.ReadLine();
                    Console.WriteLine("Enter account number\n");
                   
                    if (Console.ReadLine().Length > 10)
                    {
                        Console.WriteLine("You have entered a long account number");
                    }
                    else
                    {
                        if (int.Parse(amount) > balance)
                        {

                            Console.WriteLine("Insufficient  funds:\n Your balance is: {0}", balance);
                            Console.WriteLine("Enter the correct amount \n");
                            amount = Console.ReadLine();
                            while (int.Parse(amount) < balance)
                            {
                                balance = balance - int.Parse(amount);
                                Console.WriteLine("Your balance is: " + balance);
                                break;
                            }
                            
                        }
                        else
                        {
                            balance = balance - int.Parse(amount);
                            Console.WriteLine("Your balance is: " + balance);
                     
                        }
                        Console.WriteLine(List);
                    }


                }
                else if (choice == "3")
                {

                    Console.WriteLine("Enter amount to withdraw");
                    amount = Console.ReadLine();
                    
                    if (int.Parse(amount) > balance)
                    {
                        Console.WriteLine("Insufficient  funds:\n Your balance is: {0}", balance);
                        Console.WriteLine("Enter the correct amount");
                        amount = Console.ReadLine();
                        while (int.Parse(amount) < balance)
                        {
                            balance = balance - int.Parse(amount);

                            Console.WriteLine("Your balance is: " + balance);
                            break ;
                        }
                    }
                    else
                    {
                        balance = balance - int.Parse(amount);
                        Console.WriteLine("Your balance is: " + balance);
                      
                    }
                    Console.WriteLine(List);
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Thank you for using the app\n \nPress any key to exit!");
                    Console.ReadKey();
                    break;
                   
                }




            }   

            
        }
    
        public StringBuilder List { get; set; }
        public void Menus()
        {
            StringBuilder list = new StringBuilder();


            list.Append("1. Check balance\n");
            list.Append("2. Send Money\n");
            list.Append("3. Withdraw\n");
            list.Append("4. Exit/Cancel\n");
            Console.WriteLine(list);
            List = list;

            //Call select
            Selected sel = new Selected();
            Select(List);
        }

    }
}

