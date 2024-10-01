namespace Program
{
    public class Calculator
    {
        public static string Calculate(double num1, double num2, string oper)
        {
            switch (oper)
            {
                case "+":
                    return num1 + " + " + num2 + " = " + (num1 + num2);;
                case "-":
                    return num1 + " - " + num2 + " = " + (num1 - num2);
                case "*":
                    return num1 + " * " + num2 + " = " + (num1 * num2);
                case "/":
                if (num2 == 0)
                {
                    throw new ArgumentException("Cannot divide by zero");
                }
                else
                {
                    return num1 + " / " + num2 + " = " + (num1 / num2);
                }
                    
                default:
                    throw new ArgumentException();
            }
        }
    }
}