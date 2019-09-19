using System;
using System.Collections.Generic;

public static class Kata
{
  public static List<int> PascalsTriangle(int n) 
  { 
    int c = 1;
    List<int> ret = new List<int>();
    for(int i = 0; i < n; i++)
    {
      for(int j = 0; j <= i; j++)
      {
        if(j == 0 || i == 0)
        {
          c = 1;
          ret.Add(c);
        }
        else
        {
          c = c * (i - j + 1) / j;
          ret.Add(c);
        }
      }
    }
    return ret;
  }
} 
