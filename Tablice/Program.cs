using System;

namespace Tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            //WypelnianieTablicy();
            //KopiowanieLiczbDodatnich();
            //InformacjeOtablicy();
            //LiczbaLiczbPierwszych();
            //KopiowanieTablic();
            //TablicaDwuwymiarowa();
            //DodawanieMacierzy();
            //DniTygodnia();
            //LiczbaWyrazow();
            //DataSlownie();
            //WystepowanieZnakow();
            //WierszeIznakiWwierszach();
            //PowieloneSlowa();
            //ObliczenieDaty();
            Szyfrowanie();

            void LosowanieLiczb(int[] tab, int rozmiar)
            {
                Random rand = new Random();
                for (int i = 0; i < rozmiar; i++)
                {
                    tab[i] = rand.Next(1, 1000);
                }
            }

            void Szyfrowanie()
            {
                string klucz = "GADERYPOLUKI";
                Console.WriteLine("Klucz szyfrujący: GA-DE-RY-PO-LU-KI");
                Console.Write("Podaj tekst do zaszyfrowania: ");
                string teskstDoZaszyfrowania = Console.ReadLine();
                string tekstZaszyfrowany = String.Empty;

                for (int i = 0 ; i < teskstDoZaszyfrowania.Length; i++  )
                {
                    if ((klucz.IndexOf(teskstDoZaszyfrowania[i]) == 0) || (klucz.IndexOf(teskstDoZaszyfrowania[i]) % 2 == 0))
                    {
                        tekstZaszyfrowany += klucz[klucz.IndexOf(teskstDoZaszyfrowania[i]) + 1];
                        Console.WriteLine($"Znak do zaszyfrowania: {teskstDoZaszyfrowania[i]} - po zaszyfrowaniu: {klucz[klucz.IndexOf(teskstDoZaszyfrowania[i]) + 1]}");
                    }
                    else if (klucz.IndexOf(teskstDoZaszyfrowania[i]) == -1)
                    {
                        tekstZaszyfrowany += teskstDoZaszyfrowania[i];
                        Console.WriteLine($"Znak do zaszyfrowania: {teskstDoZaszyfrowania[i]} - po zaszyfrowaniu: {teskstDoZaszyfrowania[i]}");    
                    }

                    else //if   ((klucz.IndexOf(teskstDoZaszyfrowania[i]) != 0) && (klucz.IndexOf(teskstDoZaszyfrowania[i]) % 2 != 0) )                
                    {
                        tekstZaszyfrowany += klucz[klucz.IndexOf((teskstDoZaszyfrowania[i])) - 1];
                        Console.WriteLine($"Znak do zaszyfrowania: {teskstDoZaszyfrowania[i]} - po zaszyfrowaniu: {klucz[klucz.IndexOf(teskstDoZaszyfrowania[i]) -1]}");
                    }
                        
                }

                Console.WriteLine($"Tekst po zaszyfrowaniu to: {tekstZaszyfrowany}");

            }

            void ObliczenieDaty()
            {
                /*
                W danej firmie środki trwałe mają identyfikatory złożone z kilku liter, myślnika oraz
                czterech cyfr. Te cztery cyfry to rok zakupu danego środka trwałego. Przykładowe
                identyfikatory to: KOMG-2002, BH-2010. Napisz program, który deklaruje 5-cio elementową
                tablicę typu string dla środków trwałych, którą należy zainicjalizować przykładowymi
                identyfikatorami w czasie deklaracji. Program ma dla każdego środka trwałego podać liczbę
                lat, jakie upłynęły od jego zakupu.
                */

                string[] SrodkiTrwale = { "KOMG - 2002", "BH - 2010", "KMXG - 1999", "HB - 2000", "HH - 2020" };

                int rok_rodukcji = 0;
                int rok_biezacy = DateTime.Now.Year;

                for (int i = 0; i < SrodkiTrwale.Length; i++)
                {
                    rok_rodukcji = Convert.ToInt32(SrodkiTrwale[i].Substring(SrodkiTrwale[i].Length - 4));
                    
                    Console.WriteLine($"Srodek trwały: {SrodkiTrwale[i]} - od zakupu mineło {rok_biezacy-rok_rodukcji} lat");
                }
            
            
            
            }





            void PowieloneSlowa()
            {
                //Napisz program, który przeanalizuje dany łańcuch pod kątem wielokrotnego występowania słów w tekście.
                
                string tekst = "Kiedy idzie się po miód z balonikiem, to trzeba się starać, żeby pszczoły nie wiedziały, po co się idzie – odpowiedział Puchatek";
                
                Console.WriteLine($"Tekst: {tekst}");

                int liczbaSlow = 0;
                for (int i = 0; i < tekst.Length; i++)
                {
                    if (tekst[i] == ' ') liczbaSlow++;
                }
                liczbaSlow++;

                string[] tablicaSlow = new string[liczbaSlow];
                int[] tablicaWystapien = new int[liczbaSlow];
                string slowo = "";
                string nowyTekst = "";

                int indexSpacji = -1;

                for (int j = 0; j< liczbaSlow+1; j++)
                {
                    if (tekst.IndexOf(" ") >= 0)
                    {
                        indexSpacji = tekst.IndexOf(" ");
                        slowo = tekst.Substring(0, indexSpacji);

                        nowyTekst = tekst.Substring((indexSpacji + 1), tekst.Length - (indexSpacji + 1));

                        for (int i = 0; i < liczbaSlow; i++)
                        {
                            if (tablicaSlow[i] == slowo)
                            {
                                tablicaWystapien[i]++;
                                break;
                            } 
                            else if (tablicaSlow[i] == null)
                            {
                                tablicaSlow[i] = slowo;
                                tablicaWystapien[i]++;
                                break;
                            }
                        }
                        tekst = nowyTekst;
                    }
                    
                    else if (tekst.IndexOf(" ") == -1)
                    {
                        slowo = tekst;
                        for (int k = 0; k < liczbaSlow; k++)
                        {

                            if (tablicaSlow[k] == slowo)
                            {
                                tablicaWystapien[k]++;
                                break;
                            }
                            
                            else if (tablicaSlow[k] == null)
                            {
                                tablicaSlow[k] = slowo;                           
                                break;
                            }
                        }
                    
                    }
                }
 
                for (int i = 0; i < liczbaSlow; i++)
                {
                    if (tablicaWystapien[i]>1) Console.Write($"{tablicaSlow[i]} - {tablicaWystapien[i]} razy, ");
                }

            }

            void WierszeIznakiWwierszach()
            {
                /*
                Napisz program, który dla zadeklarowanej niżej zmiennej łańcuchowej wyświetli jej
                zawartość, poda liczbę wierszy oraz poda liczbę znaków w każdym wierszu.
                */

                string tekst = "W parę godzin później, gdy noc zbierała się do odejścia,\n" +
                                "Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
                                "To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
                                "co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
                                "wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł.";
                

                int liczbaWierszy = 0;              

                for (int i = 0; i < tekst.Length; i++)
                {  
                    if (tekst[i] == '\n') liczbaWierszy++;
                }
                liczbaWierszy++;

                int[] znakiWwierszach = new int[liczbaWierszy];

                int wiersz = 0;

                
                for (int i = 0; i < tekst.Length; i++)
                {
                    if (tekst[i] != '\n')
                        (znakiWwierszach[wiersz])++;
                    else
                        wiersz++;  
                }
                

                Console.WriteLine(tekst);
                Console.WriteLine($"\nPowyższy tekst składa się z {liczbaWierszy} wierszy");

                for (int i = 0; i < liczbaWierszy; i++)
                {
                    Console.WriteLine($"Wiersz {i+1} słada się z {znakiWwierszach[i]} znaków");
                }


            }

            void WystepowanieZnakow()
            {
                /*
                Napisz program analizujący częstość występowania poszczególnych znaków w
                łańcuchu znaków wprowadzonym przez użytkownika. Np. dla wprowadzonego tekstu
                „abrakadabra” program powinien wyświetlić informacje: a – 5, b – 2, r – 2, k – 1, d – 1.
                */
                Console.Write("Wpisz zdanie: ");
                string zdanie = Console.ReadLine();
             
                char[] znaki = new char[26];
                int[] ilosci = new int[26];

                if (zdanie[0] == 0) Console.WriteLine("pusto");

                               
                for (int i = 0; i < zdanie.Length; i++)
                {
                    for (int j = 0; j < 26; j++)
                    {
                        if (zdanie[i] == znaki[j])
                        {
                            ilosci[j]++;
                            break;
                        }
                        
                        if (znaki[j] == 0)
                        {
                            znaki[j] = zdanie[i];
                            ilosci[j]++;
                            break;
                        }
                    }
                }

                for (int i = 0; i < 26; i++)
                {
                    if (ilosci[i]!=0) Console.Write("{0} - {1}, ", znaki[i], ilosci[i]);
                }
                

            }

            void DataSlownie()
            {
                /*
                Napisać program, który pobierze datę w formacie DD-MM-RRRR, z której pobierze
                miesiąc i wyświetli jego nazwę słownie.
                */
                Console.Write("Wpisz date w formacie DD-MM-RRRR: ");
                string data = Console.ReadLine();
                string miesiac = data.Substring(3, 2);
                Console.WriteLine(miesiac);

                switch (miesiac)
                { 
                    case "01":
                        Console.WriteLine("Styczń");
                        break;
                    case "02":
                        Console.WriteLine("Luty");
                        break;
                    case "03":
                        Console.WriteLine("Marzec");
                        break;
                    case "04":
                        Console.WriteLine("Kwiecień");
                        break;
                    case "05":
                        Console.WriteLine("Maj");
                        break;
                    case "06":
                        Console.WriteLine("Czerwiec");
                        break;
                    case "07":
                        Console.WriteLine("Lipiec");
                        break;
                    case "08":
                        Console.WriteLine("Sierpień");
                        break;
                    case "09":
                        Console.WriteLine("Wrzesień");
                        break;
                    case "10":
                        Console.WriteLine("Październik");
                        break;
                    case "11":
                        Console.WriteLine("Listopad");
                        break;
                    case "12":
                        Console.WriteLine("Grudzień");
                        break;
                    default:
                        Console.WriteLine("Podana data jest błędna");
                        break;
                }

        }

            void LiczbaWyrazow()
            {
                /*
                Napisz program obliczający liczbę wyrazów w łańcuchu znaków wprowadzonym przez
                użytkownika. Należy przyjąć, że wyrazy to ciągi znaków rozdzielone spacją.
                */
                    Console.Write("Wpisz zdanie: ");
                    string zdanie = Console.ReadLine();
                    int liczbaWyrazow = 0;
                    for (int i = 1; i < zdanie.Length; i++)
                        if ( (zdanie[i] == ' ') && (zdanie[i-1]!=' ') ) liczbaWyrazow++;

                    Console.WriteLine(liczbaWyrazow);
             }

            void DniTygodnia()
            {
                /*
                Uzupełnij poniższy kod programu o wszystkie dni tygodnia i przy użyciu pętli wyświetl
                zawartość tablicy: w każdym wierszu dany dzień tygodnia w trzech językach (polskim,
                angielskim, niemieckim).
                */

                string[,] dniTygodnia;
                dniTygodnia = new string[7, 3]; 
                dniTygodnia[0, 0] = "poniedzialek";
                dniTygodnia[1, 0] = "wtorek";
                dniTygodnia[2, 0] = "środa";
                dniTygodnia[3, 0] = "czwartek";
                dniTygodnia[4, 0] = "piątek";
                dniTygodnia[5, 0] = "sobota";
                dniTygodnia[6, 0] = "niedziela";
                dniTygodnia[0, 1] = "monday";
                dniTygodnia[1, 1] = "tuesday";
                dniTygodnia[2, 1] = "wednesday";
                dniTygodnia[3, 1] = "thursday";
                dniTygodnia[4, 1] = "Friday";
                dniTygodnia[5, 1] = "saturday";
                dniTygodnia[6, 1] = "sunday";
                dniTygodnia[0, 2] = "montag";
                dniTygodnia[1, 2] = "dienstag";
                dniTygodnia[2, 2] = "mittwoch";
                dniTygodnia[3, 2] = "monnerstag";
                dniTygodnia[4, 2] = "freitag";
                dniTygodnia[5, 2] = "samstag";
                dniTygodnia[6, 2] = "sonntag";

                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 3; j++)
                        Console.Write("{0,14} |", dniTygodnia[i, j]);
                    Console.WriteLine();
                }

            }



            void DodawanieMacierzy()
            {
                /*
                Napisz program, który dodaje dwie macierze o rozmiarze 2 x 3. Elementy macierzy
                należy umieścić w tablicach dwuwymiarowych w trakcie deklaracji. Program ma wyświetlić macierz wynikową.
                */

                int[,] A = {{ 1, 2, 3 },
                              { 4, 5, 6 } };

                int[,] B = {{ 1, 2, 3 },
                              { 4, 5, 6 } };
                int[,] C = new int[3, 3];

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        C[i, j] = A[i, j] + B[i, j];
                        Console.Write($"{C[i, j]}, ");
                    }
                    Console.WriteLine();
                }

            }

            void TablicaDwuwymiarowa()
            {
                /*
                Napisz program, który deklaruje i inicjalizuje dwuwymiarową tablicę liczb
                rzeczywistych o rozmiarze 5 x 5. Program ma wyświetlić elementy tablicy (wiersz po
                wierszu), a następnie wyświetlić sumę elementów znajdujących się na głównej przekątnej
                tablicy (główna przekątna – od elementu o indeksach 0,0 do elementu o indeksach n,n).
                */
                int[,] tab = {{ 1, 2, 3, 4, 5 }, 
                              { 1, 2, 3, 4, 5 }, 
                              { 1, 2, 3, 4, 5 }, 
                              { 1, 2, 3, 4, 5 }, 
                              { 1, 2, 3, 4, 5 } };
                int sum = 0;

                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 5; j++)
                        if (i == j) sum += tab[i, j];
                Console.WriteLine(sum);


            }

            void KopiowanieTablic()
            {
                /*
                Dana jest n-elementowa tablica liczb całkowitych tab1. Napisz program kopiujący
                wartości elementów tablicy tab1 do tablicy tab2 (o tym samym rozmiarze) z przesunięciem o
                jedną pozycje. To znaczy, że element w tablicy źródłowej o indeksie 0 powinien znaleźć się w
                tablicy docelowej pod indeksem 1, element o indeksie 1 ma być w tablicy docelowej pod
                indeksem 2 itd. Element ostatni tablicy źródłowej ma być elementem o indeksie 0 w tablicy
                docelowej.
                */

                Console.Write("Podaj rozmiar tablicy: ");
                int rozmiarTablicy = Convert.ToInt32(Console.ReadLine());
                
                int[] tab1 = new int[rozmiarTablicy];
                LosowanieLiczb(tab1, rozmiarTablicy);

                int[] tab2 = new int[rozmiarTablicy];

                for (int i = 1; i < rozmiarTablicy; i++)
                {
                    tab2[i] = tab1[i-1];
                }
                tab2[0] = tab1[rozmiarTablicy-1];

                Console.WriteLine("tab1   tab2");
                for (int i = 0; i < rozmiarTablicy; i++)
                {
                    Console.WriteLine("{0,5} {1,5}", tab1[i], tab2[i] );
                }
                

            }


            void LiczbaLiczbPierwszych()
            {
                /*
                Napisz program, który podaje, ile jest liczb pierwszych w tablicy 100 elementowej typu
                int. Tablicę należy wypełnić losowymi wartościami.
                */

                int rozmiarTablicy = 100;
                int[] tabela = new int[rozmiarTablicy];
                int LiczbaLiczbPierwszych=0;

                bool czy_pierwsza(int n)
                {
                    if (n < 2)
                        return false; //gdy liczba jest mniejsza niż 2 to nie jest pierwszą

                    for (int i = 2; i * i <= n; i++)
                        if (n % i == 0)
                            return false; //gdy znajdziemy dzielnik, to dana liczba nie jest pierwsza
                    return true;
                }



                LosowanieLiczb(tabela, rozmiarTablicy);
                
                
                for (int i = 0; i < rozmiarTablicy; i++)
                {
                    if (czy_pierwsza(tabela[i])) LiczbaLiczbPierwszych++;
                }
                

                Console.WriteLine($"W tabeli zapisano 100 losowych liczba");
                Console.WriteLine($"{LiczbaLiczbPierwszych} z nich to liczby pierwsze");

            }

            void InformacjeOtablicy()
            {
                /*
                Napisz program wyświetlający informacje o wypełnionej przez użytkownika tablicy nelementowej:
                 wartość i numer pozycji największego elementu,
                 wartość i numer pozycji najmniejszego elementu,
                 średnia wartości wszystkich elementów tablicy,
                 liczba dodatnich elementów tablicy.
                */



                Console.Write("Podaj rozmiar tabeli: ");
                int rozmiar = Convert.ToInt32(Console.ReadLine());

                int[] tablica = new int[rozmiar];
                int min = 0;
                int iMin = 0;
                int max = 0; 
                int iMax = 0;
                int sum = 0;
                int liczbaDodatnich = 0;

                for (int i = 0; i < rozmiar; i++)
                {
                    Console.Write($"Podaj element [{i}] tablicy: ");
                    tablica[i]= Convert.ToInt32(Console.ReadLine());
                    if (tablica[i] > max)
                    {
                        max = tablica[i];
                        iMax = i;
                    }
                    if (tablica[i] < min)
                    {
                        min = tablica[i];
                        iMin = i;
                    }
                    sum += tablica[i];
                    if (tablica[i] > 0) liczbaDodatnich++;
                }

                Console.WriteLine($"Majwiększy elemet to: [{iMax}] o wartości: {max} ");
                Console.WriteLine($"Najmniejszy elemet to: [{iMin}] o wartości: {min} ");
                Console.WriteLine($"Średnia wartość wszystkich elementów: {sum/rozmiar}");
                Console.WriteLine($"Liczba dodatnich elementów to: {liczbaDodatnich}");

            }

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
