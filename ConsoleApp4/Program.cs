using System;

namespace revrsethestring
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(ReverseString("the sky is blue"));



        }
        public static string ReverseString(string text)
        {
            char[] sArr = text.ToCharArray();
            Array.Reverse(sArr);
            return new string(sArr);
                }

            //for(int i=sArr.Length-1;i>-1;i--)
            //{
            //    reverse += sArr[i];
            //}
            //return reverse;
        }
    }


