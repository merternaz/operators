using System;
using System.Collections.Generic;


namespace methods
{
    class Program
    {
         static void Main(string[] args)
        {
            int a=5,b=3,c=5;

            bool sonuc=a==c;
            Console.WriteLine(sonuc);
            sonuc=a>b;
            Console.WriteLine(sonuc);
            sonuc=b<c;
            Console.WriteLine(sonuc);
            sonuc=c<=b;
            Console.WriteLine(sonuc);

            /* aritmetikler */

            a+=1;
            Console.WriteLine(a);
            b*=3;
            Console.WriteLine(b);
            c/=5;
            Console.WriteLine(c);

            bool k=true;
            bool f=false,j=false;

            if(k && f){Console.WriteLine("double true");}
            if(k || f){Console.WriteLine("1-0 veya 0-1");}
            if(k != f){Console.WriteLine("not equal");}
            if(j == f){Console.WriteLine("equal");}
        }
    }
}