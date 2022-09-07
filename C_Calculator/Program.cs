using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" welcome to C# Calculator .. \n \n************************** ");
            Console.WriteLine("\nLets Start...");
            do
            {

                double num1 = 0;
                double num2 = 0;
                double result = 0;
                string calc = "+";
                Console.WriteLine("please choose an operation from the following list : \n");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : subtract");
                Console.WriteLine("\t* : multiplay");
                Console.WriteLine("\t/ : divition");
               calc =  Console.ReadLine(); 

                Console.WriteLine("\nEnter your first number : ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nEnter your second number : ");
                num2 = Convert.ToDouble(Console.ReadLine());
               
               
                switch (calc)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your resula : {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your resula : {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your resula : {num1} * {num2} = " + result);
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Your resula : {num1} / {num2} = " + result);
                        }
                        else if (num2 == 0)
                        {
                            Console.WriteLine(" Obs.. You can not divid by zero , please try Other number : ");
                            num2 = Convert.ToDouble(Console.ReadKey());
                        }
                        else
                        {
                            Console.WriteLine("if you want to close the calculator please Enter N ");
                        }
                        break;
                    default:
                        Console.WriteLine(" WRONG INPUT , Try again");
                        break;
                }
                Console.WriteLine("Do you want to continue useing the calculator? : (Y , N) :");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Thank you for using C# calculator .. Bye!");
        }


        }
    }
    
///<summary>
///int? availableTicket = null;
///int numberOfTicket;
///if(availableTicket = null){
///availableTicket =0 }     // numberOfTicket = availabletTicket ??0
/// else{numberOfTicket = availableTicket;     
///</summary>
