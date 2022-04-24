using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Func__Action_Lambda_HW
{
    public class SimpleCalculator
    {

        public int NumberGetter()
        {
            Console.WriteLine("Enter number");
           int number = int.Parse(Console.ReadLine());
            if (number > 0)
                return number;
            else
                NumberGetter();
            return 0;

        }
        public void PrintMenu()
        {
            Console.WriteLine("1.+\n2.-\n3.*\n4./");
        }

       public int GetUserChoice()
        {
            Console.WriteLine("Enter number between 1 to 4");
            int number = int.Parse(Console.ReadLine());
            if (number > 0 && number < 5)
                return number;
            else
                GetUserChoice();
            return 0;
        }

        public double Calculate(int num1, int num2, int oper)
        {
            
                switch (oper)
                {
                    case 1:
                        return num1 + num2;
                    case 2:
                        return num1 - num2;
                    case 3:
                        return num1 * num2;
                    case 4:
                        return num1 / num2;
                    default:
                        return 0;

                }
            
           
            
           
              
        }
        public void PrintResultNicely(double number)
        {
            Console.WriteLine($"******{number}******");
              
        }


    }
}
