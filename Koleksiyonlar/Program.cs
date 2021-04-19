using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {  //Dizileri genişletemiyoruz.Yeni bir eleman eklerken sorun çıkarıyor.New->yeni referans adresi
        //eski değerleri kaybediyoruz
        static void Main(string[] args)
        {
            List <string> isimler2 = new List<string> {"E","M","K","E"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("H");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
