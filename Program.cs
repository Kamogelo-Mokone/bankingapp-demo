using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class Program
    {
        enum Menu
        {
            Send_Money = 1,
            Buy_Airtime,
            Check_Balance,
            Exit
        }


        static bool Logon()
        {
            
            bool Login = false;
            bool Continue = true;
            int Counter = 0;

            while (Continue)
            {
                Console.Clear();
                Console.WriteLine("Please enter a username: ");
                if(Console.ReadLine() == "abcd")
                {
                    Console.WriteLine("Please enter your password: ");

                    if (Console.ReadLine() == "1234")
                    {
                        Login = true;
                        Continue = false;
                       
                    }
                    else
                    {
                        Console.WriteLine("The password provided is wrong");
                        Counter++;
                        Console.ReadLine();
                    }

                }
                else 
                {
                    Console.WriteLine("The username provided is wrong");
                    Counter++;
                    Console.ReadLine();
                }

                if (Counter== 3)
                {
                    Continue = false;
                    Console.WriteLine("You have tried to log in too many times");
                        Console.ReadLine(); 
                }          
            }

            return Login;
        }

        static void Display()
        {
            
            bool Login = Logon();
            if (Login == true)
            {
                bool Continue = true;
                int Amount = 600;
                while (Continue)
                {
                    Console.Clear();
                    Console.WriteLine("1. Send Money");
                    Console.WriteLine("2. Buy Airtime");
                    Console.WriteLine("3. Check Balance");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("Please select an option:");
                    int choice = int.Parse(Console.ReadLine());
                    Menu Main = (Menu)choice;
                    int Value;
                    switch (Main)
                    {
                        case Menu.Send_Money:
                            Console.WriteLine("How much do you want to send?");
                            Value = int.Parse(Console.ReadLine());
                            Amount -= Value;
                            Console.WriteLine("The amount of money you have left is: "+Amount);
                            Console.ReadLine();
                            break;
                        case Menu.Buy_Airtime:
                            Console.WriteLine("How much airtime do you want to buy?");
                            Value = int.Parse(Console.ReadLine());
                            Amount -= Value;
                            Console.WriteLine("The amount of money you have left is: " + Amount);
                            Console.ReadLine();
                            break;
                        case Menu.Check_Balance:
                            Console.WriteLine("Your balance is:" + Amount);
                            Console.ReadLine();
                            break;
                        case Menu.Exit:
                            Continue = false;
                            break;
                        default:
                            break;
                    }
                }
            }
        }



        static void Main(string[] args)
        {
            Display();

        }
    }
}
