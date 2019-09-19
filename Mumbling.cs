using System;

public class Accumul 
{
	public static String Accum(string s) 
  {
     string res = "";
     for(int i = 0; i < s.Length; i++)
     {
       for(int j = 0; j <= i; j++)
       {
         if(j == 0)
           res += s[i].ToString().ToUpper();
         else
           res += s[i].ToString().ToLower();           
       }
       if(i != s.Length -1)
        res += "-";
     }
     return res;
  }
}
