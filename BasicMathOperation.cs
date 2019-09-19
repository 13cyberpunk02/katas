namespace Solution
{
  public static class Program
  {
    public static double basicOp(char operation, double value1, double value2)
    {
       double res = 0;
       switch(operation)
       {
         case '+':
          res = value1 + value2;
          break;
         case '-':
          res = value1 - value2;
          break;
         case '*':
          res = value1 * value2;
          break;
         case '/':
          res = value1 / value2;
          break;
         default:
           break;
       }
       return res;
    }
  }
}
