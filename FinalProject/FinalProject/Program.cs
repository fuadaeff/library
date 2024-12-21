Console.WriteLine("Salamlar!Kitabxanamiza xos gelmisiniz.");
Console.WriteLine("Hansi emeliyyati yerine yetirmek isteyirsiniz?");
Console.WriteLine("1) Kitab almaq");
Console.WriteLine("2) Kitab goturmek");
Console.WriteLine();

int emeliyyat = int.Parse(Console.ReadLine());
double sebet = 0;
bool loop = true;

while (loop)
{
    if (emeliyyat == 1)
    {
        bool janrMenu = true;
        while (janrMenu)
        {
            Console.WriteLine("Ela!Hansi janrda kitab almaq isteyirsiniz?");
            Console.WriteLine("1) Romantik");
            Console.WriteLine("2) Mecera");
            Console.WriteLine("3) Fantastik");

            int janr = int.Parse(Console.ReadLine());

            if (janr == 1)
            {
                bool romantikMenuLoop = true;
                while (romantikMenuLoop)
                {
                    Console.WriteLine("Ela secimdir!Buyurun elimizde olan romantik kitablarin siyahisi:");
                    Console.WriteLine("1) E.Heminguey - Zeng kimin ucun calir");
                    Console.WriteLine("2) M.Bulkaqov - Master ve Marqarita");
                    Console.WriteLine("3) Kollin Makqlou - Caqqal gavalisinda oxuyanlar");
                    Console.WriteLine("4) Ceyn Oustin - Qurur ve Xeberdarliq");
                    Console.WriteLine("5) L.N.Tolstoy - Herb ve Sulh");

                    int romantik = int.Parse(Console.ReadLine());

                    switch (romantik)
                    {
                        case 1:
                            double qiymet1 = 12.99;
                            Console.WriteLine($"Qiymet {qiymet1}azn,sebete elave olunsun?(y/n)");
                            string romantikSecim1 = Console.ReadLine();
                            if (romantikSecim1 == "y")
                            {
                                sebet += qiymet1;
                                Console.WriteLine("Ugurla sebete elave olundu!");
                            }
                            break;

                        case 2:
                            double qiymet2 = 10.99;
                            Console.WriteLine($"Qiymet {qiymet2}azn,sebete elave olunsun?(y/n)");
                            string romantikSecim2 = Console.ReadLine();
                            if (romantikSecim2 == "y")
                            {
                                sebet += qiymet2;
                                Console.WriteLine("Ugurla sebete elave olundu!");
                            }
                            break;

                        case 3:
                            double qiymet3 = 9.99;
                            Console.WriteLine($"Qiymet {qiymet3}azn,sebete elave olunsun?(y/n)");
                            string romantikSecim3 = Console.ReadLine();
                            if (romantikSecim3 == "y")
                            {
                                sebet += qiymet3;
                                Console.WriteLine("Ugurla sebete elave olundu!");
                            }
                            break;

                        case 4:
                            double qiymet4 = 15.99;
                            Console.WriteLine($"Qiymet {qiymet4}azn,sebete elave olunsun?(y/n)");
                            string romantikSecim4 = Console.ReadLine();
                            if (romantikSecim4 == "y")
                            {
                                sebet += qiymet4;
                                Console.WriteLine("Ugurla sebete elave olundu!");
                            }
                            break;

                        case 5:
                            double qiymet5 = 20.99;
                            Console.WriteLine($"Qiymet {qiymet5}azn,sebete elave olunsun?(y/n)");
                            string romantikSecim5 = Console.ReadLine();
                            if (romantikSecim5 == "y")
                            {
                                sebet += qiymet5;
                                Console.WriteLine("Ugurla sebete elave olundu!");
                            }
                            break;

                        default:
                            Console.WriteLine("Xais olunur siyahidan kitab secin!");
                            break;
                    }

                    Console.WriteLine("Bu janrdan basqa kitab elave etmek isteyirsiniz?(y/n)");
                    string romantikMenuChecker = Console.ReadLine();
                    if (romantikMenuChecker == "n")
                    {
                        romantikMenuLoop = false;
                    }
                }
            }
            else if (janr == 2)
            {
                bool meceraMenuLoop = true;
                while (meceraMenuLoop)
                {
                    Console.WriteLine("Ela secimdir!Buyurun mecera janrinda olan kitablarimiz:");
                    Console.WriteLine("1) A.Duma - Uc silahsor");
                    Console.WriteLine("2) C.Dickens - Oliver Twist");
                    Console.WriteLine("3) B.Crouch - Saxta Yaddas");
                    Console.WriteLine("4) D.Brown - Da Vinci Sifresi");
                    Console.WriteLine("5) J.K.Rowling - Harry Potter:Felsefe Dasi");

                    int mecera = int.Parse(Console.ReadLine());

                    switch (mecera)
                    {
                        case 1:
                            double qiymet1 = 12.99;
                            Console.WriteLine($"Qiymet {qiymet1}azn,sebete elave olunsun?(y/n)");
                            string meceraSecim1 = Console.ReadLine();
                            if (meceraSecim1 == "y")
                            {
                                sebet += qiymet1;
                                Console.WriteLine("Ugurla sebete elave olundu!");
                            }
                            break;

                        case 2:
                            double qiymet2 = 10.99;
                            Console.WriteLine($"Qiymet {qiymet2}azn,sebete elave olunsun?(y/n)");
                            string meceraSecim2 = Console.ReadLine();
                            if (meceraSecim2 == "y")
                            {
                                sebet += qiymet2;
                                Console.WriteLine("Ugurla sebete elave olundu!");
                            }
                            break;

                        case 3:
                            double qiymet3 = 9.99;
                            Console.WriteLine($"Qiymet {qiymet3}azn,sebete elave olunsun?(y/n)");
                            string meceraSecim3 = Console.ReadLine();
                            if (meceraSecim3 == "y")
                            {
                                sebet += qiymet3;
                                Console.WriteLine("Ugurla sebete elave olundu!");
                            }
                            break;

                        case 4:
                            double qiymet4 = 15.99;
                            Console.WriteLine($"Qiymet {qiymet4}azn,sebete elave olunsun?(y/n)");
                            string meceraSecim4 = Console.ReadLine();
                            if (meceraSecim4 == "y")
                            {
                                sebet += qiymet4;
                                Console.WriteLine("Ugurla sebete elave olundu!");
                            }
                            break;

                        case 5:
                            double qiymet5 = 20.99;
                            Console.WriteLine($"Qiymet {qiymet5}azn,sebete elave olunsun?(y/n)");
                            string meceraSecim5 = Console.ReadLine();
                            if (meceraSecim5 == "y")
                            {
                                sebet += qiymet5;
                                Console.WriteLine("Ugurla sebete elave olundu!");
                            }
                            break;

                        default:
                            Console.WriteLine("Xais olunur siyahidan kitab secin!");
                            break;
                    }

                    Console.WriteLine("Bu janrdan basqa kitab elave etmek isteyirsiniz?(y/n)");
                    string meceraMenuChecker = Console.ReadLine();
                    if (meceraMenuChecker == "n")
                    {
                        meceraMenuLoop = false;
                    }
                }
            }
            else if (janr == 3)
            {
                bool fantastikMenuLoop = true;
                while (fantastikMenuLoop)
                {
                    Console.WriteLine("Ela secimdir!Buyurun fantastik janra aid kitablar:");
                    Console.WriteLine("1) F.Kafka - Cevrilis");
                    Console.WriteLine("2) M.Miller - Ben, Kirke");
                    Console.WriteLine("3) S.Collins - Acliq Oyunlari");
                    Console.WriteLine("4) JRR Tolkien - Uzuklerin Efendisi");
                    Console.WriteLine("5) D.Brown - Melekler ve iblisler");

                    int fantastik = int.Parse(Console.ReadLine());

                    switch (fantastik)
                    {
                        case 1:
                            double qiymet1 = 12.99;
                            Console.WriteLine($"Qiymet {qiymet1}azn,sebete elave olunsun?(y/n)");
                            string fantastikSecim1 = Console.ReadLine();
                            if (fantastikSecim1 == "y")
                            {
                                sebet += qiymet1;
                                Console.WriteLine("Ugurla sebete elave olundu!");
                            }
                            break;

                        case 2:
                            double qiymet2 = 10.99;
                            Console.WriteLine($"Qiymet {qiymet2}azn,sebete elave olunsun?(y/n)");
                            string fantastikSecim2 = Console.ReadLine();
                            if (fantastikSecim2 == "y")
                            {
                                sebet += qiymet2;
                                Console.WriteLine("Ugurla sebete elave olundu!");
                            }
                            break;

                        case 3:
                            double qiymet3 = 9.99;
                            Console.WriteLine($"Qiymet {qiymet3}azn,sebete elave olunsun?(y/n)");
                            string fantastikSecim3 = Console.ReadLine();
                            if (fantastikSecim3 == "y")
                            {
                                sebet += qiymet3;
                                Console.WriteLine("Ugurla sebete elave olundu!");
                            }
                            break;

                        case 4:
                            double qiymet4 = 15.99;
                            Console.WriteLine($"Qiymet {qiymet4}azn,sebete elave olunsun?(y/n)");
                            string fantastikSecim4 = Console.ReadLine();
                            if (fantastikSecim4 == "y")
                            {
                                sebet += qiymet4;
                                Console.WriteLine("Ugurla sebete elave olundu!");
                            }
                            break;

                        case 5:
                            double qiymet5 = 20.99;
                            Console.WriteLine($"Qiymet {qiymet5}azn,sebete elave olunsun?(y/n)");
                            string fantastikSecim5 = Console.ReadLine();
                            if (fantastikSecim5 == "y")
                            {
                                sebet += qiymet5;
                                Console.WriteLine("Ugurla sebete elave olundu!");
                            }
                            break;

                        default:
                            Console.WriteLine("Xais olunur siyahidan kitab secin!");
                            break;
                    }

                    Console.WriteLine("Bu janrdan basqa kitab elave etmek isteyirsiniz?(y/n)");
                    string fantastikMenuChecker = Console.ReadLine();
                    if (fantastikMenuChecker == "n")
                    {
                        fantastikMenuLoop = false;
                    }
                }
            }
            else
            {
                Console.WriteLine("Xais olunur dogru janr secin!");
                continue;
            }

            Console.WriteLine("Basqa janrdan kitab elave etmek isteyirsiniz?(y/n)");
            string basqaJanr = Console.ReadLine();
            if (basqaJanr == "n")
            {
                janrMenu = false;
                loop = false;
            }
        }
    }
    else if (emeliyyat == 2)
    {
        Console.WriteLine("Bu funksionallıq hələ hazır deyil.");
        loop = false;
    }
    else
    {
        Console.WriteLine("Dogru secim edin!");
        loop = false;
    }
}

if (sebet > 0)
{
    Console.WriteLine($"Umumi mebleg: {sebet} AZN");
}