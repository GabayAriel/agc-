namespace Program
{
    class Program
    {
        public static void Main(string[] srgs)
        {
            Console.WriteLine("pls enter a number:");
            double num1 = CheckInput.CheckTypeNumber(Console.ReadLine());
            //
            Console.WriteLine("pls enter a operator:");
            string oper = CheckInput.CheckTypeOperator(Console.ReadLine());
            //
            Console.WriteLine("pls enter a number:");
            double num2 = CheckInput.CheckTypeNumber(Console.ReadLine());
            //
            string result = Calculator.Calculate(num1, num2, oper);
            Console.WriteLine("result:\n" + result);
        }
    }
}


