using System;

namespace longestword
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            int i,length,max=0;
            int n = 0;
            Console.WriteLine("enter the string:");
            text=Console.ReadLine();
            string[] word;
                word= text.Split(' ');
            length = word.Length;
          //  string words = "";
           // int cntr = 0;
          for (i=0; i<length;i++)
            {
                if(word[i].Length>max)
                {
                    max = word[i].Length;
                    n = i;
                }
            }
            Console.WriteLine("long string:{0} \n count character :{1} ",word[n],max);
            Console.Read();
        }
    }
}
