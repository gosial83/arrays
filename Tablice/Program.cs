using System;

namespace Tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            //WypelnianieTablicy();
            KopiowanieLiczbDodatnich();

            void KopiowanieLiczbDodatnich()
            {
                /*
                Napisz program kopiujący z danej tablicy liczb całkowitych tab1 do nowej tablicy tab2
                wyłącznie wartości dodatnie. Obie tablice mają być jednowymiarowe o rozmiarze równym 10
                (czyli 10-elemetowe). Elementy pierwszej tablicy (tab1) należy wpisać w trakcie deklaracji
                tej tablicy.
                */

                int[] tab1 = new int[]{1,-1,2,-2,3,-3,4,-4,5,-5};
                int[] tab2 = new int[tab1.Length];
                for (int i=0; i<10; i++)
                {
                    if (tab1[i] > 0) tab2[i] = tab1[i];
                }
                Console.Write($"Dodatnie elementy to:");
                foreach (int x in tab2)
                {
                    Console.Write($"{x},");
                }
             }

            void WypelnianieTablicy()
            {
                /*
                Napisz program, który pozwoli zapełnić n–elementową tablicę jednowymiarową liczb
                całkowitych wartościami podanymi przez użytkownika.Na początku działania programu
                użytkownik podaje liczbę elementów tablicy, a następnie poszczególne wartości jej
                elementów.Po wypełnieniu całej tablicy program powinien wypisać je w oknie konsoli.
                */

                Console.Write("Podaj liczbę elementów: ");
                int liczbaElementow = Convert.ToInt32(Console.ReadLine());

                int[] tablicaLiczb = new int[liczbaElementow];

                for (int i = 0; i < liczbaElementow; i++)
                {
                    Console.Write($"Podaj element [{i}]: ");
                    tablicaLiczb[i] = Convert.ToInt32(Console.ReadLine());

                }

                Console.Write("Tablica zawiara następujące elementy: ");
                foreach (int liczba in tablicaLiczb)
                {
                    Console.Write(liczba + ", ");
                }
            }

        }
    }
}
