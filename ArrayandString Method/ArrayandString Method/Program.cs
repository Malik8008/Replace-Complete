using System;

namespace ArrayandString_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "bU tasKI metHodla yAzmAliSiz";
            string newsentence = sentence.Replace("bU tasKI metHodla yAzmAliSiz","Bu Taski Methodla Yazmalisiz");                        
            Console.WriteLine(newsentence);
        }
    }
}
