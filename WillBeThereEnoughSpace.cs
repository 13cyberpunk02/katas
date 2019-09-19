using System;

public static class Kata
{
  public static int Enough(int cap, int on, int wait)
  {
    int res = cap - (on + wait);
    if(res >= 0)
      return 0;
    else
      return -1 * res;
  }
}
