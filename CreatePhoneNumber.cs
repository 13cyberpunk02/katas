public class Kata
{
  public static string CreatePhoneNumber(int[] numbers)
  {
    string res = "";
    for(int i = 0; i < numbers.Length; i++)
    {
      res = StampNum(numbers[i].ToString(), res);
    }
    return res;
  }
  public static string StampNum(string l, string num)
  {
    if(num.Length == 0)
      num += "(";
    else if(num.Length == 4)
      num += ") ";
    else if(num.Length == 9)
      num += "-";
    return num += l;
  }
}
