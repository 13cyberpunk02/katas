using System;

public static class Kata
{
  public static long SumCubes(long n)
  {
    long res = 0;
    for(long i = 0; i <= n; i++)
      {
        res = res + (i*i*i);
      }
    return res;
  }
}
