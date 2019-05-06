using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przypomnienie
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Operacje na sringach i deklracje
            */

            //short liczba = 10, liczba2 = 12;

            //byte licz = 256;

            //byte piewszaLiczba = 25, drugaLiczba = 75;

            //Console.WriteLine("Wartość pierwszej zmiennej \"pierwsza liczba\" " + piewszaLiczba + //pierwszy zapis
            //    ". Wartość drugiej zmiennej \"druga liczba\" " + drugaLiczba);

            //Console.WriteLine("Pierwsza liczba = {0}, druga liczba = {1}", piewszaLiczba, drugaLiczba); //drugi zapis

            //Console.WriteLine($"Wartość pierwszej zmiennej to: {piewszaLiczba}, drugiej zmiennej: {drugaLiczba}"); // trzeci zapis

            //Console.WriteLine("pierwsza to: " + piewszaLiczba + "druga natomiast to: " + drugaLiczba);

            //Console.WriteLine("Wartość pierwszej liczby to: {0}, natomiast drugiej to {1}", piewszaLiczba, drugaLiczba);

            //Console.WriteLine($"Wartość pierwszej to {piewszaLiczba}, natomiast drugiej to: {drugaLiczba}");

            /*
            Sekwencja ucieczki "\"
            */

            //Console.WriteLine("Z przetwarzaniem znaków specjalnych: \nabc\t222\ndef\t444"); // z przetwarzaniem znaków specjlnych

            //Console.WriteLine(@"Z przetwarzaniem znaków specjalnych: \nabc\t222\ndef\t444"); // bez przetwarzanie znaków specjalnych

            //Console.Write("jakiś napis");
            //Console.Write("jakiś napis2");
            //Console.Write("jakiś napis3");

            /*
            Zadanie 6.1
            */

            //double pierwsza = 12, druga = 14;

            //Console.Write($"Wartość pierwszej zmiennej: {pierwsza}, \n drugiej: {druga}");

            /*
            Zadanie 6.2
            */

            //Console.Write(" /---\\ |----\\ /----\\\n|     ||    | |\n|     ||    / |\n|-----||----  |\n|     ||    \\ |\n|     ||    | |\n|     ||----/ \\----/");

            /*
            Zadanie 6.3
            */

            //Console.Write("111\t+\t222\t=\t333\n+\t\t+\t\t+\n333\t+\t444\t=\t777\n=\t\t=\t\t=\n444\t+\t666\t=\t1110");

            /*
            Operaacje arytmetyczne
            */

            //int x = 1, y = 2;

            //Console.WriteLine(++x);             //INKREMENTACJA PRZEDROSTKOWA ++X, ORAZ PRZYROSTKOWA X++
            //Console.WriteLine(x);

            //Zadania:

            //7.1

            //int x = 110, y = 6, z = 5;

            //int w = x % y % z;            //Obiczanie modulo z wykorzystanie zmiennej wynik

            //Console.WriteLine(w);

            //7.2

            //int zm = 256;

            //Console.WriteLine("Przesunięcie bitowe dla liczby 25 o 2 miejsca w prawo da wynik: {0}", zm >> 2); //Przesunięcie bitowe o 2 miejsca w prawo
            //Console.WriteLine("Przesunięcie bitowe dla liczby 25 o 2 miejsca w lewo da wynik: {0}", zm << 2); //2 iejsca w lewo

            //7.3

            //int a = 10, b = 12;

            //Console.WriteLine("Suma bitowa dla a 10 i b 12 wynosi: {0}", a | b);        //suma bitowa
            //Console.WriteLine("Iloczyn bitowy dla a 10 i b 12 wynosi: {0}", a & b);     //Iloczyn bitowy

            //7.4

            //int a = 16, b = 9, c;

            //c = a ^ b;

            //Console.WriteLine(c);

            //7.5

            //b = a << 2;                   //pierwszy wariant

            //for (int i = 1; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //===============================================================================

            //              INSTRUKCJE STERUJĄE

            //Console.Write("Wprowadź pierwszą liczbę: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("Wprowadź drugą liczbę: ");
            //int b = int.Parse(Console.ReadLine());

            //if (a > b)
            //{
            //    Console.WriteLine("Pierwsza liczba jest większa");
            //}
            //else if (a < b)
            //{
            //    Console.WriteLine("Druga liczba jest mniejsza");
            //}
            //else (a == b)
            //{
            //    Console.WriteLine("Druga liczba jest równa pierwszej");
            //}


            // Równanie kwadratowe

            //Console.Write("Wprowadź wartość a: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("Wprowadź wartość b: ");
            //int b = int.Parse(Console.ReadLine());

            //Console.Write("Wprowadź wartość c: ");
            //int c = int.Parse(Console.ReadLine());

            ////Liczymy deltę

            //int delta = b * b - 4 * a * c;

            //if (delta < 0)
            //{
            //    Console.WriteLine("Delta jest mniejsza niż zero");
            //    Console.WriteLine("To równanie nie ma rozwiązanie w zbiorze liczb rzeczywistych");
            //}
            //else if (delta == 0)
            //{
            //    Console.WriteLine("To równanie ma jedno rozwiązanie: {0}", -b / (2 * a));
            //}
            //else if (delta > 0)
            //{
            //    Console.WriteLine("Jeżeli dealta jest większa od zera, mamy dwa rozwiąnia: x1 = {0} oraz x2 = {1}", -b + Math.Sqrt(delta) / (2 * a), -b - Math.Sqrt(delta) / (2 * a));
            //}

            // ZADANIA

            //8.1


            //Console.WriteLine("Witaj w moim programie sprawdzjącym resztę z dzielenia dwóch liczb!\n\n\n\n\n");

            //Console.WriteLine("V 1.0\n");

            //Console.WriteLine("\"Apa soft\"\n\n");

            //Console.WriteLine("Naciśnij dowolny klawisz...");

            //Console.ReadKey();

            //Console.Clear();

            //Console.WriteLine("Podaj pierwszą liczbę: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.WriteLine("Podaj drugą liczbę: ");
            //int b = int.Parse(Console.ReadLine());

            //int wynik = a%b;

            //if (wynik == 0)
            //{
            //    Console.WriteLine("Dzielenie modulo daje zero!");
            //}
            //else
            //{
            //    Console.WriteLine($"Dzielenie modulo zwraca resztę: {wynik}");
            //}

            //8.2

            //Console.WriteLine("Ten kawałek kodu sprawdzi czy równanie kwadratowe ma rozwiązanie w zbiorze liczb rzeczywistych");

            //Console.ReadKey();
            //Console.Clear();

            //Console.Write("Wprowadź wartość a: ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Wprowadź wartość b: ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Wprowadź wartość c: ");
            //int c = Convert.ToInt32(Console.ReadLine());

            //double delta = b * b - 4 * a * c;

            //if (delta >= 0)
            //{
            //    Console.WriteLine("Rówananie ma rozwiązanie w zbiorze liczb rzeczywistych");
            //}
            //else
            //{
            //    Console.WriteLine("To równanie nie ma rozwiązania w zbiorze lizb rzeczywistych");
            //}

            //8.3

            //Console.WriteLine("Podaj liczbę:");

            //int x = int.Parse(Console.ReadLine());

            //if (x>=0)
            //{
            //    Console.WriteLine("Wartość bezwzględna liczby |{0}| wynosi {1}", x, x);
            //}
            //else
            //{
            //    Console.WriteLine("Wartość bezwzględna liczby |{0}| wynosi {1}", x, -x);
            //}

            //8.5

            //Console.WriteLine("Pukt w prostokącie \n\n\n\n");

            //Console.WriteLine("Podaj wysokość punktu (0 - 10): ");
            //int pointHeight = int.Parse(Console.ReadLine());

            //Console.WriteLine("Podaj szerokość punktu (0 - 20): ");
            //int pointWidth = int.Parse(Console.ReadLine());

            //int width = 20, height = 10;

            //if (pointHeight >= 0 && pointHeight <= height && pointWidth >= 0 && pointWidth <= width)
            //{
            //    Console.WriteLine("Punkt mieści się w prostokącie");
            //}
            //else if (pointHeight < 0 || pointWidth < 0)
            //{
            //    Console.WriteLine("Wartości nie mogą być mniejsze niż zero!");
            //}
            //else
            //{
            //    Console.WriteLine("Punkt znajduje się poza prostokątem");
            //}

            //=========================================================================
            //INSTRUKCJA SWITCH

            //CALC

            //Console.WriteLine("Witaj w moim kalkulatorze \n\n\n\n\n");
            //Console.WriteLine("Co chcesz zrbić?:\n");
            //Console.WriteLine("1. Dodawanie");
            //Console.WriteLine("2. Odejmowanie");
            //Console.WriteLine("3. Mnożenie");
            //Console.WriteLine("4. Dzielenie");

            //char i = Console.ReadLine();

            //switch (i)
            //{
            //    case '1':
            //        Console.Write("Podaj pierwszą liczbę: ");
            //int fn = int.Parse(Console.ReadLine());
            //Console.Write("Podaj drugą liczbę: ");
            //int sn = int.Parse(Console.ReadLine());
            //Console.WriteLine("Wynik dodawania to: {0}", fn + sn);
            //    break;
            //case '2':
            //    Console.Write("Podaj pierwszą liczbę: ");
            //int fn = int.Parse(Console.ReadLine());
            //Console.Write("Podaj drugą liczbę: ");
            //int sn = int.Parse(Console.ReadLine());
            //Console.WriteLine("Wynik odejmowania to: {0}", fn - sn);
            //    break;
            //default:
            //    break;


            //Operator warunkowy

            //int i = 100;

            //i = i < 0 ? 15 : 4;

            // ĆWICZENIA

            //9.1
            //label1:
            //    Console.WriteLine("Wpisz liczbę w zakresie 0 - 9");

            //    int i = int.Parse(Console.ReadLine());

            //    switch (i)
            //    {
            //        case 0:
            //            Console.WriteLine("Liczba wynosi 0");
            //            break;
            //        case 1:
            //            Console.WriteLine("Liczba wynosi 1");
            //            break;
            //        case 2:
            //            Console.WriteLine("Liczba wynosi 2");
            //            break;
            //        case 3:
            //            Console.WriteLine("Liczba wynosi 3");
            //            break;
            //        case 4:
            //            Console.WriteLine("Liczba wynosi 4");
            //            break;
            //        case 5:
            //            Console.WriteLine("Liczba wynosi 5");
            //            break;
            //        case 6:
            //            Console.WriteLine("Liczba wynosi 6");
            //            break;
            //        case 7:
            //            Console.WriteLine("Liczba wynosi 7");
            //            break;
            //        case 8:
            //            Console.WriteLine("Liczba wynosi 8");
            //            break;
            //        case 9:
            //            Console.WriteLine("Liczba wynosi 9");
            //            break;
            //        default:
            //            Console.WriteLine("Wpisz liczbę z zakresu 0 - 9! \n\n\nNaciśnij dowolny klawisz");
            //            Console.ReadKey();
            ////            goto label1;
            //    }

            //9.2 sprawdzenie dzielenia modulo za pomocą instrukcji warunkowej

            //etykieta:
            //Console.WriteLine("Podaj dwie liczby do sprawdzenia");
            //int i = int.Parse(Console.ReadLine());
            //int j = int.Parse(Console.ReadLine());

            //bool spr = i % j == 0 ? true : false;
            //Console.WriteLine(spr);
            //Console.ReadKey();
            //goto etykieta;

            //9.3 DO DOKOŃCZENIA!!!!!!!!!!!!!!!!!!!!!!!!!

            //Console.WriteLine("Podaj liczbę do ustalenia jej wartości bezwzględnej");
            //int i = int.Parse(Console.ReadLine());

            //Console.WriteLine(i < 0 ? $"Wartość bezwzględna dla |{i}| wynosi{i}"):Console.WriteLine($"Wartość bezwzględna dla |{i}| wynosi {i});

            //9.4

            //int liczba = 10, liczba2;

            //if (liczba<0)
            //{
            //    liczba2 = -1;
            //}
            //else
            //{
            //    liczba2 = 1;
            //}
            //Console.WriteLine(liczba2);

            //9.5

            //int i = int.Parse(Console.ReadLine());

            //switch (i)
            //{
            //    case 1:
            //        Console.WriteLine("Zmiennna i ma wartość 1");
            //            break;
            //    case 4:
            //        Console.WriteLine("Zmiennna i ma wartość 4");
            //        break;
            //    case 8:
            //        Console.WriteLine("Zmiennna i ma wartość 8");
            //        break;
            //    case 2:
            //        Console.WriteLine("Zmiennna i ma wartość 2");
            //        break;
            //    case 3:
            //        Console.WriteLine("Zmiennna i ma wartość 3");
            //        break;
            //    case 7:
            //        Console.WriteLine("Zmiennna i ma wartość 7");
            //        break;

            //    default:
            //        Console.WriteLine($"Zmienna ma wartość {i}");
            //        break;

            //PĘTLE

            //FOR

            //}
            //int i = 0;
            //for (;i<100;)
            //{

            //    Console.WriteLine($"Pętle w c# {i}");
            //    i++;
            //}

            //WHILE

            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine("pętle w c#");
            //    i++;
            //}

            //DO WHILE

            //int i = 0;

            //do
            //{
            //    Console.WriteLine("cos tam");
            //    i++;
            //}
            //while (i < 10);

            Console.ReadKey();
        }
    }
}

