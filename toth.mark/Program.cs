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
                int szamA = int.Parse(Console.ReadLine());

                Console.Write("Add meg a második számot: ");
                int szamB = int.Parse(Console.ReadLine());

                double atlag = (szamA + szamB) / 2.0;
                double geometricMean = Math.Sqrt(szamA * szamB);

                Console.WriteLine($"Átlag (számtani): {atlag}");
                Console.WriteLine($"Átlag (mértani): {Math.Round(geometricMean, 2)}");
            }

            static void F9()
            {
                Console.WriteLine("Másodfokú egyenlet: ax² + bx + c = 0");
                Console.Write("a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("b = ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("c = ");
                int c = int.Parse(Console.ReadLine());

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
                int a = int.Parse(Console.ReadLine());
                Console.Write("b = ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("c = ");
                int c = int.Parse(Console.ReadLine());

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
                int befogo1 = int.Parse(Console.ReadLine());

                Console.Write("Befogó 2: ");
                int befogo2 = int.Parse(Console.ReadLine());

                double atfogo = Math.Sqrt(befogo1 * befogo1 + befogo2 * befogo2);
                Console.WriteLine($"Átfogó hossza: {Math.Round(atfogo, 2)}");
            }

            static void F12()
            {
                Console.Write("a él: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("b él: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("c él: ");
                int c = int.Parse(Console.ReadLine());

                int felszin = 2 * (a * b + b * c + a * c);
                int terfogat = a * b * c;

                Console.WriteLine($"Téglatest felszíne: {felszin}");
                Console.WriteLine($"Téglatest térfogata: {terfogat}");
            }

            static void F13()
            {
                Console.Write("Add meg a kör átmérőjét: ");
                double diameter = double.Parse(Console.ReadLine());

                double radius = diameter / 2;
                double kerulet = 2 * Math.PI * radius;
                double terulet = Math.PI * radius * radius;

                Console.WriteLine($"A kör kerülete: {Math.Round(kerulet, 2)}");
                Console.WriteLine($"A kör területe: {Math.Round(terulet, 2)}");
            }

            static void F14()
            {
                Console.Write("Sugár (r): ");
                int radius = int.Parse(Console.ReadLine());

                Console.Write("Középponti szög (fok): ");
                int angle = int.Parse(Console.ReadLine());

                double ivHossz = 2 * Math.PI * radius * angle / 360;
                double korSzeletTerulet = Math.PI * radius * radius * angle / 360;

                Console.WriteLine($"Ívhossz: {Math.Round(ivHossz, 2)}");
                Console.WriteLine($"Körszelet területe: {Math.Round(korSzeletTerulet, 2)}");
            }
        }
    }
