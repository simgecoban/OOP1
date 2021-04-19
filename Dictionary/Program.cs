using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> meyveler = new MyDictionary<string, string>();
            meyveler.Add("Elma", "Kırmızı");
            meyveler.Add("Muz", "Sarı");
            Console.WriteLine(meyveler.kLength);
            Console.WriteLine(meyveler.vLength);

            foreach ( var meyve in meyveler.key)
            {
                Console.WriteLine(meyve);
            }

            foreach (var meyve in meyveler.value)
            {
                Console.WriteLine(meyve);
            }
        }
    }
}
