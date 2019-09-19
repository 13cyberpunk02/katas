using System;

public class Kata
{
  public static int SquareDigits(int n)
  {
    string res = "";
    for(int i = 0; i < n.ToString().Length; i++)    
      res += (int.Parse(n.ToString()[i].ToString()) * int.Parse(n.ToString()[i].ToString())).ToString();
    return int.Parse(res);
  }
}
