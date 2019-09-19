using System;

    public class Kata
    {
        public static int[] Get_size(int w,int h,int d)
        {
            int[] res = new int[2];
            res[0] = 2 *(h * w) + 2 * (h * d) + 2 * (w * d); 
            res[1] = h * (w * d);
            return res;
        }
    }
