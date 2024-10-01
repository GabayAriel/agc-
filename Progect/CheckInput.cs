namespace Program
{
    public class CheckInput
    {
        public static double CheckTypeNumber(string input)
        {
            double number;
            if (double.TryParse(input, out number))
            {
                return number;
            } 
            else
            {
                throw new ArgumentException("is not number");
            }
        }
   
        public static string CheckTypeOperator(string oper)
        {
            if (oper == "+" || oper == "-" || oper == "*" || oper == "/")
            {
                return oper;
            }
            else
            {
                throw new ArgumentException("is not operator");
            }  
        }
    }
}