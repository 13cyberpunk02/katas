using System;
using System.Collections.Generic;

public static class Kata
{
  public static int DescendingOrder(int num)
  {
    string[] res = new string[num.ToString().Length];
    for(int i = 0; i < num.ToString().Length; i++)
      res[i] = num.ToString()[i].ToString();
    Array.Sort(res);
    Array.Reverse(res);
    return int.Parse(string.Join("", res));
  }
}
