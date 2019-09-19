using System;

public class Line
    {
        public static string Tickets(int[] peopleInLine)
        { 
           int a25 = 0, a50 = 0;
           for(int i = 0; i < peopleInLine.Length; i++)
           {
              if(peopleInLine[i] == 25)
              {
                a25 += 1;
              }
             if(peopleInLine[i] == 50)
             {
                a25 -= 1; a50 += 1;
             }
             if(peopleInLine[i] == 100)
             {
                if(a50 == 0 && a25 >= 3)
                {
                  a25 -= 3;
                }
                else
                {
                  a25 -= 1; a50 -= 1;
                }
             }
             if(a25 < 0 || a50 < 0)
             {
               return "NO";
             }
          }
          return "YES";
        }
    }
