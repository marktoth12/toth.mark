namespace toth.mark
{
    internal class Program
    {
        static void Main(string[] args)
        {
                F1();
                F2();
                F3();
                F4();
                F5();
                F6();
                F7();
                F8();
                F9();
                F10();
                F11();
                F12();
                F13();
                F14();
                F15();
                F16();
                F17();
                F18();
                F19();
                F20();
                F21();
                F22();
                F23();
                F24();
                F25();
                F26();
                F27();
                F28();
                F29();
                F30();
                F31();
        }

            static void F1()
            {
                Console.WriteLine("Üdv a programban!");
            }

            static void F2()
            {
                string felhasznaloNev = "Pisti";
                Console.WriteLine($"Helló, {felhasznaloNev}!");
            }

            static void F3()
            {
                int alap = 4;
                int duplazott = alap * 2;
                Console.WriteLine($"A {alap} kétszerese: {duplazott}");
            }

            static void F4()
            {
                int szam1 = 8, szam2 = 4;
                Console.WriteLine($"Összeadás: {szam1 + szam2}");
                Console.WriteLine($"Kivonás: {szam1 - szam2}");
                Console.WriteLine($"Szorzás: {szam1 * szam2}");
                Console.WriteLine($"Osztás: {szam1 / szam2}");
            }

            static void F5()
            {
                int x = 23, y = 32;
                int nagyobb = x > y ? x : y;
                Console.WriteLine($"A nagyobb érték: {nagyobb}");
            }

            static void F6()
            {
                int sz1 = 2, sz2 = 32, sz3 = 40;
                int legkisebb = Math.Min(sz1, Math.Min(sz2, sz3));
                Console.WriteLine($"A legkisebb szám: {legkisebb}");
            }

            static void F7()
            {
                int a = 24, b = 10, c = 51;
                bool szerkesztheto = (a + b > c) && (b + c > a) && (a + c > b);
                Console.WriteLine(szerkesztheto
                    ? "Ebből háromszöget lehet szerkeszteni."
                    : "Nem lehet háromszöget szerkeszteni.");
            }

            static void F8()
            {
                Console.Write("Add meg az első számot: ");
                int szamA = int.Parse(Console.ReadLine()!);

                Console.Write("Add meg a második számot: ");
                int szamB = int.Parse(Console.ReadLine()!);

                double szamtani = (szamA + szamB) / 2.0;
                double mertani = Math.Sqrt(szamA * szamB);

                Console.WriteLine($"Átlag (számtani): {szamtani}");
                Console.WriteLine($"Átlag (mértani): {Math.Round(mertani, 2)}");
            }

            static void F9()
            {
                Console.WriteLine("Másodfokú egyenlet: ax² + bx + c = 0");
                Console.Write("a = ");
                int a = int.Parse(Console.ReadLine()!);
                Console.Write("b = ");
                int b = int.Parse(Console.ReadLine()!);
                Console.Write("c = ");
                int c = int.Parse(Console.ReadLine()!);

                int diszkriminans = b * b - 4 * a * c;

                if (diszkriminans < 0)
                    Console.WriteLine("Nincs valós megoldás.");
                else
                    Console.WriteLine("Van legalább egy valós megoldás.");
            }

            static void F10()
            {
                Console.WriteLine("Másodfokú egyenlet megoldása:");
                Console.Write("a = ");
                int a = int.Parse(Console.ReadLine()!);
                Console.Write("b = ");
                int b = int.Parse(Console.ReadLine()!);
                Console.Write("c = ");
                int c = int.Parse(Console.ReadLine()!);

                int d = b * b - 4 * a * c;

                if (d < 0)
                {
                    Console.WriteLine("A gyökök nem valósak.");
                }
                else if (d == 0)
                {
                    double gyok = -b / (2.0 * a);
                    Console.WriteLine($"Egy valós gyök van: x = {gyok}");
                }
                else
                {
                    double gyok1 = (-b + Math.Sqrt(d)) / (2 * a);
                    double gyok2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine($"Két valós gyök: x₁ = {Math.Round(gyok1, 2)}, x₂ = {Math.Round(gyok2, 2)}");
                }
            }

            static void F11()
            {
                Console.Write("Befogó 1: ");
                int befogo1 = int.Parse(Console.ReadLine()!);

                Console.Write("Befogó 2: ");
                int befogo2 = int.Parse(Console.ReadLine()!);

                double atfogo = Math.Sqrt(befogo1 * befogo1 + befogo2 * befogo2);
                Console.WriteLine($"Átfogó hossza: {Math.Round(atfogo, 2)}");
            }

            static void F12()
            {
                Console.Write("a él: ");
                int a = int.Parse(Console.ReadLine()!);
                Console.Write("b él: ");
                int b = int.Parse(Console.ReadLine()!);
                Console.Write("c él: ");
                int c = int.Parse(Console.ReadLine()!);

                int felszin = 2 * (a * b + b * c + a * c);
                int terfogat = a * b * c;

                Console.WriteLine($"Téglatest felszíne: {felszin}");
                Console.WriteLine($"Téglatest térfogata: {terfogat}");
            }

            static void F13()
            {
                Console.Write("Add meg a kör átmérőjét: ");
                double diameter = double.Parse(Console.ReadLine()!);

                double radius = diameter / 2;
                double kerulet = 2 * Math.PI * radius;
                double terulet = Math.PI * radius * radius;

                Console.WriteLine($"A kör kerülete: {Math.Round(kerulet, 2)}");
                Console.WriteLine($"A kör területe: {Math.Round(terulet, 2)}");
            }

            static void F14()
            {
                Console.Write("Sugár (r): ");
                int radius = int.Parse(Console.ReadLine()!);

                Console.Write("Középponti szög (fok): ");
                int angle = int.Parse(Console.ReadLine()!);

                double ivHossz = 2 * Math.PI * radius * angle / 360;
                double korSzeletTerulet = Math.PI * radius * radius * angle / 360;

                Console.WriteLine($"Ívhossz: {Math.Round(ivHossz, 2)}");
                Console.WriteLine($"Körszelet területe: {Math.Round(korSzeletTerulet, 2)}");

            }
        static void F15()
        {
            Console.Write("Kérek egy pozitív egész számot: ");
            int n = int.Parse(Console.ReadLine()!);
            for (int i = 1; i <= n; i++)
                Console.Write(i + " ");
            Console.WriteLine("\n");
        }

        static void F16()
        {
            Console.Write("Kérek egy pozitív egész számot: ");
            int n = int.Parse(Console.ReadLine()!);
            for (int i = 1; i <= n; i++)
                Console.WriteLine(i);
        }

        static void F17()
        {
            Console.Write("Kérek egy pozitív egész számot: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.Write("Osztói: ");
            for (int i = 1; i <= n; i++)
                if (n % i == 0)
                    Console.Write(i + " ");
            Console.WriteLine();
        }

        static void F18()
        {
            Console.Write("Kérek egy pozitív egész számot: ");
            int n = int.Parse(Console.ReadLine()!);
            int osszeg = 0;
            for (int i = 1; i <= n; i++)
                if (n % i == 0)
                    osszeg += i;
            Console.WriteLine("Osztók összege: " + osszeg);
        }

        static void F19()
        {
            Console.Write("Kérek egy pozitív egész számot: ");
            int n = int.Parse(Console.ReadLine()!);
            int osszeg = 0;
            for (int i = 1; i <= n; i++)
                if (n % i == 0)
                    osszeg += i;
            if (osszeg == 2 * n)
                Console.WriteLine(n + " tökéletes szám.");
            else
                Console.WriteLine(n + " nem tökéletes szám.");
        }

        static void F20()
        {
            Console.Write("Hatványalap: ");
            int alap = int.Parse(Console.ReadLine()!);
            Console.Write("Kitevő: ");
            int kitevo = int.Parse(Console.ReadLine()!);
            int eredmeny = (int)Math.Pow(alap, kitevo);
            Console.WriteLine("Hatványérték: " + eredmeny);
        }

        static void F21()
        {
            int szam;
            do
            {
                Console.Write("Kérek egy pozitív számot: ");
                szam = int.Parse(Console.ReadLine()!);
            } while (szam <= 0);

            Console.WriteLine("Beolvasott szám: " + szam);
        }

        static void F22()
        {
            int szam, osszeg = 0;
            do
            {
                Console.Write("Kérek egy számot: ");
                szam = int.Parse(Console.ReadLine()!);
                if (szam < 10)
                    osszeg += szam;
            } while (szam < 10);

            Console.WriteLine("Összeg: " + osszeg);
        }

        static void F23()
        {
            Console.Write("Kérek egy egész számot: ");
            int n = int.Parse(Console.ReadLine()!);
            int eredeti = n;
            Console.Write(n + " = ");
            bool elso = true;
            while (n % 2 == 0)
            {
                if (!elso) Console.Write("*");
                Console.Write("2");
                n /= 2;
                elso = false;
            }

            if (n > 1)
            {
                if (!elso) Console.Write("*");
                Console.Write(n);
            }

            Console.WriteLine();
        }

        static void F24()
        {
            string s;
            do
            {
                Console.Write("Kérek egy szót: ");
                s = Console.ReadLine()!;
            } while (s != "alma");

            Console.WriteLine("Az alma gyümölcs!");
        }

        static void F25()
        {
            Console.Write("Kérek egy egész számot: ");
            int n = int.Parse(Console.ReadLine()!);
            int eredeti = n;
            int darab = 0;
            while (n >= 3)
            {
                n -= 3;
                darab++;
            }

            Console.WriteLine($"{eredeti} = {darab}*3 + {n}");
        }

        static void F26()
        {
            Console.Write("Kérek egy számot: ");
            int n = int.Parse(Console.ReadLine()!);
            if (n < 2)
            {
                Console.WriteLine("Nem prímszám.");
                return;
            }

            bool prim = true;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0)
                    prim = false;
            Console.WriteLine(prim ? "Prímszám." : "Nem prímszám.");
        }

        static void F27()
        {
            Console.Write("Kérek egy számot: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.Write("Prímszámok: ");
            for (int i = 2; i <= n; i++)
            {
                bool prim = true;
                for (int j = 2; j * j <= i; j++)
                    if (i % j == 0)
                        prim = false;
                if (prim) Console.Write(i + " ");
            }

            Console.WriteLine();
        }

        static void F28()
        {
            Console.Write("Kérek egy számot: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.Write("Prímosztók: ");
            for (int i = 2; i <= n; i++)
            {
                bool prim = true;
                for (int j = 2; j * j <= i; j++)
                    if (i % j == 0)
                        prim = false;
                if (prim && n % i == 0)
                    Console.Write(i + " ");
            }

            Console.WriteLine();
        }

        static void F29()
        {
            Console.Write("Kérek egy számot: ");
            int n = int.Parse(Console.ReadLine()!);
            int eredeti = n;
            Console.Write(eredeti + " = ");
            bool elso = true;
            for (int i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    if (!elso) Console.Write("*");
                    Console.Write(i);
                    n /= i;
                    elso = false;
                }
            }

            Console.WriteLine();
        }

        static void F30()
        {
            Console.Write("Kérek egy számot: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Kérek egy számot: ");
            int b = int.Parse(Console.ReadLine()!);
            int x = a, y = b;
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }

            Console.WriteLine("LNKO: " + a);
        }

        static void F31()
        {
            Console.Write("Kérek egy számot: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Kérek egy számot: ");
            int b = int.Parse(Console.ReadLine()!);
            int lnko = a, temp = b;
            while (temp != 0)
            {
                int t = temp;
                temp = lnko % temp;
                lnko = t;
            }

            int lkt = (a * b) / lnko;
            Console.WriteLine("LKKT: " + lkt);
        }
    }
}
