using System;

namespace Delegates_Func__Action_Lambda_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleCalculator simpleCalculator = new SimpleCalculator();
            AtomicCalculator atomicCalculator = new AtomicCalculator();
            atomicCalculator.GetNumberFromUser = simpleCalculator.NumberGetter;
            atomicCalculator.MenuPrinter = simpleCalculator.PrintMenu;
            atomicCalculator.GetUserChoise = simpleCalculator.GetUserChoice;
            atomicCalculator.Calculate = simpleCalculator.Calculate;
            atomicCalculator.ResultPrinter = simpleCalculator.PrintResultNicely;
            atomicCalculator.ResultPrinter += num => Console.WriteLine($"The result is: {num}");
            atomicCalculator.Run();







        }
    }
}
