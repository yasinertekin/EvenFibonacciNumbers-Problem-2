using System;
using System.Collections;
using System.Xml.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ÇiftSayilar = new ArrayList();

            int BirinciSayi = 1;
            int İkinciSayi = 1;
            int ÜçüncüSayi = 0;
            int toplam = 0;

            while (ÜçüncüSayi < 4000000)
            {

                if (ÜçüncüSayi % 2 == 0)
                {
                    toplam = toplam + ÜçüncüSayi;
                }
                ÜçüncüSayi = BirinciSayi + İkinciSayi;
                BirinciSayi = İkinciSayi;
                İkinciSayi = ÜçüncüSayi;
                

            }
            Console.WriteLine(toplam);
            


        }
    }
}