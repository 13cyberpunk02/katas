using System;
using System.Collections.Generic;

public class Kata
{
  public static int[] GenerateRange(int min, int max, int step)
  {
     List<int> res = new List<int>();
     for(int i = min; i <= max; i += step)
       res.Add(i);
     return res.ToArray();
  }
}
