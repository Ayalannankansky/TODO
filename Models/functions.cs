using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_ToDo_Ayala.Models
{
    public class functions
    {
      public static string  reverseString(string value)
        {
            char ezer;
            char[] arrValue = value.ToCharArray();
            for (int i = 0 ,j= value.Length-1; i <= (value.Length) / 2;i++,j--)
            {
                ezer = arrValue[i];
                arrValue[i] = arrValue[j];
                arrValue[j] = ezer;

            }
            return new string(arrValue);
           

        }
    }
}