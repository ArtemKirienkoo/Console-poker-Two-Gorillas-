using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01
{
    class Program
    {
        static void Main()
        {
            int kesh = 500;
            string stavka;
            int upStavka;
            string nextStavka;
            int number;
            int mast;
            string myKarta1 = "";
            string myNumber1 = "";
            string myMast1 = "";
            string myKarta2 = "";
            string myNumber2 = "";
            string myMast2 = "";
            string otkritaKarta1 = "";
            string otkritaNumber1 = "";
            string otkritaMast1 = "";
            string otkritaKarta2 = "";
            string otkritaNumber2 = "";
            string otkritaMast2 = "";
            string otkritaKarta3 = "";
            string otkritaNumber3 = "";
            string otkritaMast3 = "";
            string skritaKarta1 = "";
            string skritaNumber1 = "";
            string skritaMast1 = "";
            string skritaKarta2 = "";
            string skritaNumber2 = "";
            string skritaMast2 = "";
            string dilerKarta1 = "";
            string dilerNumber1 = "";
            string dilerMast1 = "";
            string dilerKarta2 = "";
            string dilerNumber2 = "";
            string dilerMast2 = "";
            string next;
            double myWin;
            double dilerWin;
            int sum = 0;
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Random rand = new Random();
            string[] masti = { "♠", "♥", "♦", "♣" };
            string[,] kombo =
            {
                {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#"},
                {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                {"#"," ","0","1",")"," ","Ф","л","е","ш","-","р","о","я","л","ь"," ","(","1","0","♥"," ","V","♥"," ","D","♥"," ","K","♥"," ","A","♥",")"," ","#"," ","0","6",")"," ","С","т","р","і","т"," ","(","4","♥"," ","5","♦"," ","6","♣"," ","7","♠"," ","8","♣",")"," "," "," "," "," "," "," "," ","#"},
                {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                {"#"," ","0","2",")"," ","С","т","р","і","т","-","ф","л","е","ш"," ","(","6","♠"," ","7","♠"," ","8","♠"," ","9","♠"," ","1","0","♠",")"," ","#"," ","0","7",")"," ","С","е","т"," ","(","5","♥"," ","5","♦"," ","5","♣",")"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                {"#"," ","0","3",")"," ","К","а","р","е"," ","(","5","♠"," ","5","♥"," ","5","♦"," ","5","♣",")"," "," "," "," "," "," "," "," "," "," "," ","#"," ","0","8",")"," ","Д","в","і"," ","п","а","р","и"," ","(","4","♥"," ","4","♣"," ","6","♦"," ","6","♠",")"," "," "," "," "," "," "," "," ","#"},
                {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                {"#"," ","0","4",")"," ","Ф","у","л","-","х","а","у","с"," ","(","7","♦"," ","7","♠"," ","3","♣"," ","3","♦"," ","3","♥",")"," "," "," "," ","#"," ","0","9",")"," ","П","а","р","а"," ","(","5","♠"," ","5","♥",")"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                {"#"," ","0","5",")"," ","Ф","л","е","ш"," ","(","4","♦"," ","1","0","♦"," ","3","♦"," ","6","♦"," ","2","♦",")"," "," "," "," "," "," "," ","#"," ","1","0",")"," ","С","т","а","р","ш","а"," ","к","а","р","т","а"," ","(","A","♠"," ","V","♣"," ","5","♥"," ","8","♠"," ","3","♦",")"," ","#"},
                {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#"},
            };
            Console.WriteLine("Доброго дня! Вітаємо вас у нашому казино 'Дві горили'!");
            Console.WriteLine("Ваш баланс: " + kesh);
            Console.WriteLine();
            while (true)
            {
                string[,] table =
                {
                    {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#"},
                    {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                    {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","Д","і","л","е","р",":"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                    {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","?","?"," "," ","?","?"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                    {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                    {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                    {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                    {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","?","?"," "," ","?","?"," "," ","?","?"," "," ","?","?"," "," ","?","?"," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                    {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                    {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                    {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                    {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","В","и",":"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                    {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                    {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                    {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#"},
                };
                sum = 0;
                myWin = 0.0;
                dilerWin = 0.0;
                List<int> koloda = new List<int> {
                    2,2,2,2,
                    3,3,3,3,
                    4,4,4,4,
                    5,5,5,5,
                    6,6,6,6,
                    7,7,7,7,
                    8,8,8,8,
                    9,9,9,9,
                    10,10,10,10,
                    11,11,11,11,
                    12,12,12,12,
                    13,13,13,13,
                    14,14,14,14,
                };
                List<string> proverka = new List<string>();
                while (true)
                {
                    mast = rand.Next(masti.Length);
                    myMast1 = masti[mast];
                    number = rand.Next(koloda.Count);
                    myNumber1 = Convert.ToString(koloda[number]);
                    switch (myNumber1)
                    {
                        case "11":
                            myNumber1 = "V";
                            break;
                        case "12":
                            myNumber1 = "D";
                            break;
                        case "13":
                            myNumber1 = "K";
                            break;
                        case "14":
                            myNumber1 = "A";
                            break;
                    }
                    myKarta1 = myNumber1 + myMast1;
                    if (proverka.Contains(myKarta1))
                    {
                        continue;
                    }
                    else if (!proverka.Contains(myKarta1))
                    {
                        break;
                    }

                }
                koloda.RemoveAt(number);
                proverka.Add(myKarta1);
                table[12, 21] = myNumber1;
                table[12, 22] = myMast1;
                while (true)
                {
                    mast = rand.Next(masti.Length);
                    myMast2 = masti[mast];
                    number = rand.Next(koloda.Count);
                    myNumber2 = Convert.ToString(koloda[number]);
                    switch (myNumber2)
                    {
                        case "11":
                            myNumber2 = "V";
                            break;
                        case "12":
                            myNumber2 = "D";
                            break;
                        case "13":
                            myNumber2 = "K";
                            break;
                        case "14":
                            myNumber2 = "A";
                            break;
                    }
                    myKarta2 = myNumber2 + myMast2;
                    if (proverka.Contains(myKarta2))
                    {
                        continue;
                    }
                    else if (!proverka.Contains(myKarta2))
                    {
                        break;
                    }
                }
                koloda.RemoveAt(number);
                proverka.Add(myKarta2);
                table[12, 25] = myNumber2;
                table[12, 26] = myMast2;
                for (int a = 0; a < table.GetLength(0); a++)
                {
                    for (int b = 0; b < table.GetLength(1); b++)
                    {
                        Console.SetCursorPosition(31 + b, 6 + a);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        if (table[a, b] == "#")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.Write(table[a, b]);
                            Console.ResetColor();
                        }
                        else if (table[a, b] == "?")
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(table[a, b]);
                            Console.ResetColor();
                        }
                        else if (table[a, b + 1] == "10" || table[a, b + 1] == "0")
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            if (table[a, b + 2] == "♥" || table[a, b + 2] == "♦")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                            }
                            else if (table[a, b + 2] == "♠" || table[a, b + 2] == "♣")
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                            }
                            Console.BackgroundColor = ConsoleColor.White;
                            table[a, b] = "1";
                            Console.Write(table[a, b]);
                            table[a, b + 1] = "0";
                            Console.ResetColor();
                            continue;
                        }
                        else if (table[a, b + 1] == "♥" || table[a, b + 1] == "♦")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(table[a, b]);
                            Console.ResetColor();
                        }
                        else if (table[a, b] == "♥" || table[a, b] == "♦")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(table[a, b]);
                            Console.ResetColor();
                        }
                        else if (table[a, b + 1] == "♠" || table[a, b + 1] == "♣")
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(table[a, b]);
                            Console.ResetColor();
                        }
                        else if (table[a, b] == "♠" || table[a, b] == "♣")
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(table[a, b]);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(table[a, b]);
                        }

                    }
                    Console.WriteLine();
                }
                Console.ResetColor();
                Console.SetCursorPosition(0, 27);
                Console.WriteLine("Можливі комбінації(від найстаршої): ");
                for (int a = 0; a < kombo.GetLength(0); a++)
                {
                    for (int b = 0; b < kombo.GetLength(1); b++)
                    {
                        Console.SetCursorPosition(0 + b, 28 + a);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        if (kombo[a, b] == "#")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.Write(kombo[a, b]);
                            Console.ResetColor();
                        }
                        else if (kombo[a, b] == "1" && kombo[a, b + 1] == "0" && (kombo[a, b + 2] == "♥" || kombo[a, b + 2] == "♦" || kombo[a, b + 2] == "♠" || kombo[a, b + 2] == "♣"))
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            if (kombo[a, b + 2] == "♥" || kombo[a, b + 2] == "♦")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                            }
                            else if (kombo[a, b + 2] == "♠" || kombo[a, b + 2] == "♣")
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                            }
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(kombo[a, b]);
                            Console.ResetColor();
                            continue;
                        }
                        else if (kombo[a, b + 1] == "♥" || kombo[a, b + 1] == "♦")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(kombo[a, b]);
                            Console.ResetColor();
                        }
                        else if (kombo[a, b] == "♥" || kombo[a, b] == "♦")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(kombo[a, b]);
                            Console.ResetColor();
                        }
                        else if (kombo[a, b + 1] == "♠" || kombo[a, b + 1] == "♣")
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(kombo[a, b]);
                            Console.ResetColor();
                        }
                        else if (kombo[a, b] == "♠" || kombo[a, b] == "♣")
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(kombo[a, b]);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(kombo[a, b]);
                        }
                    }
                    Console.WriteLine();
                }
                Console.ResetColor();
                Console.SetCursorPosition(0, 2);
                Console.Write("Початкова ставка: 10. " +
                "\nБажаєте підняти ставку(y/n): ");
                stavka = Console.ReadLine();
                if (stavka != "y" && stavka != "n")
                {
                    while (true)
                    {
                        Console.Write("Неправильний ввід. Спробуйте знову: ");
                        stavka = Console.ReadLine();
                        if (stavka == "y" || stavka == "n")
                        {
                            break;
                        }
                    }
                }
                if (stavka == "y")
                {
                    Console.Write("Введіть суму, яку ви ставите ставите: ");
                    upStavka = Convert.ToInt32(Console.ReadLine());
                    if (upStavka <= 0 || upStavka > kesh)
                    {
                        while (true)
                        {
                            Console.WriteLine("Неправильна сума.");
                            Console.Write("Не можна ставити 0 і менше, а також більше, ніж ви маєте. Спробуйте знову: ");
                            upStavka = Convert.ToInt32(Console.ReadLine());
                            if (upStavka > 0 && upStavka <= kesh)
                            {
                                kesh -= upStavka;
                                upStavka *= 2;
                                sum += upStavka;
                                break;
                            }
                        }
                    }
                    kesh -= upStavka;
                    upStavka *= 2;
                    sum += upStavka;
                    Console.WriteLine("Чудово!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Добре.");
                    Console.WriteLine();
                    kesh -= 10;
                    sum += 10 * 2;
                }
                Console.Clear();
                while (true)
                {
                    mast = rand.Next(masti.Length);
                    otkritaMast1 = masti[mast];
                    number = rand.Next(koloda.Count);
                    otkritaNumber1 = Convert.ToString(koloda[number]);
                    switch (otkritaNumber1)
                    {
                        case "11":
                            otkritaNumber1 = "V";
                            break;
                        case "12":
                            otkritaNumber1 = "D";
                            break;
                        case "13":
                            otkritaNumber1 = "K";
                            break;
                        case "14":
                            otkritaNumber1 = "A";
                            break;
                    }
                    otkritaKarta1 = otkritaNumber1 + otkritaMast1;
                    if (proverka.Contains(otkritaKarta1))
                    {
                        continue;
                    }
                    else if (!proverka.Contains(otkritaKarta1))
                    {
                        break;
                    }

                }
                koloda.RemoveAt(number);
                proverka.Add(otkritaKarta1);
                table[7, 16] = otkritaNumber1;
                table[7, 17] = otkritaMast1;
                while (true)
                {
                    mast = rand.Next(masti.Length);
                    otkritaMast2 = masti[mast];
                    number = rand.Next(koloda.Count);
                    otkritaNumber2 = Convert.ToString(koloda[number]);
                    switch (otkritaNumber2)
                    {
                        case "11":
                            otkritaNumber2 = "V";
                            break;
                        case "12":
                            otkritaNumber2 = "D";
                            break;
                        case "13":
                            otkritaNumber2 = "K";
                            break;
                        case "14":
                            otkritaNumber2 = "A";
                            break;
                    }
                    otkritaKarta2 = otkritaNumber2 + otkritaMast2;
                    if (proverka.Contains(otkritaKarta2))
                    {
                        continue;
                    }
                    else if (!proverka.Contains(otkritaKarta2))
                    {
                        break;
                    }
                }
                koloda.RemoveAt(number);
                proverka.Add(otkritaKarta2);
                table[7, 20] = otkritaNumber2;
                table[7, 21] = otkritaMast2;
                while (true)
                {
                    mast = rand.Next(masti.Length);
                    otkritaMast3 = masti[mast];
                    number = rand.Next(koloda.Count);
                    otkritaNumber3 = Convert.ToString(koloda[number]);
                    switch (otkritaNumber3)
                    {
                        case "11":
                            otkritaNumber3 = "V";
                            break;
                        case "12":
                            otkritaNumber3 = "D";
                            break;
                        case "13":
                            otkritaNumber3 = "K";
                            break;
                        case "14":
                            otkritaNumber3 = "A";
                            break;
                    }
                    otkritaKarta3 = otkritaNumber3 + otkritaMast3;
                    if (proverka.Contains(otkritaKarta3))
                    {
                        continue;
                    }
                    else if (!proverka.Contains(otkritaKarta3))
                    {
                        break;
                    }
                }
                koloda.RemoveAt(number);
                proverka.Add(otkritaKarta3);
                table[7, 24] = otkritaNumber3;
                table[7, 25] = otkritaMast3;
                for (int i = 0; i <= 3; i++)
                {
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine("Ваш баланс: " + kesh);
                    for (int a = 0; a < table.GetLength(0); a++)
                    {
                        for (int b = 0; b < table.GetLength(1); b++)
                        {
                            Console.SetCursorPosition(31 + b, 6 + a);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            if (table[a, b] == "#")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.BackgroundColor = ConsoleColor.DarkYellow;
                                Console.Write(table[a, b]);
                                Console.ResetColor();
                            }
                            else if (table[a, b] == "?")
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write(table[a, b]);
                                Console.ResetColor();
                            }
                            else if (table[a, b + 1] == "10" || table[a, b + 1] == "0")
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                if (table[a, b + 2] == "♥" || table[a, b + 2] == "♦")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                }
                                else if (table[a, b + 2] == "♠" || table[a, b + 2] == "♣")
                                {
                                    Console.ForegroundColor = ConsoleColor.Black;
                                }
                                Console.BackgroundColor = ConsoleColor.White;
                                table[a, b] = "1";
                                Console.Write(table[a, b]);
                                table[a, b + 1] = "0";
                                Console.ResetColor();
                                continue;
                            }
                            else if (table[a, b + 1] == "♥" || table[a, b + 1] == "♦")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.Write(table[a, b]);
                                Console.ResetColor();
                            }
                            else if (table[a, b] == "♥" || table[a, b] == "♦")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.Write(table[a, b]);
                                Console.ResetColor();
                            }
                            else if (table[a, b + 1] == "♠" || table[a, b + 1] == "♣")
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.Write(table[a, b]);
                                Console.ResetColor();
                            }
                            else if (table[a, b] == "♠" || table[a, b] == "♣")
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.Write(table[a, b]);
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write(table[a, b]);
                            }
                        }
                        Console.WriteLine();
                    }
                    Console.ResetColor();
                    Console.SetCursorPosition(0, 27);
                    Console.WriteLine("Можливі комбінації(від найстаршої): ");
                    for (int a = 0; a < kombo.GetLength(0); a++)
                    {
                        for (int b = 0; b < kombo.GetLength(1); b++)
                        {
                            Console.SetCursorPosition(0 + b, 28 + a);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            if (kombo[a, b] == "#")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.BackgroundColor = ConsoleColor.DarkYellow;
                                Console.Write(kombo[a, b]);
                                Console.ResetColor();
                            }
                            else if (kombo[a, b] == "1" && kombo[a, b + 1] == "0" && (kombo[a, b + 2] == "♥" || kombo[a, b + 2] == "♦" || kombo[a, b + 2] == "♠" || kombo[a, b + 2] == "♣"))
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                if (kombo[a, b + 2] == "♥" || kombo[a, b + 2] == "♦")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                }
                                else if (kombo[a, b + 2] == "♠" || kombo[a, b + 2] == "♣")
                                {
                                    Console.ForegroundColor = ConsoleColor.Black;
                                }
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.Write(kombo[a, b]);
                                Console.ResetColor();
                                continue;
                            }
                            else if (kombo[a, b + 1] == "♥" || kombo[a, b + 1] == "♦")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.Write(kombo[a, b]);
                                Console.ResetColor();
                            }
                            else if (kombo[a, b] == "♥" || kombo[a, b] == "♦")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.Write(kombo[a, b]);
                                Console.ResetColor();
                            }
                            else if (kombo[a, b + 1] == "♠" || kombo[a, b + 1] == "♣")
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.Write(kombo[a, b]);
                                Console.ResetColor();
                            }
                            else if (kombo[a, b] == "♠" || kombo[a, b] == "♣")
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.Write(kombo[a, b]);
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write(kombo[a, b]);
                            }
                        }
                        Console.WriteLine();
                    }
                    Console.ResetColor();
                    if (i == 3)
                    {
                        i = 0;
                        Console.Clear();
                        break;
                    }
                    Console.SetCursorPosition(0, 21);
                    Console.WriteLine();
                    Console.WriteLine("Сумма: " + sum);
                    Console.WriteLine();
                    Console.Write("Бажаєте підняти ставку(y/n): ");
                    nextStavka = Console.ReadLine();
                    if (nextStavka != "y" && nextStavka != "n")
                    {
                        while (true)
                        {
                            Console.Write("Неправильний ввід. Спробуйте знову: ");
                            nextStavka = Console.ReadLine();
                            nextStavka = Console.ReadLine();
                            if (nextStavka == "y" || nextStavka == "n")
                            {
                                break;
                            }
                        }
                    }
                    if (nextStavka == "y")
                    {
                        Console.Write("Введіть суму, яку ви ставите ставите: ");
                        upStavka = Convert.ToInt32(Console.ReadLine());
                        if (upStavka <= 0 || upStavka > kesh)
                        {
                            while (true)
                            {
                                Console.WriteLine("Неправильна сума.");
                                Console.Write("Не можна ставити 0 і менше, а також більше, ніж ви маєте. Спробуйте знову: ");
                                upStavka = Convert.ToInt32(Console.ReadLine());
                                if (upStavka > 0 && upStavka <= kesh)
                                {
                                    kesh -= upStavka;
                                    upStavka *= 2;
                                    sum += upStavka;
                                    break;
                                }
                            }
                        }
                        kesh -= upStavka;
                        upStavka *= 2;
                        sum += upStavka;
                        Console.WriteLine("Чудово!");
                    }
                    else
                    {
                        Console.WriteLine("Добре.");
                    }
                    Console.Clear();
                    if (i == 0)
                    {
                        while (true)
                        {
                            mast = rand.Next(masti.Length);
                            skritaMast1 = masti[mast];
                            number = rand.Next(koloda.Count);
                            skritaNumber1 = Convert.ToString(koloda[number]);
                            switch (skritaNumber1)
                            {
                                case "11":
                                    skritaNumber1 = "V";
                                    break;
                                case "12":
                                    skritaNumber1 = "D";
                                    break;
                                case "13":
                                    skritaNumber1 = "K";
                                    break;
                                case "14":
                                    skritaNumber1 = "A";
                                    break;
                            }
                            skritaKarta1 = skritaNumber1 + skritaMast1;
                            if (proverka.Contains(skritaKarta1))
                            {
                                continue;
                            }
                            else if (!proverka.Contains(skritaKarta1))
                            {
                                break;
                            }

                        }
                        koloda.RemoveAt(number);
                        proverka.Add(skritaKarta1);
                        table[7, 28] = skritaNumber1;
                        table[7, 29] = skritaMast1;
                    }
                    else if (i == 1)
                    {
                        while (true)
                        {
                            mast = rand.Next(masti.Length);
                            skritaMast2 = masti[mast];
                            number = rand.Next(koloda.Count);
                            skritaNumber2 = Convert.ToString(koloda[number]);
                            switch (skritaNumber2)
                            {
                                case "11":
                                    skritaNumber2 = "V";
                                    break;
                                case "12":
                                    skritaNumber2 = "D";
                                    break;
                                case "13":
                                    skritaNumber2 = "K";
                                    break;
                                case "14":
                                    skritaNumber2 = "A";
                                    break;
                            }
                            skritaKarta2 = skritaNumber2 + skritaMast2;
                            if (proverka.Contains(skritaKarta2))
                            {
                                continue;
                            }
                            else if (!proverka.Contains(skritaKarta2))
                            {
                                break;
                            }

                        }
                        koloda.RemoveAt(number);
                        proverka.Add(skritaKarta2);
                        table[7, 32] = skritaNumber2;
                        table[7, 33] = skritaMast2;
                    }
                    else if (i == 2)
                    {
                        while (true)
                        {
                            mast = rand.Next(masti.Length);
                            dilerMast1 = masti[mast];
                            number = rand.Next(koloda.Count);
                            dilerNumber1 = Convert.ToString(koloda[number]);
                            switch (dilerNumber1)
                            {
                                case "11":
                                    dilerNumber1 = "V";
                                    break;
                                case "12":
                                    dilerNumber1 = "D";
                                    break;
                                case "13":
                                    dilerNumber1 = "K";
                                    break;
                                case "14":
                                    dilerNumber1 = "A";
                                    break;
                            }
                            dilerKarta1 = dilerNumber1 + dilerMast1;
                            if (proverka.Contains(dilerKarta1))
                            {
                                continue;
                            }
                            else if (!proverka.Contains(dilerKarta1))
                            {
                                break;
                            }

                        }
                        koloda.RemoveAt(number);
                        proverka.Add(dilerKarta1);
                        table[3, 21] = dilerNumber1;
                        table[3, 22] = dilerMast1;
                        while (true)
                        {
                            mast = rand.Next(masti.Length);
                            dilerMast2 = masti[mast];
                            number = rand.Next(koloda.Count);
                            dilerNumber2 = Convert.ToString(koloda[number]);
                            switch (dilerNumber2)
                            {
                                case "11":
                                    dilerNumber2 = "V";
                                    break;
                                case "12":
                                    dilerNumber2 = "D";
                                    break;
                                case "13":
                                    dilerNumber2 = "K";
                                    break;
                                case "14":
                                    dilerNumber2 = "A";
                                    break;
                            }
                            dilerKarta2 = dilerNumber2 + dilerMast2;
                            if (proverka.Contains(dilerKarta2))
                            {
                                continue;
                            }
                            else if (!proverka.Contains(dilerKarta2))
                            {
                                break;
                            }

                        }
                        koloda.RemoveAt(number);
                        proverka.Add(dilerKarta2);
                        table[3, 25] = dilerNumber2;
                        table[3, 26] = dilerMast2;
                    }
                }
                string[] myNumbers = new string[7];
                string[] dilerNumbers = new string[7];
                myNumbers[0] = myNumber1;
                myNumbers[1] = myNumber2;
                myNumbers[2] = otkritaNumber1;
                myNumbers[3] = otkritaNumber2;
                myNumbers[4] = otkritaNumber3;
                myNumbers[5] = skritaNumber1;
                myNumbers[6] = skritaNumber2;
                dilerNumbers[0] = dilerNumber1;
                dilerNumbers[1] = dilerNumber2;
                dilerNumbers[2] = otkritaNumber1;
                dilerNumbers[3] = otkritaNumber2;
                dilerNumbers[4] = otkritaNumber3;
                dilerNumbers[5] = skritaNumber1;
                dilerNumbers[6] = skritaNumber2;
                string[] myMasts = new string[7];
                string[] dilerMasts = new string[7];
                myMasts[0] = myMast1;
                myMasts[1] = myMast2;
                myMasts[2] = otkritaMast1;
                myMasts[3] = otkritaMast2;
                myMasts[4] = otkritaMast3;
                myMasts[5] = skritaMast1;
                myMasts[6] = skritaMast2;
                dilerMasts[0] = dilerMast1;
                dilerMasts[1] = dilerMast2;
                dilerMasts[2] = otkritaMast1;
                dilerMasts[3] = otkritaMast2;
                dilerMasts[4] = otkritaMast3;
                dilerMasts[5] = skritaMast1;
                dilerMasts[6] = skritaMast2;
                string[] myKarts = new string[7];
                string[] dilerKarts = new string[7];
                myMasts[0] = myKarta1;
                myMasts[1] = myKarta2;
                myMasts[2] = otkritaKarta1;
                myMasts[3] = otkritaKarta2;
                myMasts[4] = otkritaKarta3;
                myMasts[5] = skritaKarta1;
                myMasts[6] = skritaKarta2;
                dilerMasts[0] = dilerKarta1;
                dilerMasts[1] = dilerKarta2;
                dilerMasts[2] = otkritaKarta1;
                dilerMasts[3] = otkritaKarta2;
                dilerMasts[4] = otkritaKarta3;
                dilerMasts[5] = skritaKarta1;
                dilerMasts[6] = skritaKarta2;
                bool prufMyPara2 = myNumbers.Count(x => x == "2") == 2;
                bool prufMyPara3 = myNumbers.Count(x => x == "3") == 2;
                bool prufMyPara4 = myNumbers.Count(x => x == "4") == 2;
                bool prufMyPara5 = myNumbers.Count(x => x == "5") == 2;
                bool prufMyPara6 = myNumbers.Count(x => x == "6") == 2;
                bool prufMyPara7 = myNumbers.Count(x => x == "7") == 2;
                bool prufMyPara8 = myNumbers.Count(x => x == "8") == 2;
                bool prufMyPara9 = myNumbers.Count(x => x == "9") == 2;
                bool prufMyPara10 = myNumbers.Count(x => x == "10") == 2;
                bool prufMyParaV = myNumbers.Count(x => x == "V") == 2;
                bool prufMyParaD = myNumbers.Count(x => x == "D") == 2;
                bool prufMyParaK = myNumbers.Count(x => x == "K") == 2;
                bool prufMyParaA = myNumbers.Count(x => x == "A") == 2;
                bool prufMyPara23 = prufMyPara2 && prufMyPara3;
                bool prufMyPara24 = prufMyPara2 && prufMyPara4;
                bool prufMyPara25 = prufMyPara2 && prufMyPara5;
                bool prufMyPara26 = prufMyPara2 && prufMyPara6;
                bool prufMyPara27 = prufMyPara2 && prufMyPara7;
                bool prufMyPara28 = prufMyPara2 && prufMyPara8;
                bool prufMyPara29 = prufMyPara2 && prufMyPara9;
                bool prufMyPara210 = prufMyPara2 && prufMyPara10;
                bool prufMyPara2V = prufMyPara2 && prufMyParaV;
                bool prufMyPara2D = prufMyPara2 && prufMyParaD;
                bool prufMyPara2K = prufMyPara2 && prufMyParaK;
                bool prufMyPara2A = prufMyPara2 && prufMyParaA;
                bool prufMyPara34 = prufMyPara3 && prufMyPara4;
                bool prufMyPara35 = prufMyPara3 && prufMyPara5;
                bool prufMyPara36 = prufMyPara3 && prufMyPara6;
                bool prufMyPara37 = prufMyPara3 && prufMyPara7;
                bool prufMyPara38 = prufMyPara3 && prufMyPara8;
                bool prufMyPara39 = prufMyPara3 && prufMyPara9;
                bool prufMyPara310 = prufMyPara3 && prufMyPara10;
                bool prufMyPara3V = prufMyPara3 && prufMyParaV;
                bool prufMyPara3D = prufMyPara3 && prufMyParaD;
                bool prufMyPara3K = prufMyPara3 && prufMyParaK;
                bool prufMyPara3A = prufMyPara3 && prufMyParaA;
                bool prufMyPara45 = prufMyPara4 && prufMyPara5;
                bool prufMyPara46 = prufMyPara4 && prufMyPara6;
                bool prufMyPara47 = prufMyPara4 && prufMyPara7;
                bool prufMyPara48 = prufMyPara4 && prufMyPara8;
                bool prufMyPara49 = prufMyPara4 && prufMyPara9;
                bool prufMyPara410 = prufMyPara4 && prufMyPara10;
                bool prufMyPara4V = prufMyPara4 && prufMyParaV;
                bool prufMyPara4D = prufMyPara4 && prufMyParaD;
                bool prufMyPara4K = prufMyPara4 && prufMyParaK;
                bool prufMyPara4A = prufMyPara4 && prufMyParaA;
                bool prufMyPara56 = prufMyPara5 && prufMyPara6;
                bool prufMyPara57 = prufMyPara5 && prufMyPara7;
                bool prufMyPara58 = prufMyPara5 && prufMyPara8;
                bool prufMyPara59 = prufMyPara5 && prufMyPara9;
                bool prufMyPara510 = prufMyPara5 && prufMyPara10;
                bool prufMyPara5V = prufMyPara5 && prufMyParaV;
                bool prufMyPara5D = prufMyPara5 && prufMyParaD;
                bool prufMyPara5K = prufMyPara5 && prufMyParaK;
                bool prufMyPara5A = prufMyPara5 && prufMyParaA;
                bool prufMyPara67 = prufMyPara6 && prufMyPara7;
                bool prufMyPara68 = prufMyPara6 && prufMyPara8;
                bool prufMyPara69 = prufMyPara6 && prufMyPara9;
                bool prufMyPara610 = prufMyPara6 && prufMyPara10;
                bool prufMyPara6V = prufMyPara6 && prufMyParaV;
                bool prufMyPara6D = prufMyPara6 && prufMyParaD;
                bool prufMyPara6K = prufMyPara6 && prufMyParaK;
                bool prufMyPara6A = prufMyPara6 && prufMyParaA;
                bool prufMyPara78 = prufMyPara7 && prufMyPara8;
                bool prufMyPara79 = prufMyPara7 && prufMyPara9;
                bool prufMyPara710 = prufMyPara7 && prufMyPara10;
                bool prufMyPara7V = prufMyPara7 && prufMyParaV;
                bool prufMyPara7D = prufMyPara7 && prufMyParaD;
                bool prufMyPara7K = prufMyPara7 && prufMyParaK;
                bool prufMyPara7A = prufMyPara7 && prufMyParaA;
                bool prufMyPara89 = prufMyPara8 && prufMyPara9;
                bool prufMyPara810 = prufMyPara8 && prufMyPara10;
                bool prufMyPara8V = prufMyPara8 && prufMyParaV;
                bool prufMyPara8D = prufMyPara8 && prufMyParaD;
                bool prufMyPara8K = prufMyPara8 && prufMyParaK;
                bool prufMyPara8A = prufMyPara8 && prufMyParaA;
                bool prufMyPara910 = prufMyPara9 && prufMyPara10;
                bool prufMyPara9V = prufMyPara9 && prufMyParaV;
                bool prufMyPara9D = prufMyPara9 && prufMyParaD;
                bool prufMyPara9K = prufMyPara9 && prufMyParaK;
                bool prufMyPara9A = prufMyPara9 && prufMyParaA;
                bool prufMyPara10V = prufMyPara10 && prufMyParaV;
                bool prufMyPara10D = prufMyPara10 && prufMyParaD;
                bool prufMyPara10K = prufMyPara10 && prufMyParaK;
                bool prufMyPara10A = prufMyPara10 && prufMyParaA;
                bool prufMyParaVD = prufMyParaV && prufMyParaD;
                bool prufMyParaVK = prufMyParaV && prufMyParaK;
                bool prufMyParaVA = prufMyParaV && prufMyParaA;
                bool prufMyParaDK = prufMyParaD && prufMyParaK;
                bool prufMyParaDA = prufMyParaD && prufMyParaA;
                bool prufMyParaKA = prufMyParaK && prufMyParaA;
                bool prufMySet2 = myNumbers.Count(x => x == "2") == 3;
                bool prufMySet3 = myNumbers.Count(x => x == "3") == 3;
                bool prufMySet4 = myNumbers.Count(x => x == "4") == 3;
                bool prufMySet5 = myNumbers.Count(x => x == "5") == 3;
                bool prufMySet6 = myNumbers.Count(x => x == "6") == 3;
                bool prufMySet7 = myNumbers.Count(x => x == "7") == 3;
                bool prufMySet8 = myNumbers.Count(x => x == "8") == 3;
                bool prufMySet9 = myNumbers.Count(x => x == "9") == 3;
                bool prufMySet10 = myNumbers.Count(x => x == "10") == 3;
                bool prufMySetV = myNumbers.Count(x => x == "V") == 3;
                bool prufMySetD = myNumbers.Count(x => x == "D") == 3;
                bool prufMySetK = myNumbers.Count(x => x == "K") == 3;
                bool prufMySetA = myNumbers.Count(x => x == "A") == 3;
                string[] strit26 = { "2", "3", "4", "5", "6" };
                string[] strit37 = { "3", "4", "5", "6", "7" };
                string[] strit48 = { "4", "5", "6", "7", "8" };
                string[] strit59 = { "5", "6", "7", "8", "9" };
                string[] strit610 = { "6", "7", "8", "9", "10" };
                string[] strit7V = { "7", "8", "9", "10", "V" };
                string[] strit8D = { "8", "9", "10", "V", "D" };
                string[] strit9K = { "9", "10", "V", "D", "K" };
                string[] strit10A = { "10", "V", "D", "K", "A" };
                bool prufMyStrit26 = strit26.All(elements => myNumbers.Contains(elements));
                bool prufMyStrit37 = strit37.All(elements => myNumbers.Contains(elements));
                bool prufMyStrit48 = strit48.All(elements => myNumbers.Contains(elements));
                bool prufMyStrit59 = strit59.All(elements => myNumbers.Contains(elements));
                bool prufMyStrit610 = strit610.All(elements => myNumbers.Contains(elements));
                bool prufMyStrit7V = strit7V.All(elements => myNumbers.Contains(elements));
                bool prufMyStrit8D = strit8D.All(elements => myNumbers.Contains(elements));
                bool prufMyStrit9K = strit9K.All(elements => myNumbers.Contains(elements));
                bool prufMyStrit10A = strit10A.All(elements => myNumbers.Contains(elements));
                bool prufMyFleshPika = myMasts.Count(x => x == "♠") >= 5;
                bool prufMyFleshChirva = myMasts.Count(x => x == "♥") >= 5;
                bool prufMyFleshBuba = myMasts.Count(x => x == "♦") >= 5;
                bool prufMyFleshHresta = myMasts.Count(x => x == "♣") >= 5;
                bool prufMyFullHouse23 = prufMyPara2 && prufMySet3;
                bool prufMyFullHouse24 = prufMyPara2 && prufMySet4;
                bool prufMyFullHouse25 = prufMyPara2 && prufMySet5;
                bool prufMyFullHouse26 = prufMyPara2 && prufMySet6;
                bool prufMyFullHouse27 = prufMyPara2 && prufMySet7;
                bool prufMyFullHouse28 = prufMyPara2 && prufMySet8;
                bool prufMyFullHouse29 = prufMyPara2 && prufMySet9;
                bool prufMyFullHouse210 = prufMyPara2 && prufMySet10;
                bool prufMyFullHouse2V = prufMyPara2 && prufMySetV;
                bool prufMyFullHouse2D = prufMyPara2 && prufMySetD;
                bool prufMyFullHouse2K = prufMyPara2 && prufMySetK;
                bool prufMyFullHouse2A = prufMyPara2 && prufMySetA;
                bool prufMyFullHouse32 = prufMyPara3 && prufMySet2;
                bool prufMyFullHouse34 = prufMyPara3 && prufMySet4;
                bool prufMyFullHouse35 = prufMyPara3 && prufMySet5;
                bool prufMyFullHouse36 = prufMyPara3 && prufMySet6;
                bool prufMyFullHouse37 = prufMyPara3 && prufMySet7;
                bool prufMyFullHouse38 = prufMyPara3 && prufMySet8;
                bool prufMyFullHouse39 = prufMyPara3 && prufMySet9;
                bool prufMyFullHouse310 = prufMyPara3 && prufMySet10;
                bool prufMyFullHouse3V = prufMyPara3 && prufMySetV;
                bool prufMyFullHouse3D = prufMyPara3 && prufMySetD;
                bool prufMyFullHouse3K = prufMyPara3 && prufMySetK;
                bool prufMyFullHouse3A = prufMyPara3 && prufMySetA;
                bool prufMyFullHouse42 = prufMyPara4 && prufMySet2;
                bool prufMyFullHouse43 = prufMyPara4 && prufMySet3;
                bool prufMyFullHouse45 = prufMyPara4 && prufMySet5;
                bool prufMyFullHouse46 = prufMyPara4 && prufMySet6;
                bool prufMyFullHouse47 = prufMyPara4 && prufMySet7;
                bool prufMyFullHouse48 = prufMyPara4 && prufMySet8;
                bool prufMyFullHouse49 = prufMyPara4 && prufMySet9;
                bool prufMyFullHouse410 = prufMyPara4 && prufMySet10;
                bool prufMyFullHouse4V = prufMyPara4 && prufMySetV;
                bool prufMyFullHouse4D = prufMyPara4 && prufMySetD;
                bool prufMyFullHouse4K = prufMyPara4 && prufMySetK;
                bool prufMyFullHouse4A = prufMyPara4 && prufMySetA;
                bool prufMyFullHouse52 = prufMyPara5 && prufMySet2;
                bool prufMyFullHouse53 = prufMyPara5 && prufMySet3;
                bool prufMyFullHouse54 = prufMyPara5 && prufMySet4;
                bool prufMyFullHouse56 = prufMyPara5 && prufMySet6;
                bool prufMyFullHouse57 = prufMyPara5 && prufMySet7;
                bool prufMyFullHouse58 = prufMyPara5 && prufMySet8;
                bool prufMyFullHouse59 = prufMyPara5 && prufMySet9;
                bool prufMyFullHouse510 = prufMyPara5 && prufMySet10;
                bool prufMyFullHouse5V = prufMyPara5 && prufMySetV;
                bool prufMyFullHouse5D = prufMyPara5 && prufMySetD;
                bool prufMyFullHouse5K = prufMyPara5 && prufMySetK;
                bool prufMyFullHouse5A = prufMyPara5 && prufMySetA;
                bool prufMyFullHouse62 = prufMyPara6 && prufMySet2;
                bool prufMyFullHouse63 = prufMyPara6 && prufMySet3;
                bool prufMyFullHouse64 = prufMyPara6 && prufMySet4;
                bool prufMyFullHouse65 = prufMyPara6 && prufMySet5;
                bool prufMyFullHouse67 = prufMyPara6 && prufMySet7;
                bool prufMyFullHouse68 = prufMyPara6 && prufMySet8;
                bool prufMyFullHouse69 = prufMyPara6 && prufMySet9;
                bool prufMyFullHouse610 = prufMyPara6 && prufMySet10;
                bool prufMyFullHouse6V = prufMyPara6 && prufMySetV;
                bool prufMyFullHouse6D = prufMyPara6 && prufMySetD;
                bool prufMyFullHouse6K = prufMyPara6 && prufMySetK;
                bool prufMyFullHouse6A = prufMyPara6 && prufMySetA;
                bool prufMyFullHouse72 = prufMyPara7 && prufMySet2;
                bool prufMyFullHouse73 = prufMyPara7 && prufMySet3;
                bool prufMyFullHouse74 = prufMyPara7 && prufMySet4;
                bool prufMyFullHouse75 = prufMyPara7 && prufMySet5;
                bool prufMyFullHouse76 = prufMyPara7 && prufMySet6;
                bool prufMyFullHouse78 = prufMyPara7 && prufMySet8;
                bool prufMyFullHouse79 = prufMyPara7 && prufMySet9;
                bool prufMyFullHouse710 = prufMyPara7 && prufMySet10;
                bool prufMyFullHouse7V = prufMyPara7 && prufMySetV;
                bool prufMyFullHouse7D = prufMyPara7 && prufMySetD;
                bool prufMyFullHouse7K = prufMyPara7 && prufMySetK;
                bool prufMyFullHouse7A = prufMyPara7 && prufMySetA;
                bool prufMyFullHouse82 = prufMyPara8 && prufMySet2;
                bool prufMyFullHouse83 = prufMyPara8 && prufMySet3;
                bool prufMyFullHouse84 = prufMyPara8 && prufMySet4;
                bool prufMyFullHouse85 = prufMyPara8 && prufMySet5;
                bool prufMyFullHouse86 = prufMyPara8 && prufMySet6;
                bool prufMyFullHouse87 = prufMyPara8 && prufMySet7;
                bool prufMyFullHouse89 = prufMyPara8 && prufMySet9;
                bool prufMyFullHouse810 = prufMyPara8 && prufMySet10;
                bool prufMyFullHouse8V = prufMyPara8 && prufMySetV;
                bool prufMyFullHouse8D = prufMyPara8 && prufMySetD;
                bool prufMyFullHouse8K = prufMyPara8 && prufMySetK;
                bool prufMyFullHouse8A = prufMyPara8 && prufMySetA;
                bool prufMyFullHouse92 = prufMyPara9 && prufMySet2;
                bool prufMyFullHouse93 = prufMyPara9 && prufMySet3;
                bool prufMyFullHouse94 = prufMyPara9 && prufMySet4;
                bool prufMyFullHouse95 = prufMyPara9 && prufMySet5;
                bool prufMyFullHouse96 = prufMyPara9 && prufMySet6;
                bool prufMyFullHouse97 = prufMyPara9 && prufMySet7;
                bool prufMyFullHouse98 = prufMyPara9 && prufMySet8;
                bool prufMyFullHouse910 = prufMyPara9 && prufMySet10;
                bool prufMyFullHouse9V = prufMyPara9 && prufMySetV;
                bool prufMyFullHouse9D = prufMyPara9 && prufMySetD;
                bool prufMyFullHouse9K = prufMyPara9 && prufMySetK;
                bool prufMyFullHouse9A = prufMyPara9 && prufMySetA;
                bool prufMyFullHouse102 = prufMyPara10 && prufMySet2;
                bool prufMyFullHouse103 = prufMyPara10 && prufMySet3;
                bool prufMyFullHouse104 = prufMyPara10 && prufMySet4;
                bool prufMyFullHouse105 = prufMyPara10 && prufMySet5;
                bool prufMyFullHouse106 = prufMyPara10 && prufMySet6;
                bool prufMyFullHouse107 = prufMyPara10 && prufMySet7;
                bool prufMyFullHouse108 = prufMyPara10 && prufMySet8;
                bool prufMyFullHouse109 = prufMyPara10 && prufMySet9;
                bool prufMyFullHouse10V = prufMyPara10 && prufMySetV;
                bool prufMyFullHouse10D = prufMyPara10 && prufMySetD;
                bool prufMyFullHouse10K = prufMyPara10 && prufMySetK;
                bool prufMyFullHouse10A = prufMyPara10 && prufMySetA;
                bool prufMyFullHouseV2 = prufMyParaV && prufMySet2;
                bool prufMyFullHouseV3 = prufMyParaV && prufMySet3;
                bool prufMyFullHouseV4 = prufMyParaV && prufMySet4;
                bool prufMyFullHouseV5 = prufMyParaV && prufMySet5;
                bool prufMyFullHouseV6 = prufMyParaV && prufMySet6;
                bool prufMyFullHouseV7 = prufMyParaV && prufMySet7;
                bool prufMyFullHouseV8 = prufMyParaV && prufMySet8;
                bool prufMyFullHouseV9 = prufMyParaV && prufMySet9;
                bool prufMyFullHouseV10 = prufMyParaV && prufMySet10;
                bool prufMyFullHouseVD = prufMyParaV && prufMySetD;
                bool prufMyFullHouseVK = prufMyParaV && prufMySetK;
                bool prufMyFullHouseVA = prufMyParaV && prufMySetA;
                bool prufMyFullHouseD2 = prufMyParaD && prufMySet2;
                bool prufMyFullHouseD3 = prufMyParaD && prufMySet3;
                bool prufMyFullHouseD4 = prufMyParaD && prufMySet4;
                bool prufMyFullHouseD5 = prufMyParaD && prufMySet5;
                bool prufMyFullHouseD6 = prufMyParaD && prufMySet6;
                bool prufMyFullHouseD7 = prufMyParaD && prufMySet7;
                bool prufMyFullHouseD8 = prufMyParaD && prufMySet8;
                bool prufMyFullHouseD9 = prufMyParaD && prufMySet9;
                bool prufMyFullHouseD10 = prufMyParaD && prufMySet10;
                bool prufMyFullHouseDV = prufMyParaD && prufMySetV;
                bool prufMyFullHouseDK = prufMyParaD && prufMySetK;
                bool prufMyFullHouseDA = prufMyParaD && prufMySetA;
                bool prufMyFullHouseK2 = prufMyParaK && prufMySet2;
                bool prufMyFullHouseK3 = prufMyParaK && prufMySet3;
                bool prufMyFullHouseK4 = prufMyParaK && prufMySet4;
                bool prufMyFullHouseK5 = prufMyParaK && prufMySet5;
                bool prufMyFullHouseK6 = prufMyParaK && prufMySet6;
                bool prufMyFullHouseK7 = prufMyParaK && prufMySet7;
                bool prufMyFullHouseK8 = prufMyParaK && prufMySet8;
                bool prufMyFullHouseK9 = prufMyParaK && prufMySet9;
                bool prufMyFullHouseK10 = prufMyParaK && prufMySet10;
                bool prufMyFullHouseKV = prufMyParaK && prufMySetV;
                bool prufMyFullHouseKD = prufMyParaK && prufMySetD;
                bool prufMyFullHouseKA = prufMyParaK && prufMySetA;
                bool prufMyFullHouseA2 = prufMyParaA && prufMySet2;
                bool prufMyFullHouseA3 = prufMyParaA && prufMySet3;
                bool prufMyFullHouseA4 = prufMyParaA && prufMySet4;
                bool prufMyFullHouseA5 = prufMyParaA && prufMySet5;
                bool prufMyFullHouseA6 = prufMyParaA && prufMySet6;
                bool prufMyFullHouseA7 = prufMyParaA && prufMySet7;
                bool prufMyFullHouseA8 = prufMyParaA && prufMySet8;
                bool prufMyFullHouseA9 = prufMyParaA && prufMySet9;
                bool prufMyFullHouseA10 = prufMyParaA && prufMySet10;
                bool prufMyFullHouseAV = prufMyParaA && prufMySetV;
                bool prufMyFullHouseAD = prufMyParaA && prufMySetD;
                bool prufMyFullHouseAK = prufMyParaA && prufMySetK;
                bool prufMyKare2 = myNumbers.Count(x => x == "2") == 4;
                bool prufMyKare3 = myNumbers.Count(x => x == "3") == 4;
                bool prufMyKare4 = myNumbers.Count(x => x == "4") == 4;
                bool prufMyKare5 = myNumbers.Count(x => x == "5") == 4;
                bool prufMyKare6 = myNumbers.Count(x => x == "6") == 4;
                bool prufMyKare7 = myNumbers.Count(x => x == "7") == 4;
                bool prufMyKare8 = myNumbers.Count(x => x == "8") == 4;
                bool prufMyKare9 = myNumbers.Count(x => x == "9") == 4;
                bool prufMyKare10 = myNumbers.Count(x => x == "10") == 4;
                bool prufMyKareV = myNumbers.Count(x => x == "V") == 4;
                bool prufMyKareD = myNumbers.Count(x => x == "D") == 4;
                bool prufMyKareK = myNumbers.Count(x => x == "K") == 4;
                bool prufMyKareA = myNumbers.Count(x => x == "A") == 4;
                string[] strit26Pika = { "2♠", "3♠", "4♠", "5♠", "6♠" };
                string[] strit26Chirva = { "2♥", "3♥", "4♥", "5♥", "6♥" };
                string[] strit26Buba = { "2♦", "3♦", "4♦", "5♦", "6♦" };
                string[] strit26Hresta = { "2♣", "3♣", "4♣", "5♣", "6♣" };
                string[] strit37Pika = { "3♠", "4♠", "5♠", "6♠", "7♠" };
                string[] strit37Chirva = { "3♥", "4♥", "5♥", "6♥", "7♥" };
                string[] strit37Buba = { "3♦", "4♦", "5♦", "6♦", "7♦" };
                string[] strit37Hresta = { "3♣", "4♣", "5♣", "6♣", "7♣" };
                string[] strit48Pika = { "4♠", "5♠", "6♠", "7♠", "8♠" };
                string[] strit48Chirva = { "4♥", "5♥", "6♥", "7♥", "8♥" };
                string[] strit48Buba = { "4♦", "5♦", "6♦", "7♦", "8♦" };
                string[] strit48Hresta = { "4♣", "5♣", "6♣", "7♣", "8♣" };
                string[] strit59Pika = { "5♠", "6♠", "7♠", "8♠", "9♠" };
                string[] strit59Chirva = { "5♥", "6♥", "7♥", "8♥", "9♥" };
                string[] strit59Buba = { "5♦", "6♦", "7♦", "8♦", "9♦" };
                string[] strit59Hresta = { "5♣", "6♣", "7♣", "8♣", "9♣" };
                string[] strit610Pika = { "6♠", "7♠", "8♠", "9♠", "10♠" };
                string[] strit610Chirva = { "6♥", "7♥", "8♥", "9♥", "10♥" };
                string[] strit610Buba = { "6♦", "7♦", "8♦", "9♦", "10♦" };
                string[] strit610Hresta = { "6♣", "7♣", "8♣", "9♣", "10♣" };
                string[] strit7VPika = { "7♠", "8♠", "9♠", "10♠", "V♠" };
                string[] strit7VChirva = { "7♥", "8♥", "9♥", "10♥", "V♥" };
                string[] strit7VBuba = { "7♦", "8♦", "9♦", "10♦", "V♦" };
                string[] strit7VHresta = { "7♣", "8♣", "9♣", "10♣", "V♣" };
                string[] strit8DPika = { "8♠", "9♠", "10♠", "V♠", "D♠" };
                string[] strit8DChirva = { "8♥", "9♥", "10♥", "V♥", "D♥" };
                string[] strit8DBuba = { "8♦", "9♦", "10♦", "V♦", "D♦" };
                string[] strit8DHresta = { "8♣", "9♣", "10♣", "V♣", "D♣" };
                string[] strit9KPika = { "9♠", "10♠", "V♠", "D♠", "K♠" };
                string[] strit9KChirva = { "9♥", "10♥", "V♥", "D♥", "K♥" };
                string[] strit9KBuba = { "9♦", "10♦", "V♦", "D♦", "K♦" };
                string[] strit9KHresta = { "9♣", "10♣", "V♣", "D♣", "K♣" };
                bool prufMyStrit26Pika = strit26Pika.All(elements => myKarts.Contains(elements));
                bool prufMyStrit26Chirva = strit26Chirva.All(elements => myKarts.Contains(elements));
                bool prufMyStrit26Buba = strit26Buba.All(elements => myKarts.Contains(elements));
                bool prufMyStrit26Hresta = strit26Hresta.All(elements => myKarts.Contains(elements));
                bool prufMyStrit37Pika = strit37Pika.All(elements => myKarts.Contains(elements));
                bool prufMyStrit37Chirva = strit37Chirva.All(elements => myKarts.Contains(elements));
                bool prufMyStrit37Buba = strit37Buba.All(elements => myKarts.Contains(elements));
                bool prufMyStrit37Hresta = strit37Hresta.All(elements => myKarts.Contains(elements));
                bool prufMyStrit48Pika = strit48Pika.All(elements => myKarts.Contains(elements));
                bool prufMyStrit48Chirva = strit48Chirva.All(elements => myKarts.Contains(elements));
                bool prufMyrStrit48Buba = strit48Buba.All(elements => myKarts.Contains(elements));
                bool prufMyStrit48Hresta = strit48Hresta.All(elements => myKarts.Contains(elements));
                bool prufMyStrit59Pika = strit59Pika.All(elements => myKarts.Contains(elements));
                bool prufMyStrit59Chirva = strit59Chirva.All(elements => myKarts.Contains(elements));
                bool prufMyStrit59Buba = strit59Buba.All(elements => myKarts.Contains(elements));
                bool prufMyStrit59Hresta = strit59Hresta.All(elements => myKarts.Contains(elements));
                bool prufMyStrit610Pika = strit610Pika.All(elements => myKarts.Contains(elements));
                bool prufMyStrit610Chirva = strit610Chirva.All(elements => myKarts.Contains(elements));
                bool prufMyStrit610Buba = strit610Buba.All(elements => myKarts.Contains(elements));
                bool prufMyStrit610Hresta = strit610Hresta.All(elements => myKarts.Contains(elements));
                bool prufMyStrit7VPika = strit7VPika.All(elements => myKarts.Contains(elements));
                bool prufMyStrit7VChirva = strit7VChirva.All(elements => myKarts.Contains(elements));
                bool prufMyStrit7VBuba = strit7VBuba.All(elements => myKarts.Contains(elements));
                bool prufMyStrit7VHresta = strit7VHresta.All(elements => myKarts.Contains(elements));
                bool prufMyStrit8DPika = strit8DPika.All(elements => myKarts.Contains(elements));
                bool prufMyStrit8DChirva = strit8DChirva.All(elements => myKarts.Contains(elements));
                bool prufMyStrit8DBuba = strit8DBuba.All(elements => myKarts.Contains(elements));
                bool prufMyStrit8DHresta = strit8DHresta.All(elements => myKarts.Contains(elements));
                bool prufMyStrit9KPika = strit9KPika.All(elements => myKarts.Contains(elements));
                bool prufMyStrit9KChirva = strit9KChirva.All(elements => myKarts.Contains(elements));
                bool prufMyStrit9KBuba = strit9KBuba.All(elements => myKarts.Contains(elements));
                bool prufMyStrit9KHresta = strit9KHresta.All(elements => myKarts.Contains(elements));
                string[] fleshRoialPika = { "10♠", "V♠", "D♠", "K♠", "A♠" };
                string[] fleshRoialChirva = { "10♥", "V♥", "D♥", "K♥", "A♥" };
                string[] fleshRoialBuba = { "10♦", "V♦", "D♦", "K♦", "A♦" };
                string[] fleshRoialHresta = { "10♣", "V♣", "D♣", "K♣", "A♣" };
                bool prufMyFleshRoialPika = fleshRoialPika.All(elements => myKarts.Contains(elements));
                bool prufMyFleshRoialChirva = fleshRoialChirva.All(elements => myKarts.Contains(elements));
                bool prufMyFleshRoialBuba = fleshRoialBuba.All(elements => myKarts.Contains(elements));
                bool prufMyFleshRoialHresta = fleshRoialHresta.All(elements => myKarts.Contains(elements));
                for (int a = 0; a < 1; a++)
                {
                    if (prufMyFleshRoialPika || prufMyFleshRoialChirva || prufMyFleshRoialBuba || prufMyFleshRoialHresta)
                    {
                        myWin += 10.1;
                        break;
                    }
                    if (prufMyStrit9KPika || prufMyStrit9KChirva || prufMyStrit9KBuba || prufMyStrit9KHresta)
                    {
                        myWin += 9.8;
                        break;
                    }
                    if (prufMyStrit8DPika || prufMyStrit8DChirva || prufMyStrit8DBuba || prufMyStrit8DHresta)
                    {
                        myWin += 9.7;
                        break;
                    }
                    if (prufMyStrit7VPika || prufMyStrit7VChirva || prufMyStrit7VBuba || prufMyStrit7VHresta)
                    {
                        myWin += 9.6;
                        break;
                    }
                    if (prufMyStrit610Pika || prufMyStrit610Chirva || prufMyStrit610Buba || prufMyStrit610Hresta)
                    {
                        myWin += 9.5;
                        break;
                    }
                    if (prufMyStrit59Pika || prufMyStrit59Chirva || prufMyStrit59Buba || prufMyStrit59Hresta)
                    {
                        myWin += 9.4;
                        break;
                    }
                    if (prufMyStrit48Pika || prufMyStrit48Chirva || prufMyrStrit48Buba || prufMyStrit48Hresta)
                    {
                        myWin += 9.3;
                        break;
                    }
                    if (prufMyStrit37Pika || prufMyStrit37Chirva || prufMyStrit37Buba || prufMyStrit37Hresta)
                    {
                        myWin += 9.2;
                        break;
                    }
                    if (prufMyStrit26Pika || prufMyStrit26Chirva || prufMyStrit26Buba || prufMyStrit26Hresta)
                    {
                        myWin += 9.1;
                        break;
                    }
                    if (prufMyKareA)
                    {
                        myWin += 8.14;
                        break;
                    }
                    if (prufMyKareK)
                    {
                        myWin += 8.13;
                        break;
                    }
                    if (prufMyKareD)
                    {
                        myWin += 8.12;
                        break;
                    }
                    if (prufMyKareV)
                    {
                        myWin += 8.11;
                        break;
                    }
                    if (prufMyKare10)
                    {
                        myWin += 8.10;
                        break;
                    }
                    if (prufMyKare9)
                    {
                        myWin += 8.09;
                        break;
                    }
                    if (prufMyKare8)
                    {
                        myWin += 8.08;
                        break;
                    }
                    if (prufMyKare7)
                    {
                        myWin += 8.07;
                        break;
                    }
                    if (prufMyKare6)
                    {
                        myWin += 8.06;
                        break;
                    }
                    if (prufMyKare5)
                    {
                        myWin += 8.05;
                        break;
                    }
                    if (prufMyKare4)
                    {
                        myWin += 8.04;
                        break;
                    }
                    if (prufMyKare3)
                    {
                        myWin += 8.03;
                        break;
                    }
                    if (prufMyKare2)
                    {
                        myWin += 8.02;
                        break;
                    }
                    if (prufMyFullHouseKA)
                    {
                        myWin += 7.156;
                        break;
                    }
                    if (prufMyFullHouseDA)
                    {
                        myWin += 7.155;
                        break;
                    }
                    if (prufMyFullHouseVA)
                    {
                        myWin += 7.154;
                        break;
                    }
                    if (prufMyFullHouse10A)
                    {
                        myWin += 7.153;
                        break;
                    }
                    if (prufMyFullHouse9A)
                    {
                        myWin += 7.152;
                        break;
                    }
                    if (prufMyFullHouse8A)
                    {
                        myWin += 7.151;
                        break;
                    }
                    if (prufMyFullHouse7A)
                    {
                        myWin += 7.150;
                        break;
                    }
                    if (prufMyFullHouse6A)
                    {
                        myWin += 7.149;
                        break;
                    }
                    if (prufMyFullHouse5A)
                    {
                        myWin += 7.148;
                        break;
                    }
                    if (prufMyFullHouse4A)
                    {
                        myWin += 7.147;
                        break;
                    }
                    if (prufMyFullHouse3A)
                    {
                        myWin += 7.146;
                        break;
                    }
                    if (prufMyFullHouse2A)
                    {
                        myWin += 7.145;
                        break;
                    }
                    if (prufMyFullHouseAK)
                    {
                        myWin += 7.144;
                        break;
                    }
                    if (prufMyFullHouseDK)
                    {
                        myWin += 7.143;
                        break;
                    }
                    if (prufMyFullHouseVK)
                    {
                        myWin += 7.142;
                        break;
                    }
                    if (prufMyFullHouse10K)
                    {
                        myWin += 7.141;
                        break;
                    }
                    if (prufMyFullHouse9K)
                    {
                        myWin += 7.140;
                        break;
                    }
                    if (prufMyFullHouse8K)
                    {
                        myWin += 7.139;
                        break;
                    }
                    if (prufMyFullHouse7K)
                    {
                        myWin += 7.138;
                        break;
                    }
                    if (prufMyFullHouse6K)
                    {
                        myWin += 7.137;
                        break;
                    }
                    if (prufMyFullHouse5K)
                    {
                        myWin += 7.136;
                        break;
                    }
                    if (prufMyFullHouse4K)
                    {
                        myWin += 7.135;
                        break;
                    }
                    if (prufMyFullHouse3K)
                    {
                        myWin += 7.134;
                        break;
                    }
                    if (prufMyFullHouse2K)
                    {
                        myWin += 7.133;
                        break;
                    }
                    if (prufMyFullHouseAD)
                    {
                        myWin += 7.132;
                        break;
                    }
                    if (prufMyFullHouseKD)
                    {
                        myWin += 7.131;
                        break;
                    }
                    if (prufMyFullHouseVD)
                    {
                        myWin += 7.130;
                        break;
                    }
                    if (prufMyFullHouse10D)
                    {
                        myWin += 7.129;
                        break;
                    }
                    if (prufMyFullHouse9D)
                    {
                        myWin += 7.128;
                        break;
                    }
                    if (prufMyFullHouse8D)
                    {
                        myWin += 7.127;
                        break;
                    }
                    if (prufMyFullHouse7D)
                    {
                        myWin += 7.126;
                        break;
                    }
                    if (prufMyFullHouse6D)
                    {
                        myWin += 7.125;
                        break;
                    }
                    if (prufMyFullHouse5D)
                    {
                        myWin += 7.124;
                        break;
                    }
                    if (prufMyFullHouse4D)
                    {
                        myWin += 7.123;
                        break;
                    }
                    if (prufMyFullHouse3D)
                    {
                        myWin += 7.122;
                        break;
                    }
                    if (prufMyFullHouse2D)
                    {
                        myWin += 7.121;
                        break;
                    }
                    if (prufMyFullHouseAV)
                    {
                        myWin += 7.120;
                        break;
                    }
                    if (prufMyFullHouseKV)
                    {
                        myWin += 7.119;
                        break;
                    }
                    if (prufMyFullHouseDV)
                    {
                        myWin += 7.118;
                        break;
                    }
                    if (prufMyFullHouse10V)
                    {
                        myWin += 7.117;
                        break;
                    }
                    if (prufMyFullHouse9V)
                    {
                        myWin += 7.116;
                        break;
                    }
                    if (prufMyFullHouse8V)
                    {
                        myWin += 7.115;
                        break;
                    }
                    if (prufMyFullHouse7V)
                    {
                        myWin += 7.114;
                        break;
                    }
                    if (prufMyFullHouse6V)
                    {
                        myWin += 7.113;
                        break;
                    }
                    if (prufMyFullHouse5V)
                    {
                        myWin += 7.112;
                        break;
                    }
                    if (prufMyFullHouse4V)
                    {
                        myWin += 7.111;
                        break;
                    }
                    if (prufMyFullHouse3V)
                    {
                        myWin += 7.110;
                        break;
                    }
                    if (prufMyFullHouse2V)
                    {
                        myWin += 7.109;
                        break;
                    }
                    if (prufMyFullHouseA10)
                    {
                        myWin += 7.108;
                        break;
                    }
                    if (prufMyFullHouseK10)
                    {
                        myWin += 7.107;
                        break;
                    }
                    if (prufMyFullHouseD10)
                    {
                        myWin += 7.106;
                        break;
                    }
                    if (prufMyFullHouseV10)
                    {
                        myWin += 7.105;
                        break;
                    }
                    if (prufMyFullHouse910)
                    {
                        myWin += 7.104;
                        break;
                    }
                    if (prufMyFullHouse810)
                    {
                        myWin += 7.103;
                        break;
                    }
                    if (prufMyFullHouse710)
                    {
                        myWin += 7.102;
                        break;
                    }
                    if (prufMyFullHouse610)
                    {
                        myWin += 7.101;
                        break;
                    }
                    if (prufMyFullHouse510)
                    {
                        myWin += 7.100;
                        break;
                    }
                    if (prufMyFullHouse410)
                    {
                        myWin += 7.099;
                        break;
                    }
                    if (prufMyFullHouse310)
                    {
                        myWin += 7.098;
                        break;
                    }
                    if (prufMyFullHouse210)
                    {
                        myWin += 7.097;
                        break;
                    }
                    if (prufMyFullHouseA9)
                    {
                        myWin += 7.096;
                        break;
                    }
                    if (prufMyFullHouseK9)
                    {
                        myWin += 7.095;
                        break;
                    }
                    if (prufMyFullHouseD9)
                    {
                        myWin += 7.094;
                        break;
                    }
                    if (prufMyFullHouseV9)
                    {
                        myWin += 7.093;
                        break;
                    }
                    if (prufMyFullHouse109)
                    {
                        myWin += 7.092;
                        break;
                    }
                    if (prufMyFullHouse89)
                    {
                        myWin += 7.091;
                        break;
                    }
                    if (prufMyFullHouse79)
                    {
                        myWin += 7.090;
                        break;
                    }
                    if (prufMyFullHouse69)
                    {
                        myWin += 7.089;
                        break;
                    }
                    if (prufMyFullHouse59)
                    {
                        myWin += 7.088;
                        break;
                    }
                    if (prufMyFullHouse49)
                    {
                        myWin += 7.087;
                        break;
                    }
                    if (prufMyFullHouse39)
                    {
                        myWin += 7.086;
                        break;
                    }
                    if (prufMyFullHouse29)
                    {
                        myWin += 7.085;
                        break;
                    }
                    if (prufMyFullHouseA8)
                    {
                        myWin += 7.084;
                        break;
                    }
                    if (prufMyFullHouseK8)
                    {
                        myWin += 7.083;
                        break;
                    }
                    if (prufMyFullHouseD8)
                    {
                        myWin += 7.082;
                        break;
                    }
                    if (prufMyFullHouseV8)
                    {
                        myWin += 7.081;
                        break;
                    }
                    if (prufMyFullHouse108)
                    {
                        myWin += 7.080;
                        break;
                    }
                    if (prufMyFullHouse98)
                    {
                        myWin += 7.079;
                        break;
                    }
                    if (prufMyFullHouse78)
                    {
                        myWin += 7.078;
                        break;
                    }
                    if (prufMyFullHouse68)
                    {
                        myWin += 7.077;
                        break;
                    }
                    if (prufMyFullHouse58)
                    {
                        myWin += 7.076;
                        break;
                    }
                    if (prufMyFullHouse48)
                    {
                        myWin += 7.075;
                        break;
                    }
                    if (prufMyFullHouse38)
                    {
                        myWin += 7.074;
                        break;
                    }
                    if (prufMyFullHouse28)
                    {
                        myWin += 7.073;
                        break;
                    }
                    if (prufMyFullHouseA7)
                    {
                        myWin += 7.072;
                        break;
                    }
                    if (prufMyFullHouseK7)
                    {
                        myWin += 7.071;
                        break;
                    }
                    if (prufMyFullHouseD7)
                    {
                        myWin += 7.070;
                        break;
                    }
                    if (prufMyFullHouseV7)
                    {
                        myWin += 7.069;
                        break;
                    }
                    if (prufMyFullHouse107)
                    {
                        myWin += 7.068;
                        break;
                    }
                    if (prufMyFullHouse97)
                    {
                        myWin += 7.067;
                        break;
                    }
                    if (prufMyFullHouse87)
                    {
                        myWin += 7.066;
                        break;
                    }
                    if (prufMyFullHouse67)
                    {
                        myWin += 7.065;
                        break;
                    }
                    if (prufMyFullHouse57)
                    {
                        myWin += 7.064;
                        break;
                    }
                    if (prufMyFullHouse47)
                    {
                        myWin += 7.063;
                        break;
                    }
                    if (prufMyFullHouse37)
                    {
                        myWin += 7.062;
                        break;
                    }
                    if (prufMyFullHouse27)
                    {
                        myWin += 7.061;
                        break;
                    }
                    if (prufMyFullHouseA6)
                    {
                        myWin += 7.060;
                        break;
                    }
                    if (prufMyFullHouseK6)
                    {
                        myWin += 7.059;
                        break;
                    }
                    if (prufMyFullHouseD6)
                    {
                        myWin += 7.058;
                        break;
                    }
                    if (prufMyFullHouseV6)
                    {
                        myWin += 7.057;
                        break;
                    }
                    if (prufMyFullHouse106)
                    {
                        myWin += 7.056;
                        break;
                    }
                    if (prufMyFullHouse96)
                    {
                        myWin += 7.055;
                        break;
                    }
                    if (prufMyFullHouse86)
                    {
                        myWin += 7.054;
                        break;
                    }
                    if (prufMyFullHouse76)
                    {
                        myWin += 7.053;
                        break;
                    }
                    if (prufMyFullHouse56)
                    {
                        myWin += 7.052;
                        break;
                    }
                    if (prufMyFullHouse46)
                    {
                        myWin += 7.051;
                        break;
                    }
                    if (prufMyFullHouse36)
                    {
                        myWin += 7.050;
                        break;
                    }
                    if (prufMyFullHouse26)
                    {
                        myWin += 7.049;
                        break;
                    }
                    if (prufMyFullHouseA5)
                    {
                        myWin += 7.048;
                        break;
                    }
                    if (prufMyFullHouseK5)
                    {
                        myWin += 7.047;
                        break;
                    }
                    if (prufMyFullHouseD5)
                    {
                        myWin += 7.046;
                        break;
                    }
                    if (prufMyFullHouseV5)
                    {
                        myWin += 7.045;
                        break;
                    }
                    if (prufMyFullHouse105)
                    {
                        myWin += 7.044;
                        break;
                    }
                    if (prufMyFullHouse95)
                    {
                        myWin += 7.043;
                        break;
                    }
                    if (prufMyFullHouse85)
                    {
                        myWin += 7.042;
                        break;
                    }
                    if (prufMyFullHouse75)
                    {
                        myWin += 7.041;
                        break;
                    }
                    if (prufMyFullHouse65)
                    {
                        myWin += 7.040;
                        break;
                    }
                    if (prufMyFullHouse45)
                    {
                        myWin += 7.039;
                        break;
                    }
                    if (prufMyFullHouse35)
                    {
                        myWin += 7.038;
                        break;
                    }
                    if (prufMyFullHouse25)
                    {
                        myWin += 7.037;
                        break;
                    }
                    if (prufMyFullHouseA4)
                    {
                        myWin += 7.036;
                        break;
                    }
                    if (prufMyFullHouseK4)
                    {
                        myWin += 7.035;
                        break;
                    }
                    if (prufMyFullHouseD4)
                    {
                        myWin += 7.034;
                        break;
                    }
                    if (prufMyFullHouseV4)
                    {
                        myWin += 7.033;
                        break;
                    }
                    if (prufMyFullHouse104)
                    {
                        myWin += 7.032;
                        break;
                    }
                    if (prufMyFullHouse94)
                    {
                        myWin += 7.031;
                        break;
                    }
                    if (prufMyFullHouse84)
                    {
                        myWin += 7.030;
                        break;
                    }
                    if (prufMyFullHouse74)
                    {
                        myWin += 7.029;
                        break;
                    }
                    if (prufMyFullHouse64)
                    {
                        myWin += 7.028;
                        break;
                    }
                    if (prufMyFullHouse54)
                    {
                        myWin += 7.027;
                        break;
                    }
                    if (prufMyFullHouse34)
                    {
                        myWin += 7.026;
                        break;
                    }
                    if (prufMyFullHouse24)
                    {
                        myWin += 7.025;
                        break;
                    }
                    if (prufMyFullHouseA3)
                    {
                        myWin += 7.024;
                        break;
                    }
                    if (prufMyFullHouseK3)
                    {
                        myWin += 7.023;
                        break;
                    }
                    if (prufMyFullHouseD3)
                    {
                        myWin += 7.022;
                        break;
                    }
                    if (prufMyFullHouseV3)
                    {
                        myWin += 7.021;
                        break;
                    }
                    if (prufMyFullHouse103)
                    {
                        myWin += 7.020;
                        break;
                    }
                    if (prufMyFullHouse93)
                    {
                        myWin += 7.019;
                        break;
                    }
                    if (prufMyFullHouse83)
                    {
                        myWin += 7.018;
                        break;
                    }
                    if (prufMyFullHouse73)
                    {
                        myWin += 7.017;
                        break;
                    }
                    if (prufMyFullHouse63)
                    {
                        myWin += 7.016;
                        break;
                    }
                    if (prufMyFullHouse53)
                    {
                        myWin += 7.015;
                        break;
                    }
                    if (prufMyFullHouse43)
                    {
                        myWin += 7.014;
                        break;
                    }
                    if (prufMyFullHouse23)
                    {
                        myWin += 7.013;
                        break;
                    }
                    if (prufMyFullHouseA2)
                    {
                        myWin += 7.012;
                        break;
                    }
                    if (prufMyFullHouseK2)
                    {
                        myWin += 7.011;
                        break;
                    }
                    if (prufMyFullHouseD2)
                    {
                        myWin += 7.010;
                        break;
                    }
                    if (prufMyFullHouseV2)
                    {
                        myWin += 7.009;
                        break;
                    }
                    if (prufMyFullHouse102)
                    {
                        myWin += 7.008;
                        break;
                    }
                    if (prufMyFullHouse92)
                    {
                        myWin += 7.007;
                        break;
                    }
                    if (prufMyFullHouse82)
                    {
                        myWin += 7.006;
                        break;
                    }
                    if (prufMyFullHouse72)
                    {
                        myWin += 7.005;
                        break;
                    }
                    if (prufMyFullHouse62)
                    {
                        myWin += 7.004;
                        break;
                    }
                    if (prufMyFullHouse52)
                    {
                        myWin += 7.003;
                        break;
                    }
                    if (prufMyFullHouse42)
                    {
                        myWin += 7.002;
                        break;
                    }
                    if (prufMyFullHouse32)
                    {
                        myWin += 7.001;
                        break;
                    }
                    if (prufMyFleshPika || prufMyFleshChirva || prufMyFleshBuba || prufMyFleshHresta)
                    {
                        myWin += 6.1;
                        break;
                    }
                    if (prufMyStrit10A)
                    {
                        myWin += 5.9;
                        break;
                    }
                    if (prufMyStrit9K)
                    {
                        myWin += 5.8;
                        break;
                    }
                    if (prufMyStrit8D)
                    {
                        myWin += 5.7;
                        break;
                    }
                    if (prufMyStrit7V)
                    {
                        myWin += 5.6;
                        break;
                    }
                    if (prufMyStrit610)
                    {
                        myWin += 5.5;
                        break;
                    }
                    if (prufMyStrit59)
                    {
                        myWin += 5.4;
                        break;
                    }
                    if (prufMyStrit48)
                    {
                        myWin += 5.3;
                        break;
                    }
                    if (prufMyStrit37)
                    {
                        myWin += 5.2;
                        break;
                    }
                    if (prufMyStrit26)
                    {
                        myWin += 5.1;
                        break;
                    }
                    if (prufMySetA)
                    {
                        myWin += 4.14;
                        break;
                    }
                    if (prufMySetK)
                    {
                        myWin += 4.13;
                        break;
                    }
                    if (prufMySetD)
                    {
                        myWin += 4.012;
                        break;
                    }
                    if (prufMySetV)
                    {
                        myWin += 4.11;
                        break;
                    }
                    if (prufMySet10)
                    {
                        myWin += 4.10;
                        break;
                    }
                    if (prufMySet9)
                    {
                        myWin += 4.09;
                        break;
                    }
                    if (prufMySet8)
                    {
                        myWin += 4.08;
                        break;
                    }
                    if (prufMySet7)
                    {
                        myWin += 4.07;
                        break;
                    }
                    if (prufMySet6)
                    {
                        myWin += 4.06;
                        break;
                    }
                    if (prufMySet5)
                    {
                        myWin += 4.05;
                        break;
                    }
                    if (prufMySet4)
                    {
                        myWin += 4.04;
                        break;
                    }
                    if (prufMySet3)
                    {
                        myWin += 4.03;
                        break;
                    }
                    if (prufMySet2)
                    {
                        myWin += 4.02;
                        break;
                    }
                    if (prufMyParaKA)
                    {
                        myWin += 3.79;
                        break;
                    }
                    if (prufMyParaDA)
                    {
                        myWin += 3.78;
                        break;
                    }
                    if (prufMyParaVA)
                    {
                        myWin += 3.77;
                        break;
                    }
                    if (prufMyPara10A)
                    {
                        myWin += 3.76;
                        break;
                    }
                    if (prufMyPara9A)
                    {
                        myWin += 3.75;
                        break;
                    }
                    if (prufMyPara8A)
                    {
                        myWin += 3.74;
                        break;
                    }
                    if (prufMyPara7A)
                    {
                        myWin += 3.73;
                        break;
                    }
                    if (prufMyPara6A)
                    {
                        myWin += 3.72;
                        break;
                    }
                    if (prufMyPara5A)
                    {
                        myWin += 3.71;
                        break;
                    }
                    if (prufMyPara4A)
                    {
                        myWin += 3.70;
                        break;
                    }
                    if (prufMyPara3A)
                    {
                        myWin += 3.69;
                        break;
                    }
                    if (prufMyPara2A)
                    {
                        myWin += 3.68;
                        break;
                    }
                    if (prufMyParaDK)
                    {
                        myWin += 3.67;
                        break;
                    }
                    if (prufMyParaVK)
                    {
                        myWin += 3.66;
                        break;
                    }
                    if (prufMyPara10K)
                    {
                        myWin += 3.65;
                        break;
                    }
                    if (prufMyPara9K)
                    {
                        myWin += 3.64;
                        break;
                    }
                    if (prufMyPara8K)
                    {
                        myWin += 3.63;
                        break;
                    }
                    if (prufMyPara7K)
                    {
                        myWin += 3.62;
                        break;
                    }
                    if (prufMyPara6K)
                    {
                        myWin += 3.61;
                        break;
                    }
                    if (prufMyPara5K)
                    {
                        myWin += 3.60;
                        break;
                    }
                    if (prufMyPara4K)
                    {
                        myWin += 3.59;
                        break;
                    }
                    if (prufMyPara3K)
                    {
                        myWin += 3.58;
                        break;
                    }
                    if (prufMyPara2K)
                    {
                        myWin += 3.57;
                        break;
                    }
                    if (prufMyParaVD)
                    {
                        myWin += 3.56;
                        break;
                    }
                    if (prufMyPara10D)
                    {
                        myWin += 3.55;
                        break;
                    }
                    if (prufMyPara9D)
                    {
                        myWin += 3.54;
                        break;
                    }
                    if (prufMyPara8D)
                    {
                        myWin += 3.53;
                        break;
                    }
                    if (prufMyPara7D)
                    {
                        myWin += 3.52;
                        break;
                    }
                    if (prufMyPara6D)
                    {
                        myWin += 3.51;
                        break;
                    }
                    if (prufMyPara5D)
                    {
                        myWin += 3.50;
                        break;
                    }
                    if (prufMyPara4D)
                    {
                        myWin += 3.49;
                        break;
                    }
                    if (prufMyPara3D)
                    {
                        myWin += 3.48;
                        break;
                    }
                    if (prufMyPara2D)
                    {
                        myWin += 3.47;
                        break;
                    }
                    if (prufMyPara10V)
                    {
                        myWin += 3.46;
                        break;
                    }
                    if (prufMyPara9V)
                    {
                        myWin += 3.45;
                        break;
                    }
                    if (prufMyPara8V)
                    {
                        myWin += 3.44;
                        break;
                    }
                    if (prufMyPara7V)
                    {
                        myWin += 3.43;
                        break;
                    }
                    if (prufMyPara6V)
                    {
                        myWin += 3.42;
                        break;
                    }
                    if (prufMyPara5V)
                    {
                        myWin += 3.41;
                        break;
                    }
                    if (prufMyPara4V)
                    {
                        myWin += 3.40;
                        break;
                    }
                    if (prufMyPara3V)
                    {
                        myWin += 3.39;
                        break;
                    }
                    if (prufMyPara2V)
                    {
                        myWin += 3.38;
                        break;
                    }
                    if (prufMyPara910)
                    {
                        myWin += 3.37;
                        break;
                    }
                    if (prufMyPara810)
                    {
                        myWin += 3.36;
                        break;
                    }
                    if (prufMyPara710)
                    {
                        myWin += 3.35;
                        break;
                    }
                    if (prufMyPara610)
                    {
                        myWin += 3.34;
                        break;
                    }
                    if (prufMyPara510)
                    {
                        myWin += 3.33;
                        break;
                    }
                    if (prufMyPara410)
                    {
                        myWin += 3.32;
                        break;
                    }
                    if (prufMyPara310)
                    {
                        myWin += 3.31;
                        break;
                    }
                    if (prufMyPara210)
                    {
                        myWin += 3.30;
                        break;
                    }
                    if (prufMyPara89)
                    {
                        myWin += 3.29;
                        break;
                    }
                    if (prufMyPara79)
                    {
                        myWin += 3.28;
                        break;
                    }
                    if (prufMyPara69)
                    {
                        myWin += 3.27;
                        break;
                    }
                    if (prufMyPara59)
                    {
                        myWin += 3.26;
                        break;
                    }
                    if (prufMyPara49)
                    {
                        myWin += 3.25;
                        break;
                    }
                    if (prufMyPara39)
                    {
                        myWin += 3.24;
                        break;
                    }
                    if (prufMyPara29)
                    {
                        myWin += 3.23;
                        break;
                    }
                    if (prufMyPara78)
                    {
                        myWin += 3.22;
                        break;
                    }
                    if (prufMyPara68)
                    {
                        myWin += 3.21;
                        break;
                    }
                    if (prufMyPara58)
                    {
                        myWin += 3.20;
                        break;
                    }
                    if (prufMyPara48)
                    {
                        myWin += 3.19;
                        break;
                    }
                    if (prufMyPara38)
                    {
                        myWin += 3.18;
                        break;
                    }
                    if (prufMyPara28)
                    {
                        myWin += 3.17;
                        break;
                    }
                    if (prufMyPara67)
                    {
                        myWin += 3.16;
                        break;
                    }
                    if (prufMyPara57)
                    {
                        myWin += 3.15;
                        break;
                    }
                    if (prufMyPara47)
                    {
                        myWin += 3.14;
                        break;
                    }
                    if (prufMyPara37)
                    {
                        myWin += 3.13;
                        break;
                    }
                    if (prufMyPara27)
                    {
                        myWin += 3.12;
                        break;
                    }
                    if (prufMyPara56)
                    {
                        myWin += 3.11;
                        break;
                    }
                    if (prufMyPara46)
                    {
                        myWin += 3.10;
                        break;
                    }
                    if (prufMyPara36)
                    {
                        myWin += 3.09;
                        break;
                    }
                    if (prufMyPara26)
                    {
                        myWin += 3.08;
                        break;
                    }
                    if (prufMyPara45)
                    {
                        myWin += 3.07;
                        break;
                    }
                    if (prufMyPara35)
                    {
                        myWin += 3.06;
                        break;
                    }
                    if (prufMyPara25)
                    {
                        myWin += 3.05;
                        break;
                    }
                    if (prufMyPara34)
                    {
                        myWin += 3.04;
                        break;
                    }
                    if (prufMyPara24)
                    {
                        myWin += 3.03;
                        break;
                    }
                    if (prufMyPara23)
                    {
                        myWin += 3.02;
                        break;
                    }
                    if (prufMyParaA)
                    {
                        myWin += 2.14;
                        break;
                    }
                    if (prufMyParaK)
                    {
                        myWin += 2.13;
                        break;
                    }
                    if (prufMyParaD)
                    {
                        myWin += 2.12;
                        break;
                    }
                    if (prufMyParaV)
                    {
                        myWin += 2.11;
                        break;
                    }
                    if (prufMyPara10)
                    {
                        myWin += 2.10;
                        break;
                    }
                    if (prufMyPara9)
                    {
                        myWin += 2.09;
                        break;
                    }
                    if (prufMyPara8)
                    {
                        myWin += 2.08;
                        break;
                    }
                    if (prufMyPara7)
                    {
                        myWin += 2.07;
                        break;
                    }
                    if (prufMyPara6)
                    {
                        myWin += 2.06;
                        break;
                    }
                    if (prufMyPara5)
                    {
                        myWin += 2.05;
                        break;
                    }
                    if (prufMyPara4)
                    {
                        myWin += 2.04;
                        break;
                    }
                    if (prufMyPara3)
                    {
                        myWin += 2.03;
                        break;
                    }
                    if (prufMyPara2)
                    {
                        myWin += 2.02;
                        break;
                    }
                }
                bool prufDilerPara2 = dilerNumbers.Count(x => x == "2") == 2;
                bool prufDilerPara3 = dilerNumbers.Count(x => x == "3") == 2;
                bool prufDilerPara4 = dilerNumbers.Count(x => x == "4") == 2;
                bool prufDilerPara5 = dilerNumbers.Count(x => x == "5") == 2;
                bool prufDilerPara6 = dilerNumbers.Count(x => x == "6") == 2;
                bool prufDilerPara7 = dilerNumbers.Count(x => x == "7") == 2;
                bool prufDilerPara8 = dilerNumbers.Count(x => x == "8") == 2;
                bool prufDilerPara9 = dilerNumbers.Count(x => x == "9") == 2;
                bool prufDilerPara10 = dilerNumbers.Count(x => x == "10") == 2;
                bool prufDilerParaV = dilerNumbers.Count(x => x == "V") == 2;
                bool prufDilerParaD = dilerNumbers.Count(x => x == "D") == 2;
                bool prufDilerParaK = dilerNumbers.Count(x => x == "K") == 2;
                bool prufDilerParaA = dilerNumbers.Count(x => x == "A") == 2;
                bool prufDilerPara23 = prufDilerPara2 && prufDilerPara3;
                bool prufDilerPara24 = prufDilerPara2 && prufDilerPara4;
                bool prufDilerPara25 = prufDilerPara2 && prufDilerPara5;
                bool prufDilerPara26 = prufDilerPara2 && prufDilerPara6;
                bool prufDilerPara27 = prufDilerPara2 && prufDilerPara7;
                bool prufDilerPara28 = prufDilerPara2 && prufDilerPara8;
                bool prufDilerPara29 = prufDilerPara2 && prufDilerPara9;
                bool prufDilerPara210 = prufDilerPara2 && prufDilerPara10;
                bool prufDilerPara2V = prufDilerPara2 && prufDilerParaV;
                bool prufDilerPara2D = prufDilerPara2 && prufDilerParaD;
                bool prufDilerPara2K = prufDilerPara2 && prufDilerParaK;
                bool prufDilerPara2A = prufDilerPara2 && prufDilerParaA;
                bool prufDilerPara34 = prufDilerPara3 && prufDilerPara4;
                bool prufDilerPara35 = prufDilerPara3 && prufDilerPara5;
                bool prufDilerPara36 = prufDilerPara3 && prufDilerPara6;
                bool prufDilerPara37 = prufDilerPara3 && prufDilerPara7;
                bool prufDilerPara38 = prufDilerPara3 && prufDilerPara8;
                bool prufDilerPara39 = prufDilerPara3 && prufDilerPara9;
                bool prufDilerPara310 = prufDilerPara3 && prufDilerPara10;
                bool prufDilerPara3V = prufDilerPara3 && prufDilerParaV;
                bool prufDilerPara3D = prufDilerPara3 && prufDilerParaD;
                bool prufDilerPara3K = prufDilerPara3 && prufDilerParaK;
                bool prufDilerPara3A = prufDilerPara3 && prufDilerParaA;
                bool prufDilerPara45 = prufDilerPara4 && prufDilerPara5;
                bool prufDilerPara46 = prufDilerPara4 && prufDilerPara6;
                bool prufDilerPara47 = prufDilerPara4 && prufDilerPara7;
                bool prufDilerPara48 = prufDilerPara4 && prufDilerPara8;
                bool prufDilerPara49 = prufDilerPara4 && prufDilerPara9;
                bool prufDilerPara410 = prufDilerPara4 && prufDilerPara10;
                bool prufDilerPara4V = prufDilerPara4 && prufDilerParaV;
                bool prufDilerPara4D = prufDilerPara4 && prufDilerParaD;
                bool prufDilerPara4K = prufDilerPara4 && prufDilerParaK;
                bool prufDilerPara4A = prufDilerPara4 && prufDilerParaA;
                bool prufDilerPara56 = prufDilerPara5 && prufDilerPara6;
                bool prufDilerPara57 = prufDilerPara5 && prufDilerPara7;
                bool prufDilerPara58 = prufDilerPara5 && prufDilerPara8;
                bool prufDilerPara59 = prufDilerPara5 && prufDilerPara9;
                bool prufDilerPara510 = prufDilerPara5 && prufDilerPara10;
                bool prufDilerPara5V = prufDilerPara5 && prufDilerParaV;
                bool prufDilerPara5D = prufDilerPara5 && prufDilerParaD;
                bool prufDilerPara5K = prufDilerPara5 && prufDilerParaK;
                bool prufDilerPara5A = prufDilerPara5 && prufDilerParaA;
                bool prufDilerPara67 = prufDilerPara6 && prufDilerPara7;
                bool prufDilerPara68 = prufDilerPara6 && prufDilerPara8;
                bool prufDilerPara69 = prufDilerPara6 && prufDilerPara9;
                bool prufDilerPara610 = prufDilerPara6 && prufDilerPara10;
                bool prufDilerPara6V = prufDilerPara6 && prufDilerParaV;
                bool prufDilerPara6D = prufDilerPara6 && prufDilerParaD;
                bool prufDilerPara6K = prufDilerPara6 && prufDilerParaK;
                bool prufDilerPara6A = prufDilerPara6 && prufDilerParaA;
                bool prufDilerPara78 = prufDilerPara7 && prufDilerPara8;
                bool prufDilerPara79 = prufDilerPara7 && prufDilerPara9;
                bool prufDilerPara710 = prufDilerPara7 && prufDilerPara10;
                bool prufDilerPara7V = prufDilerPara7 && prufDilerParaV;
                bool prufDilerPara7D = prufDilerPara7 && prufDilerParaD;
                bool prufDilerPara7K = prufDilerPara7 && prufDilerParaK;
                bool prufDilerPara7A = prufDilerPara7 && prufDilerParaA;
                bool prufDilerPara89 = prufDilerPara8 && prufDilerPara9;
                bool prufDilerPara810 = prufDilerPara8 && prufDilerPara10;
                bool prufDilerPara8V = prufDilerPara8 && prufDilerParaV;
                bool prufDilerPara8D = prufDilerPara8 && prufDilerParaD;
                bool prufDilerPara8K = prufDilerPara8 && prufDilerParaK;
                bool prufDilerPara8A = prufDilerPara8 && prufDilerParaA;
                bool prufDilerPara910 = prufDilerPara9 && prufDilerPara10;
                bool prufDilerPara9V = prufDilerPara9 && prufDilerParaV;
                bool prufDilerPara9D = prufDilerPara9 && prufDilerParaD;
                bool prufDilerPara9K = prufDilerPara9 && prufDilerParaK;
                bool prufDilerPara9A = prufDilerPara9 && prufDilerParaA;
                bool prufDilerPara10V = prufDilerPara10 && prufDilerParaV;
                bool prufDilerPara10D = prufDilerPara10 && prufDilerParaD;
                bool prufDilerPara10K = prufDilerPara10 && prufDilerParaK;
                bool prufDilerPara10A = prufDilerPara10 && prufDilerParaA;
                bool prufDilerParaVD = prufDilerParaV && prufDilerParaD;
                bool prufDilerParaVK = prufDilerParaV && prufDilerParaK;
                bool prufDilerParaVA = prufDilerParaV && prufDilerParaA;
                bool prufDilerParaDK = prufDilerParaD && prufDilerParaK;
                bool prufDilerParaDA = prufDilerParaD && prufDilerParaA;
                bool prufDilerParaKA = prufDilerParaK && prufDilerParaA;
                bool prufDilerSet2 = dilerNumbers.Count(x => x == "2") == 3;
                bool prufDilerSet3 = dilerNumbers.Count(x => x == "3") == 3;
                bool prufDilerSet4 = dilerNumbers.Count(x => x == "4") == 3;
                bool prufDilerSet5 = dilerNumbers.Count(x => x == "5") == 3;
                bool prufDilerSet6 = dilerNumbers.Count(x => x == "6") == 3;
                bool prufDilerSet7 = dilerNumbers.Count(x => x == "7") == 3;
                bool prufDilerSet8 = dilerNumbers.Count(x => x == "8") == 3;
                bool prufDilerSet9 = dilerNumbers.Count(x => x == "9") == 3;
                bool prufDilerSet10 = dilerNumbers.Count(x => x == "10") == 3;
                bool prufDilerSetV = dilerNumbers.Count(x => x == "V") == 3;
                bool prufDilerSetD = dilerNumbers.Count(x => x == "D") == 3;
                bool prufDilerSetK = dilerNumbers.Count(x => x == "K") == 3;
                bool prufDilerSetA = dilerNumbers.Count(x => x == "A") == 3;
                bool prufDilerStrit26 = strit26.All(elements => dilerNumbers.Contains(elements));
                bool prufDilerStrit37 = strit37.All(elements => dilerNumbers.Contains(elements));
                bool prufDilerStrit48 = strit48.All(elements => dilerNumbers.Contains(elements));
                bool prufDilerStrit59 = strit59.All(elements => dilerNumbers.Contains(elements));
                bool prufDilerStrit610 = strit610.All(elements => dilerNumbers.Contains(elements));
                bool prufDilerStrit7V = strit7V.All(elements => dilerNumbers.Contains(elements));
                bool prufDilerStrit8D = strit8D.All(elements => dilerNumbers.Contains(elements));
                bool prufDilerStrit9K = strit9K.All(elements => dilerNumbers.Contains(elements));
                bool prufDilerStrit10A = strit10A.All(elements => dilerNumbers.Contains(elements));
                bool prufDilerFleshPika = dilerMasts.Count(x => x == "♠") >= 5;
                bool prufDilerFleshChirva = dilerMasts.Count(x => x == "♥") >= 5;
                bool prufDilerFleshBuba = dilerMasts.Count(x => x == "♦") >= 5;
                bool prufDilerFleshHresta = dilerMasts.Count(x => x == "♣") >= 5;
                bool prufDilerFullHouse23 = prufDilerPara2 && prufDilerSet3;
                bool prufDilerFullHouse24 = prufDilerPara2 && prufDilerSet4;
                bool prufDilerFullHouse25 = prufDilerPara2 && prufDilerSet5;
                bool prufDilerFullHouse26 = prufDilerPara2 && prufDilerSet6;
                bool prufDilerFullHouse27 = prufDilerPara2 && prufDilerSet7;
                bool prufDilerFullHouse28 = prufDilerPara2 && prufDilerSet8;
                bool prufDilerFullHouse29 = prufDilerPara2 && prufDilerSet9;
                bool prufDilerFullHouse210 = prufDilerPara2 && prufDilerSet10;
                bool prufDilerFullHouse2V = prufDilerPara2 && prufDilerSetV;
                bool prufDilerFullHouse2D = prufDilerPara2 && prufDilerSetD;
                bool prufDilerFullHouse2K = prufDilerPara2 && prufDilerSetK;
                bool prufDilerFullHouse2A = prufDilerPara2 && prufDilerSetA;
                bool prufDilerFullHouse32 = prufDilerPara3 && prufDilerSet2;
                bool prufDilerFullHouse34 = prufDilerPara3 && prufDilerSet4;
                bool prufDilerFullHouse35 = prufDilerPara3 && prufDilerSet5;
                bool prufDilerFullHouse36 = prufDilerPara3 && prufDilerSet6;
                bool prufDilerFullHouse37 = prufDilerPara3 && prufDilerSet7;
                bool prufDilerFullHouse38 = prufDilerPara3 && prufDilerSet8;
                bool prufDilerFullHouse39 = prufDilerPara3 && prufDilerSet9;
                bool prufDilerFullHouse310 = prufDilerPara3 && prufDilerSet10;
                bool prufDilerFullHouse3V = prufDilerPara3 && prufDilerSetV;
                bool prufDilerFullHouse3D = prufDilerPara3 && prufDilerSetD;
                bool prufDilerFullHouse3K = prufDilerPara3 && prufDilerSetK;
                bool prufDilerFullHouse3A = prufDilerPara3 && prufDilerSetA;
                bool prufDilerFullHouse42 = prufDilerPara4 && prufDilerSet2;
                bool prufDilerFullHouse43 = prufDilerPara4 && prufDilerSet3;
                bool prufDilerFullHouse45 = prufDilerPara4 && prufDilerSet5;
                bool prufDilerFullHouse46 = prufDilerPara4 && prufDilerSet6;
                bool prufDilerFullHouse47 = prufDilerPara4 && prufDilerSet7;
                bool prufDilerFullHouse48 = prufDilerPara4 && prufDilerSet8;
                bool prufDilerFullHouse49 = prufDilerPara4 && prufDilerSet9;
                bool prufDilerFullHouse410 = prufDilerPara4 && prufDilerSet10;
                bool prufDilerFullHouse4V = prufDilerPara4 && prufDilerSetV;
                bool prufDilerFullHouse4D = prufDilerPara4 && prufDilerSetD;
                bool prufDilerFullHouse4K = prufDilerPara4 && prufDilerSetK;
                bool prufDilerFullHouse4A = prufDilerPara4 && prufDilerSetA;
                bool prufDilerFullHouse52 = prufDilerPara5 && prufDilerSet2;
                bool prufDilerFullHouse53 = prufDilerPara5 && prufDilerSet3;
                bool prufDilerFullHouse54 = prufDilerPara5 && prufDilerSet4;
                bool prufDilerFullHouse56 = prufDilerPara5 && prufDilerSet6;
                bool prufDilerFullHouse57 = prufDilerPara5 && prufDilerSet7;
                bool prufDilerFullHouse58 = prufDilerPara5 && prufDilerSet8;
                bool prufDilerFullHouse59 = prufDilerPara5 && prufDilerSet9;
                bool prufDilerFullHouse510 = prufDilerPara5 && prufDilerSet10;
                bool prufDilerFullHouse5V = prufDilerPara5 && prufDilerSetV;
                bool prufDilerFullHouse5D = prufDilerPara5 && prufDilerSetD;
                bool prufDilerFullHouse5K = prufDilerPara5 && prufDilerSetK;
                bool prufDilerFullHouse5A = prufDilerPara5 && prufDilerSetA;
                bool prufDilerFullHouse62 = prufDilerPara6 && prufDilerSet2;
                bool prufDilerFullHouse63 = prufDilerPara6 && prufDilerSet3;
                bool prufDilerFullHouse64 = prufDilerPara6 && prufDilerSet4;
                bool prufDilerFullHouse65 = prufDilerPara6 && prufDilerSet5;
                bool prufDilerFullHouse67 = prufDilerPara6 && prufDilerSet7;
                bool prufDilerFullHouse68 = prufDilerPara6 && prufDilerSet8;
                bool prufDilerFullHouse69 = prufDilerPara6 && prufDilerSet9;
                bool prufDilerFullHouse610 = prufDilerPara6 && prufDilerSet10;
                bool prufDilerFullHouse6V = prufDilerPara6 && prufDilerSetV;
                bool prufDilerFullHouse6D = prufDilerPara6 && prufDilerSetD;
                bool prufDilerFullHouse6K = prufDilerPara6 && prufDilerSetK;
                bool prufDilerFullHouse6A = prufDilerPara6 && prufDilerSetA;
                bool prufDilerFullHouse72 = prufDilerPara7 && prufDilerSet2;
                bool prufDilerFullHouse73 = prufDilerPara7 && prufDilerSet3;
                bool prufDilerFullHouse74 = prufDilerPara7 && prufDilerSet4;
                bool prufDilerFullHouse75 = prufDilerPara7 && prufDilerSet5;
                bool prufDilerFullHouse76 = prufDilerPara7 && prufDilerSet6;
                bool prufDilerFullHouse78 = prufDilerPara7 && prufDilerSet8;
                bool prufDilerFullHouse79 = prufDilerPara7 && prufDilerSet9;
                bool prufDilerFullHouse710 = prufDilerPara7 && prufDilerSet10;
                bool prufDilerFullHouse7V = prufDilerPara7 && prufDilerSetV;
                bool prufDilerFullHouse7D = prufDilerPara7 && prufDilerSetD;
                bool prufDilerFullHouse7K = prufDilerPara7 && prufDilerSetK;
                bool prufDilerFullHouse7A = prufDilerPara7 && prufDilerSetA;
                bool prufDilerFullHouse82 = prufDilerPara8 && prufDilerSet2;
                bool prufDilerFullHouse83 = prufDilerPara8 && prufDilerSet3;
                bool prufDilerFullHouse84 = prufDilerPara8 && prufDilerSet4;
                bool prufDilerFullHouse85 = prufDilerPara8 && prufDilerSet5;
                bool prufDilerFullHouse86 = prufDilerPara8 && prufDilerSet6;
                bool prufDilerFullHouse87 = prufDilerPara8 && prufDilerSet7;
                bool prufDilerFullHouse89 = prufDilerPara8 && prufDilerSet9;
                bool prufDilerFullHouse810 = prufDilerPara8 && prufDilerSet10;
                bool prufDilerFullHouse8V = prufDilerPara8 && prufDilerSetV;
                bool prufDilerFullHouse8D = prufDilerPara8 && prufDilerSetD;
                bool prufDilerFullHouse8K = prufDilerPara8 && prufDilerSetK;
                bool prufDilerFullHouse8A = prufDilerPara8 && prufDilerSetA;
                bool prufDilerFullHouse92 = prufDilerPara9 && prufDilerSet2;
                bool prufDilerFullHouse93 = prufDilerPara9 && prufDilerSet3;
                bool prufDilerFullHouse94 = prufDilerPara9 && prufDilerSet4;
                bool prufDilerFullHouse95 = prufDilerPara9 && prufDilerSet5;
                bool prufDilerFullHouse96 = prufDilerPara9 && prufDilerSet6;
                bool prufDilerFullHouse97 = prufDilerPara9 && prufDilerSet7;
                bool prufDilerFullHouse98 = prufDilerPara9 && prufDilerSet8;
                bool prufDilerFullHouse910 = prufDilerPara9 && prufDilerSet10;
                bool prufDilerFullHouse9V = prufDilerPara9 && prufDilerSetV;
                bool prufDilerFullHouse9D = prufDilerPara9 && prufDilerSetD;
                bool prufDilerFullHouse9K = prufDilerPara9 && prufDilerSetK;
                bool prufDilerFullHouse9A = prufDilerPara9 && prufDilerSetA;
                bool prufDilerFullHouse102 = prufDilerPara10 && prufDilerSet2;
                bool prufDilerFullHouse103 = prufDilerPara10 && prufDilerSet3;
                bool prufDilerFullHouse104 = prufDilerPara10 && prufDilerSet4;
                bool prufDilerFullHouse105 = prufDilerPara10 && prufDilerSet5;
                bool prufDilerFullHouse106 = prufDilerPara10 && prufDilerSet6;
                bool prufDilerFullHouse107 = prufDilerPara10 && prufDilerSet7;
                bool prufDilerFullHouse108 = prufDilerPara10 && prufDilerSet8;
                bool prufDilerFullHouse109 = prufDilerPara10 && prufDilerSet9;
                bool prufDilerFullHouse10V = prufDilerPara10 && prufDilerSetV;
                bool prufDilerFullHouse10D = prufDilerPara10 && prufDilerSetD;
                bool prufDilerFullHouse10K = prufDilerPara10 && prufDilerSetK;
                bool prufDilerFullHouse10A = prufDilerPara10 && prufDilerSetA;
                bool prufDilerFullHouseV2 = prufDilerParaV && prufDilerSet2;
                bool prufDilerFullHouseV3 = prufDilerParaV && prufDilerSet3;
                bool prufDilerFullHouseV4 = prufDilerParaV && prufDilerSet4;
                bool prufDilerFullHouseV5 = prufDilerParaV && prufDilerSet5;
                bool prufDilerFullHouseV6 = prufDilerParaV && prufDilerSet6;
                bool prufDilerFullHouseV7 = prufDilerParaV && prufDilerSet7;
                bool prufDilerFullHouseV8 = prufDilerParaV && prufDilerSet8;
                bool prufDilerFullHouseV9 = prufDilerParaV && prufDilerSet9;
                bool prufDilerFullHouseV10 = prufDilerParaV && prufDilerSet10;
                bool prufDilerFullHouseVD = prufDilerParaV && prufDilerSetD;
                bool prufDilerFullHouseVK = prufDilerParaV && prufDilerSetK;
                bool prufDilerFullHouseVA = prufDilerParaV && prufDilerSetA;
                bool prufDilerFullHouseD2 = prufDilerParaD && prufDilerSet2;
                bool prufDilerFullHouseD3 = prufDilerParaD && prufDilerSet3;
                bool prufDilerFullHouseD4 = prufDilerParaD && prufDilerSet4;
                bool prufDilerFullHouseD5 = prufDilerParaD && prufDilerSet5;
                bool prufDilerFullHouseD6 = prufDilerParaD && prufDilerSet6;
                bool prufDilerFullHouseD7 = prufDilerParaD && prufDilerSet7;
                bool prufDilerFullHouseD8 = prufDilerParaD && prufDilerSet8;
                bool prufDilerFullHouseD9 = prufDilerParaD && prufDilerSet9;
                bool prufDilerFullHouseD10 = prufDilerParaD && prufDilerSet10;
                bool prufDilerFullHouseDV = prufDilerParaD && prufDilerSetV;
                bool prufDilerFullHouseDK = prufDilerParaD && prufDilerSetK;
                bool prufDilerFullHouseDA = prufDilerParaD && prufDilerSetA;
                bool prufDilerFullHouseK2 = prufDilerParaK && prufDilerSet2;
                bool prufDilerFullHouseK3 = prufDilerParaK && prufDilerSet3;
                bool prufDilerFullHouseK4 = prufDilerParaK && prufDilerSet4;
                bool prufDilerFullHouseK5 = prufDilerParaK && prufDilerSet5;
                bool prufDilerFullHouseK6 = prufDilerParaK && prufDilerSet6;
                bool prufDilerFullHouseK7 = prufDilerParaK && prufDilerSet7;
                bool prufDilerFullHouseK8 = prufDilerParaK && prufDilerSet8;
                bool prufDilerFullHouseK9 = prufDilerParaK && prufDilerSet9;
                bool prufDilerFullHouseK10 = prufDilerParaK && prufDilerSet10;
                bool prufDilerFullHouseKV = prufDilerParaK && prufDilerSetV;
                bool prufDilerFullHouseKD = prufDilerParaK && prufDilerSetD;
                bool prufDilerFullHouseKA = prufDilerParaK && prufDilerSetA;
                bool prufDilerFullHouseA2 = prufDilerParaA && prufDilerSet2;
                bool prufDilerFullHouseA3 = prufDilerParaA && prufDilerSet3;
                bool prufDilerFullHouseA4 = prufDilerParaA && prufDilerSet4;
                bool prufDilerFullHouseA5 = prufDilerParaA && prufDilerSet5;
                bool prufDilerFullHouseA6 = prufDilerParaA && prufDilerSet6;
                bool prufDilerFullHouseA7 = prufDilerParaA && prufDilerSet7;
                bool prufDilerFullHouseA8 = prufDilerParaA && prufDilerSet8;
                bool prufDilerFullHouseA9 = prufDilerParaA && prufDilerSet9;
                bool prufDilerFullHouseA10 = prufDilerParaA && prufDilerSet10;
                bool prufDilerFullHouseAV = prufDilerParaA && prufDilerSetV;
                bool prufDilerFullHouseAD = prufDilerParaA && prufDilerSetD;
                bool prufDilerFullHouseAK = prufDilerParaA && prufDilerSetK;
                bool prufDilerKare2 = dilerNumbers.Count(x => x == "2") == 4;
                bool prufDilerKare3 = dilerNumbers.Count(x => x == "3") == 4;
                bool prufDilerKare4 = dilerNumbers.Count(x => x == "4") == 4;
                bool prufDilerKare5 = dilerNumbers.Count(x => x == "5") == 4;
                bool prufDilerKare6 = dilerNumbers.Count(x => x == "6") == 4;
                bool prufDilerKare7 = dilerNumbers.Count(x => x == "7") == 4;
                bool prufDilerKare8 = dilerNumbers.Count(x => x == "8") == 4;
                bool prufDilerKare9 = dilerNumbers.Count(x => x == "9") == 4;
                bool prufDilerKare10 = dilerNumbers.Count(x => x == "10") == 4;
                bool prufDilerKareV = dilerNumbers.Count(x => x == "V") == 4;
                bool prufDilerKareD = dilerNumbers.Count(x => x == "D") == 4;
                bool prufDilerKareK = dilerNumbers.Count(x => x == "K") == 4;
                bool prufDilerKareA = dilerNumbers.Count(x => x == "A") == 4;
                bool prufDilerStrit26Pika = strit26Pika.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit26Chirva = strit26Chirva.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit26Buba = strit26Buba.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit26Hresta = strit26Hresta.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit37Pika = strit37Pika.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit37Chirva = strit37Chirva.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit37Buba = strit37Buba.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit37Hresta = strit37Hresta.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit48Pika = strit48Pika.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit48Chirva = strit48Chirva.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit48Buba = strit48Buba.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit48Hresta = strit48Hresta.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit59Pika = strit59Pika.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit59Chirva = strit59Chirva.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit59Buba = strit59Buba.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit59Hresta = strit59Hresta.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit610Pika = strit610Pika.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit610Chirva = strit610Chirva.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit610Buba = strit610Buba.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit610Hresta = strit610Hresta.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit7VPika = strit7VPika.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit7VChirva = strit7VChirva.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit7VBuba = strit7VBuba.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit7VHresta = strit7VHresta.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit8DPika = strit8DPika.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit8DChirva = strit8DChirva.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit8DBuba = strit8DBuba.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit8DHresta = strit8DHresta.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit9KPika = strit9KPika.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit9KChirva = strit9KChirva.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit9KBuba = strit9KBuba.All(elements => dilerKarts.Contains(elements));
                bool prufDilerStrit9KHresta = strit9KHresta.All(elements => dilerKarts.Contains(elements));
                bool prufDilerFleshRoialPika = fleshRoialPika.All(elements => dilerKarts.Contains(elements));
                bool prufDilerFleshRoialChirva = fleshRoialChirva.All(elements => dilerKarts.Contains(elements));
                bool prufDilerFleshRoialBuba = fleshRoialBuba.All(elements => dilerKarts.Contains(elements));
                bool prufDilerFleshRoialHresta = fleshRoialHresta.All(elements => dilerKarts.Contains(elements));
                for (int a = 0; a < 1; a++)
                {
                    if (prufDilerFleshRoialPika || prufDilerFleshRoialChirva || prufDilerFleshRoialBuba || prufDilerFleshRoialHresta)
                    {
                        dilerWin += 10.1;
                        break;
                    }
                    if (prufDilerStrit9KPika || prufDilerStrit9KChirva || prufDilerStrit9KBuba || prufDilerStrit9KHresta)
                    {
                        dilerWin += 9.8;
                        break;
                    }
                    if (prufDilerStrit8DPika || prufDilerStrit8DChirva || prufDilerStrit8DBuba || prufDilerStrit8DHresta)
                    {
                        dilerWin += 9.7;
                        break;
                    }
                    if (prufDilerStrit7VPika || prufDilerStrit7VChirva || prufDilerStrit7VBuba || prufDilerStrit7VHresta)
                    {
                        dilerWin += 9.6;
                        break;
                    }
                    if (prufDilerStrit610Pika || prufDilerStrit610Chirva || prufDilerStrit610Buba || prufDilerStrit610Hresta)
                    {
                        dilerWin += 9.5;
                        break;
                    }
                    if (prufDilerStrit59Pika || prufDilerStrit59Chirva || prufDilerStrit59Buba || prufDilerStrit59Hresta)
                    {
                        dilerWin += 9.4;
                        break;
                    }
                    if (prufDilerStrit48Pika || prufDilerStrit48Chirva || prufDilerStrit48Buba || prufDilerStrit48Hresta)
                    {
                        dilerWin += 9.3;
                        break;
                    }
                    if (prufDilerStrit37Pika || prufDilerStrit37Chirva || prufDilerStrit37Buba || prufDilerStrit37Hresta)
                    {
                        dilerWin += 9.2;
                        break;
                    }
                    if (prufDilerStrit26Pika || prufDilerStrit26Chirva || prufDilerStrit26Buba || prufDilerStrit26Hresta)
                    {
                        dilerWin += 9.1;
                        break;
                    }
                    if (prufDilerKareA)
                    {
                        dilerWin += 8.14;
                        break;
                    }
                    if (prufDilerKareK)
                    {
                        dilerWin += 8.13;
                        break;
                    }
                    if (prufDilerKareD)
                    {
                        dilerWin += 8.12;
                        break;
                    }
                    if (prufDilerKareV)
                    {
                        dilerWin += 8.11;
                        break;
                    }
                    if (prufDilerKare10)
                    {
                        dilerWin += 8.10;
                        break;
                    }
                    if (prufDilerKare9)
                    {
                        dilerWin += 8.09;
                        break;
                    }
                    if (prufDilerKare8)
                    {
                        dilerWin += 8.08;
                        break;
                    }
                    if (prufDilerKare7)
                    {
                        dilerWin += 8.07;
                        break;
                    }
                    if (prufDilerKare6)
                    {
                        dilerWin += 8.06;
                        break;
                    }
                    if (prufDilerKare5)
                    {
                        dilerWin += 8.05;
                        break;
                    }
                    if (prufDilerKare4)
                    {
                        dilerWin += 8.04;
                        break;
                    }
                    if (prufDilerKare3)
                    {
                        dilerWin += 8.03;
                        break;
                    }
                    if (prufDilerKare2)
                    {
                        dilerWin += 8.02;
                        break;
                    }
                    if (prufDilerFullHouseKA)
                    {
                        dilerWin += 7.156;
                        break;
                    }
                    if (prufDilerFullHouseDA)
                    {
                        dilerWin += 7.155;
                        break;
                    }
                    if (prufDilerFullHouseVA)
                    {
                        dilerWin += 7.154;
                        break;
                    }
                    if (prufDilerFullHouse10A)
                    {
                        dilerWin += 7.153;
                        break;
                    }
                    if (prufDilerFullHouse9A)
                    {
                        dilerWin += 7.152;
                        break;
                    }
                    if (prufDilerFullHouse8A)
                    {
                        dilerWin += 7.151;
                        break;
                    }
                    if (prufDilerFullHouse7A)
                    {
                        dilerWin += 7.150;
                        break;
                    }
                    if (prufDilerFullHouse6A)
                    {
                        dilerWin += 7.149;
                        break;
                    }
                    if (prufDilerFullHouse5A)
                    {
                        dilerWin += 7.148;
                        break;
                    }
                    if (prufDilerFullHouse4A)
                    {
                        dilerWin += 7.147;
                        break;
                    }
                    if (prufDilerFullHouse3A)
                    {
                        dilerWin += 7.146;
                        break;
                    }
                    if (prufDilerFullHouse2A)
                    {
                        dilerWin += 7.145;
                        break;
                    }
                    if (prufDilerFullHouseAK)
                    {
                        dilerWin += 7.144;
                        break;
                    }
                    if (prufDilerFullHouseDK)
                    {
                        dilerWin += 7.143;
                        break;
                    }
                    if (prufDilerFullHouseVK)
                    {
                        dilerWin += 7.142;
                        break;
                    }
                    if (prufDilerFullHouse10K)
                    {
                        dilerWin += 7.141;
                        break;
                    }
                    if (prufDilerFullHouse9K)
                    {
                        dilerWin += 7.140;
                        break;
                    }
                    if (prufDilerFullHouse8K)
                    {
                        dilerWin += 7.139;
                        break;
                    }
                    if (prufDilerFullHouse7K)
                    {
                        dilerWin += 7.138;
                        break;
                    }
                    if (prufDilerFullHouse6K)
                    {
                        dilerWin += 7.137;
                        break;
                    }
                    if (prufDilerFullHouse5K)
                    {
                        dilerWin += 7.136;
                        break;
                    }
                    if (prufDilerFullHouse4K)
                    {
                        dilerWin += 7.135;
                        break;
                    }
                    if (prufDilerFullHouse3K)
                    {
                        dilerWin += 7.134;
                        break;
                    }
                    if (prufDilerFullHouse2K)
                    {
                        dilerWin += 7.133;
                        break;
                    }
                    if (prufDilerFullHouseAD)
                    {
                        dilerWin += 7.132;
                        break;
                    }
                    if (prufDilerFullHouseKD)
                    {
                        dilerWin += 7.131;
                        break;
                    }
                    if (prufDilerFullHouseVD)
                    {
                        dilerWin += 7.130;
                        break;
                    }
                    if (prufDilerFullHouse10D)
                    {
                        dilerWin += 7.129;
                        break;
                    }
                    if (prufDilerFullHouse9D)
                    {
                        dilerWin += 7.128;
                        break;
                    }
                    if (prufDilerFullHouse8D)
                    {
                        dilerWin += 7.127;
                        break;
                    }
                    if (prufDilerFullHouse7D)
                    {
                        dilerWin += 7.126;
                        break;
                    }
                    if (prufDilerFullHouse6D)
                    {
                        dilerWin += 7.125;
                        break;
                    }
                    if (prufDilerFullHouse5D)
                    {
                        dilerWin += 7.124;
                        break;
                    }
                    if (prufDilerFullHouse4D)
                    {
                        dilerWin += 7.123;
                        break;
                    }
                    if (prufDilerFullHouse3D)
                    {
                        dilerWin += 7.122;
                        break;
                    }
                    if (prufDilerFullHouse2D)
                    {
                        dilerWin += 7.121;
                        break;
                    }
                    if (prufDilerFullHouseAV)
                    {
                        dilerWin += 7.120;
                        break;
                    }
                    if (prufDilerFullHouseKV)
                    {
                        dilerWin += 7.119;
                        break;
                    }
                    if (prufDilerFullHouseDV)
                    {
                        dilerWin += 7.118;
                        break;
                    }
                    if (prufDilerFullHouse10V)
                    {
                        dilerWin += 7.117;
                        break;
                    }
                    if (prufDilerFullHouse9V)
                    {
                        dilerWin += 7.116;
                        break;
                    }
                    if (prufDilerFullHouse8V)
                    {
                        dilerWin += 7.115;
                        break;
                    }
                    if (prufDilerFullHouse7V)
                    {
                        dilerWin += 7.114;
                        break;
                    }
                    if (prufDilerFullHouse6V)
                    {
                        dilerWin += 7.113;
                        break;
                    }
                    if (prufDilerFullHouse5V)
                    {
                        dilerWin += 7.112;
                        break;
                    }
                    if (prufDilerFullHouse4V)
                    {
                        dilerWin += 7.111;
                        break;
                    }
                    if (prufDilerFullHouse3V)
                    {
                        dilerWin += 7.110;
                        break;
                    }
                    if (prufDilerFullHouse2V)
                    {
                        dilerWin += 7.109;
                        break;
                    }
                    if (prufDilerFullHouseA10)
                    {
                        dilerWin += 7.108;
                        break;
                    }
                    if (prufDilerFullHouseK10)
                    {
                        dilerWin += 7.107;
                        break;
                    }
                    if (prufDilerFullHouseD10)
                    {
                        dilerWin += 7.106;
                        break;
                    }
                    if (prufDilerFullHouseV10)
                    {
                        dilerWin += 7.105;
                        break;
                    }
                    if (prufDilerFullHouse910)
                    {
                        dilerWin += 7.104;
                        break;
                    }
                    if (prufDilerFullHouse810)
                    {
                        dilerWin += 7.103;
                        break;
                    }
                    if (prufDilerFullHouse710)
                    {
                        dilerWin += 7.102;
                        break;
                    }
                    if (prufDilerFullHouse610)
                    {
                        dilerWin += 7.101;
                        break;
                    }
                    if (prufDilerFullHouse510)
                    {
                        dilerWin += 7.100;
                        break;
                    }
                    if (prufDilerFullHouse410)
                    {
                        dilerWin += 7.099;
                        break;
                    }
                    if (prufDilerFullHouse310)
                    {
                        dilerWin += 7.098;
                        break;
                    }
                    if (prufDilerFullHouse210)
                    {
                        dilerWin += 7.097;
                        break;
                    }
                    if (prufDilerFullHouseA9)
                    {
                        dilerWin += 7.096;
                        break;
                    }
                    if (prufDilerFullHouseK9)
                    {
                        dilerWin += 7.095;
                        break;
                    }
                    if (prufDilerFullHouseD9)
                    {
                        dilerWin += 7.094;
                        break;
                    }
                    if (prufDilerFullHouseV9)
                    {
                        dilerWin += 7.093;
                        break;
                    }
                    if (prufDilerFullHouse109)
                    {
                        dilerWin += 7.092;
                        break;
                    }
                    if (prufDilerFullHouse89)
                    {
                        dilerWin += 7.091;
                        break;
                    }
                    if (prufDilerFullHouse79)
                    {
                        dilerWin += 7.090;
                        break;
                    }
                    if (prufDilerFullHouse69)
                    {
                        dilerWin += 7.089;
                        break;
                    }
                    if (prufDilerFullHouse59)
                    {
                        dilerWin += 7.088;
                        break;
                    }
                    if (prufDilerFullHouse49)
                    {
                        dilerWin += 7.087;
                        break;
                    }
                    if (prufDilerFullHouse39)
                    {
                        dilerWin += 7.086;
                        break;
                    }
                    if (prufDilerFullHouse29)
                    {
                        dilerWin += 7.085;
                        break;
                    }
                    if (prufDilerFullHouseA8)
                    {
                        dilerWin += 7.084;
                        break;
                    }
                    if (prufDilerFullHouseK8)
                    {
                        dilerWin += 7.083;
                        break;
                    }
                    if (prufDilerFullHouseD8)
                    {
                        dilerWin += 7.082;
                        break;
                    }
                    if (prufDilerFullHouseV8)
                    {
                        dilerWin += 7.081;
                        break;
                    }
                    if (prufDilerFullHouse108)
                    {
                        dilerWin += 7.080;
                        break;
                    }
                    if (prufDilerFullHouse98)
                    {
                        dilerWin += 7.079;
                        break;
                    }
                    if (prufDilerFullHouse78)
                    {
                        dilerWin += 7.078;
                        break;
                    }
                    if (prufDilerFullHouse68)
                    {
                        dilerWin += 7.077;
                        break;
                    }
                    if (prufDilerFullHouse58)
                    {
                        dilerWin += 7.076;
                        break;
                    }
                    if (prufDilerFullHouse48)
                    {
                        dilerWin += 7.075;
                        break;
                    }
                    if (prufDilerFullHouse38)
                    {
                        dilerWin += 7.074;
                        break;
                    }
                    if (prufDilerFullHouse28)
                    {
                        dilerWin += 7.073;
                        break;
                    }
                    if (prufDilerFullHouseA7)
                    {
                        dilerWin += 7.072;
                        break;
                    }
                    if (prufDilerFullHouseK7)
                    {
                        dilerWin += 7.071;
                        break;
                    }
                    if (prufDilerFullHouseD7)
                    {
                        dilerWin += 7.070;
                        break;
                    }
                    if (prufDilerFullHouseV7)
                    {
                        dilerWin += 7.069;
                        break;
                    }
                    if (prufDilerFullHouse107)
                    {
                        dilerWin += 7.068;
                        break;
                    }
                    if (prufDilerFullHouse97)
                    {
                        dilerWin += 7.067;
                        break;
                    }
                    if (prufDilerFullHouse87)
                    {
                        dilerWin += 7.066;
                        break;
                    }
                    if (prufDilerFullHouse67)
                    {
                        dilerWin += 7.065;
                        break;
                    }
                    if (prufDilerFullHouse57)
                    {
                        dilerWin += 7.064;
                        break;
                    }
                    if (prufDilerFullHouse47)
                    {
                        dilerWin += 7.063;
                        break;
                    }
                    if (prufDilerFullHouse37)
                    {
                        dilerWin += 7.062;
                        break;
                    }
                    if (prufDilerFullHouse27)
                    {
                        dilerWin += 7.061;
                        break;
                    }
                    if (prufDilerFullHouseA6)
                    {
                        dilerWin += 7.060;
                        break;
                    }
                    if (prufDilerFullHouseK6)
                    {
                        dilerWin += 7.059;
                        break;
                    }
                    if (prufDilerFullHouseD6)
                    {
                        dilerWin += 7.058;
                        break;
                    }
                    if (prufDilerFullHouseV6)
                    {
                        dilerWin += 7.057;
                        break;
                    }
                    if (prufDilerFullHouse106)
                    {
                        dilerWin += 7.056;
                        break;
                    }
                    if (prufDilerFullHouse96)
                    {
                        dilerWin += 7.055;
                        break;
                    }
                    if (prufDilerFullHouse86)
                    {
                        dilerWin += 7.054;
                        break;
                    }
                    if (prufDilerFullHouse76)
                    {
                        dilerWin += 7.053;
                        break;
                    }
                    if (prufDilerFullHouse56)
                    {
                        dilerWin += 7.052;
                        break;
                    }
                    if (prufDilerFullHouse46)
                    {
                        dilerWin += 7.051;
                        break;
                    }
                    if (prufDilerFullHouse36)
                    {
                        dilerWin += 7.050;
                        break;
                    }
                    if (prufDilerFullHouse26)
                    {
                        dilerWin += 7.049;
                        break;
                    }
                    if (prufDilerFullHouseA5)
                    {
                        dilerWin += 7.048;
                        break;
                    }
                    if (prufDilerFullHouseK5)
                    {
                        dilerWin += 7.047;
                        break;
                    }
                    if (prufDilerFullHouseD5)
                    {
                        dilerWin += 7.046;
                        break;
                    }
                    if (prufDilerFullHouseV5)
                    {
                        dilerWin += 7.045;
                        break;
                    }
                    if (prufDilerFullHouse105)
                    {
                        dilerWin += 7.044;
                        break;
                    }
                    if (prufDilerFullHouse95)
                    {
                        dilerWin += 7.043;
                        break;
                    }
                    if (prufDilerFullHouse85)
                    {
                        dilerWin += 7.042;
                        break;
                    }
                    if (prufDilerFullHouse75)
                    {
                        dilerWin += 7.041;
                        break;
                    }
                    if (prufDilerFullHouse65)
                    {
                        dilerWin += 7.040;
                        break;
                    }
                    if (prufDilerFullHouse45)
                    {
                        dilerWin += 7.039;
                        break;
                    }
                    if (prufDilerFullHouse35)
                    {
                        dilerWin += 7.038;
                        break;
                    }
                    if (prufDilerFullHouse25)
                    {
                        dilerWin += 7.037;
                        break;
                    }
                    if (prufDilerFullHouseA4)
                    {
                        dilerWin += 7.036;
                        break;
                    }
                    if (prufDilerFullHouseK4)
                    {
                        dilerWin += 7.035;
                        break;
                    }
                    if (prufDilerFullHouseD4)
                    {
                        dilerWin += 7.034;
                        break;
                    }
                    if (prufDilerFullHouseV4)
                    {
                        dilerWin += 7.033;
                        break;
                    }
                    if (prufDilerFullHouse104)
                    {
                        dilerWin += 7.032;
                        break;
                    }
                    if (prufDilerFullHouse94)
                    {
                        dilerWin += 7.031;
                        break;
                    }
                    if (prufDilerFullHouse84)
                    {
                        dilerWin += 7.030;
                        break;
                    }
                    if (prufDilerFullHouse74)
                    {
                        dilerWin += 7.029;
                        break;
                    }
                    if (prufDilerFullHouse64)
                    {
                        dilerWin += 7.028;
                        break;
                    }
                    if (prufDilerFullHouse54)
                    {
                        dilerWin += 7.027;
                        break;
                    }
                    if (prufDilerFullHouse34)
                    {
                        dilerWin += 7.026;
                        break;
                    }
                    if (prufDilerFullHouse24)
                    {
                        dilerWin += 7.025;
                        break;
                    }
                    if (prufDilerFullHouseA3)
                    {
                        dilerWin += 7.024;
                        break;
                    }
                    if (prufDilerFullHouseK3)
                    {
                        dilerWin += 7.023;
                        break;
                    }
                    if (prufDilerFullHouseD3)
                    {
                        dilerWin += 7.022;
                        break;
                    }
                    if (prufDilerFullHouseV3)
                    {
                        dilerWin += 7.021;
                        break;
                    }
                    if (prufDilerFullHouse103)
                    {
                        dilerWin += 7.020;
                        break;
                    }
                    if (prufDilerFullHouse93)
                    {
                        dilerWin += 7.019;
                        break;
                    }
                    if (prufDilerFullHouse83)
                    {
                        dilerWin += 7.018;
                        break;
                    }
                    if (prufDilerFullHouse73)
                    {
                        dilerWin += 7.017;
                        break;
                    }
                    if (prufDilerFullHouse63)
                    {
                        dilerWin += 7.016;
                        break;
                    }
                    if (prufDilerFullHouse53)
                    {
                        dilerWin += 7.015;
                        break;
                    }
                    if (prufDilerFullHouse43)
                    {
                        dilerWin += 7.014;
                        break;
                    }
                    if (prufDilerFullHouse23)
                    {
                        dilerWin += 7.013;
                        break;
                    }
                    if (prufDilerFullHouseA2)
                    {
                        dilerWin += 7.012;
                        break;
                    }
                    if (prufDilerFullHouseK2)
                    {
                        dilerWin += 7.011;
                        break;
                    }
                    if (prufDilerFullHouseD2)
                    {
                        dilerWin += 7.010;
                        break;
                    }
                    if (prufDilerFullHouseV2)
                    {
                        dilerWin += 7.009;
                        break;
                    }
                    if (prufDilerFullHouse102)
                    {
                        dilerWin += 7.008;
                        break;
                    }
                    if (prufDilerFullHouse92)
                    {
                        dilerWin += 7.007;
                        break;
                    }
                    if (prufDilerFullHouse82)
                    {
                        dilerWin += 7.006;
                        break;
                    }
                    if (prufDilerFullHouse72)
                    {
                        dilerWin += 7.005;
                        break;
                    }
                    if (prufDilerFullHouse62)
                    {
                        dilerWin += 7.004;
                        break;
                    }
                    if (prufDilerFullHouse52)
                    {
                        dilerWin += 7.003;
                        break;
                    }
                    if (prufDilerFullHouse42)
                    {
                        dilerWin += 7.002;
                        break;
                    }
                    if (prufDilerFullHouse32)
                    {
                        dilerWin += 7.001;
                        break;
                    }
                    if (prufDilerFleshPika || prufDilerFleshChirva || prufDilerFleshBuba || prufDilerFleshHresta)
                    {
                        dilerWin += 6.1;
                        break;
                    }
                    if (prufDilerStrit10A)
                    {
                        dilerWin += 5.9;
                        break;
                    }
                    if (prufDilerStrit9K)
                    {
                        dilerWin += 5.8;
                        break;
                    }
                    if (prufDilerStrit8D)
                    {
                        dilerWin += 5.7;
                        break;
                    }
                    if (prufDilerStrit7V)
                    {
                        dilerWin += 5.6;
                        break;
                    }
                    if (prufDilerStrit610)
                    {
                        dilerWin += 5.5;
                        break;
                    }
                    if (prufDilerStrit59)
                    {
                        dilerWin += 5.4;
                        break;
                    }
                    if (prufDilerStrit48)
                    {
                        dilerWin += 5.3;
                        break;
                    }
                    if (prufDilerStrit37)
                    {
                        dilerWin += 5.2;
                        break;
                    }
                    if (prufDilerStrit26)
                    {
                        dilerWin += 5.1;
                        break;
                    }
                    if (prufDilerSetA)
                    {
                        dilerWin += 4.14;
                        break;
                    }
                    if (prufDilerSetK)
                    {
                        dilerWin += 4.13;
                        break;
                    }
                    if (prufDilerSetD)
                    {
                        dilerWin += 4.12;
                        break;
                    }
                    if (prufDilerSetV)
                    {
                        dilerWin += 4.11;
                        break;
                    }
                    if (prufDilerSet10)
                    {
                        dilerWin += 4.10;
                        break;
                    }
                    if (prufDilerSet9)
                    {
                        dilerWin += 4.09;
                        break;
                    }
                    if (prufDilerSet8)
                    {
                        dilerWin += 4.08;
                        break;
                    }
                    if (prufDilerSet7)
                    {
                        dilerWin += 4.07;
                        break;
                    }
                    if (prufDilerSet6)
                    {
                        dilerWin += 4.06;
                        break;
                    }
                    if (prufDilerSet5)
                    {
                        dilerWin += 4.05;
                        break;
                    }
                    if (prufDilerSet4)
                    {
                        dilerWin += 4.04;
                        break;
                    }
                    if (prufDilerSet3)
                    {
                        dilerWin += 4.03;
                        break;
                    }
                    if (prufDilerSet2)
                    {
                        dilerWin += 4.02;
                        break;
                    }
                    if (prufDilerParaKA)
                    {
                        dilerWin += 3.79;
                        break;
                    }
                    if (prufDilerParaDA)
                    {
                        dilerWin += 3.78;
                        break;
                    }
                    if (prufDilerParaVA)
                    {
                        dilerWin += 3.77;
                        break;
                    }
                    if (prufDilerPara10A)
                    {
                        dilerWin += 3.76;
                        break;
                    }
                    if (prufDilerPara9A)
                    {
                        dilerWin += 3.75;
                        break;
                    }
                    if (prufDilerPara8A)
                    {
                        dilerWin += 3.74;
                        break;
                    }
                    if (prufDilerPara7A)
                    {
                        dilerWin += 3.73;
                        break;
                    }
                    if (prufDilerPara6A)
                    {
                        dilerWin += 3.72;
                        break;
                    }
                    if (prufDilerPara5A)
                    {
                        dilerWin += 3.71;
                        break;
                    }
                    if (prufDilerPara4A)
                    {
                        dilerWin += 3.70;
                        break;
                    }
                    if (prufDilerPara3A)
                    {
                        dilerWin += 3.69;
                        break;
                    }
                    if (prufDilerPara2A)
                    {
                        dilerWin += 3.68;
                        break;
                    }
                    if (prufDilerParaDK)
                    {
                        dilerWin += 3.67;
                        break;
                    }
                    if (prufDilerParaVK)
                    {
                        dilerWin += 3.66;
                        break;
                    }
                    if (prufDilerPara10K)
                    {
                        dilerWin += 3.65;
                        break;
                    }
                    if (prufDilerPara9K)
                    {
                        dilerWin += 3.64;
                        break;
                    }
                    if (prufDilerPara8K)
                    {
                        dilerWin += 3.63;
                        break;
                    }
                    if (prufDilerPara7K)
                    {
                        dilerWin += 3.62;
                        break;
                    }
                    if (prufDilerPara6K)
                    {
                        dilerWin += 3.61;
                        break;
                    }
                    if (prufDilerPara5K)
                    {
                        dilerWin += 3.60;
                        break;
                    }
                    if (prufDilerPara4K)
                    {
                        dilerWin += 3.59;
                        break;
                    }
                    if (prufDilerPara3K)
                    {
                        dilerWin += 3.58;
                        break;
                    }
                    if (prufDilerPara2K)
                    {
                        dilerWin += 3.57;
                        break;
                    }
                    if (prufDilerParaVD)
                    {
                        dilerWin += 3.56;
                        break;
                    }
                    if (prufDilerPara10D)
                    {
                        dilerWin += 3.55;
                        break;
                    }
                    if (prufDilerPara9D)
                    {
                        dilerWin += 3.54;
                        break;
                    }
                    if (prufDilerPara8D)
                    {
                        dilerWin += 3.53;
                        break;
                    }
                    if (prufDilerPara7D)
                    {
                        dilerWin += 3.52;
                        break;
                    }
                    if (prufDilerPara6D)
                    {
                        dilerWin += 3.51;
                        break;
                    }
                    if (prufDilerPara5D)
                    {
                        dilerWin += 3.50;
                        break;
                    }
                    if (prufDilerPara4D)
                    {
                        dilerWin += 3.49;
                        break;
                    }
                    if (prufDilerPara3D)
                    {
                        dilerWin += 3.48;
                        break;
                    }
                    if (prufDilerPara2D)
                    {
                        dilerWin += 3.47;
                        break;
                    }
                    if (prufDilerPara10V)
                    {
                        dilerWin += 3.46;
                        break;
                    }
                    if (prufDilerPara9V)
                    {
                        dilerWin += 3.45;
                        break;
                    }
                    if (prufDilerPara8V)
                    {
                        dilerWin += 3.44;
                        break;
                    }
                    if (prufDilerPara7V)
                    {
                        dilerWin += 3.43;
                        break;
                    }
                    if (prufDilerPara6V)
                    {
                        dilerWin += 3.42;
                        break;
                    }
                    if (prufDilerPara5V)
                    {
                        dilerWin += 3.41;
                        break;
                    }
                    if (prufDilerPara4V)
                    {
                        dilerWin += 3.40;
                        break;
                    }
                    if (prufDilerPara3V)
                    {
                        dilerWin += 3.39;
                        break;
                    }
                    if (prufDilerPara2V)
                    {
                        dilerWin += 3.38;
                        break;
                    }
                    if (prufDilerPara910)
                    {
                        dilerWin += 3.37;
                        break;
                    }
                    if (prufDilerPara810)
                    {
                        dilerWin += 3.36;
                        break;
                    }
                    if (prufDilerPara710)
                    {
                        dilerWin += 3.35;
                        break;
                    }
                    if (prufDilerPara610)
                    {
                        dilerWin += 3.34;
                        break;
                    }
                    if (prufDilerPara510)
                    {
                        dilerWin += 3.33;
                        break;
                    }
                    if (prufDilerPara410)
                    {
                        dilerWin += 3.32;
                        break;
                    }
                    if (prufDilerPara310)
                    {
                        dilerWin += 3.31;
                        break;
                    }
                    if (prufDilerPara210)
                    {
                        dilerWin += 3.30;
                        break;
                    }
                    if (prufDilerPara89)
                    {
                        dilerWin += 3.29;
                        break;
                    }
                    if (prufDilerPara79)
                    {
                        dilerWin += 3.28;
                        break;
                    }
                    if (prufDilerPara69)
                    {
                        dilerWin += 3.27;
                        break;
                    }
                    if (prufDilerPara59)
                    {
                        dilerWin += 3.26;
                        break;
                    }
                    if (prufDilerPara49)
                    {
                        dilerWin += 3.25;
                        break;
                    }
                    if (prufDilerPara39)
                    {
                        dilerWin += 3.24;
                        break;
                    }
                    if (prufDilerPara29)
                    {
                        dilerWin += 3.23;
                        break;
                    }
                    if (prufDilerPara78)
                    {
                        dilerWin += 3.22;
                        break;
                    }
                    if (prufDilerPara68)
                    {
                        dilerWin += 3.21;
                        break;
                    }
                    if (prufDilerPara58)
                    {
                        dilerWin += 3.20;
                        break;
                    }
                    if (prufDilerPara48)
                    {
                        dilerWin += 3.19;
                        break;
                    }
                    if (prufDilerPara38)
                    {
                        dilerWin += 3.18;
                        break;
                    }
                    if (prufDilerPara28)
                    {
                        dilerWin += 3.17;
                        break;
                    }
                    if (prufDilerPara67)
                    {
                        dilerWin += 3.16;
                        break;
                    }
                    if (prufDilerPara57)
                    {
                        dilerWin += 3.15;
                        break;
                    }
                    if (prufDilerPara47)
                    {
                        dilerWin += 3.14;
                        break;
                    }
                    if (prufDilerPara37)
                    {
                        dilerWin += 3.13;
                        break;
                    }
                    if (prufDilerPara27)
                    {
                        dilerWin += 3.12;
                        break;
                    }
                    if (prufDilerPara56)
                    {
                        dilerWin += 3.11;
                        break;
                    }
                    if (prufDilerPara46)
                    {
                        dilerWin += 3.10;
                        break;
                    }
                    if (prufDilerPara36)
                    {
                        dilerWin += 3.09;
                        break;
                    }
                    if (prufDilerPara26)
                    {
                        dilerWin += 3.08;
                        break;
                    }
                    if (prufDilerPara45)
                    {
                        dilerWin += 3.07;
                        break;
                    }
                    if (prufDilerPara35)
                    {
                        dilerWin += 3.06;
                        break;
                    }
                    if (prufDilerPara25)
                    {
                        dilerWin += 3.05;
                        break;
                    }
                    if (prufDilerPara34)
                    {
                        dilerWin += 3.04;
                        break;
                    }
                    if (prufDilerPara24)
                    {
                        dilerWin += 3.03;
                        break;
                    }
                    if (prufDilerPara23)
                    {
                        dilerWin += 3.02;
                        break;
                    }
                    if (prufDilerParaA)
                    {
                        dilerWin += 2.14;
                        break;
                    }
                    if (prufDilerParaK)
                    {
                        dilerWin += 2.13;
                        break;
                    }
                    if (prufDilerParaD)
                    {
                        dilerWin += 2.12;
                        break;
                    }
                    if (prufDilerParaV)
                    {
                        dilerWin += 2.11;
                        break;
                    }
                    if (prufDilerPara10)
                    {
                        dilerWin += 2.10;
                        break;
                    }
                    if (prufDilerPara9)
                    {
                        dilerWin += 2.09;
                        break;
                    }
                    if (prufDilerPara8)
                    {
                        dilerWin += 2.08;
                        break;
                    }
                    if (prufDilerPara7)
                    {
                        dilerWin += 2.07;
                        break;
                    }
                    if (prufDilerPara6)
                    {
                        dilerWin += 2.06;
                        break;
                    }
                    if (prufDilerPara5)
                    {
                        dilerWin += 2.05;
                        break;
                    }
                    if (prufDilerPara4)
                    {
                        dilerWin += 2.04;
                        break;
                    }
                    if (prufDilerPara3)
                    {
                        dilerWin += 2.03;
                        break;
                    }
                    if (prufDilerPara2)
                    {
                        dilerWin += 2.02;
                        break;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Результат:");
                Console.WriteLine();
                if (myWin > dilerWin)
                {
                    Console.WriteLine("Ви виграли.");
                    kesh += sum;
                }
                else if (myWin < dilerWin)
                {
                    Console.WriteLine("Ви програли.");
                }
                else 
                {
                    switch (myNumber1)
                    {
                        case "V":
                            myNumber1 = "11";
                            break;
                        case "D":
                            myNumber1 = "12";
                            break;
                        case "K":
                            myNumber1 = "13";
                            break;
                        case "A":
                            myNumber1 = "14";
                            break;
                    }
                    switch (myNumber2)
                    {
                        case "V":
                            myNumber2 = "11";
                            break;
                        case "D":
                            myNumber2 = "12";
                            break;
                        case "K":
                            myNumber2 = "13";
                            break;
                        case "A":
                            myNumber2 = "14";
                            break;
                    }
                    switch (dilerNumber1)
                    {
                        case "V":
                            dilerNumber1 = "11";
                            break;
                        case "D":
                            dilerNumber1 = "12";
                            break;
                        case "K":
                            dilerNumber1 = "13";
                            break;
                        case "A":
                            dilerNumber1 = "14";
                            break;
                    }
                    switch (dilerNumber2)
                    {
                        case "V":
                            dilerNumber2 = "11";
                            break;
                        case "D":
                            dilerNumber2 = "12";
                            break;
                        case "K":
                            dilerNumber2 = "13";
                            break;
                        case "A":
                            dilerNumber2 = "14";
                            break;
                    }
                    int myKiker = 0;
                    int dilerKiker = 0;
                    if (int.Parse(myNumber1) > int.Parse(myNumber2))
                    {
                        myKiker = int.Parse(myNumber1);
                    }
                    else
                    {
                        myKiker = int.Parse(myNumber2);
                    }
                    if (int.Parse(dilerNumber1) > int.Parse(dilerNumber2))
                    {
                        dilerKiker = int.Parse(dilerNumber1);
                    }
                    else
                    {
                        dilerKiker = int.Parse(dilerNumber2);
                    }
                    if (myKiker > dilerKiker)
                    {
                        Console.WriteLine("Ви виграли.");
                        kesh += sum;
                    }
                    else if (myKiker < dilerKiker)
                    {
                        Console.WriteLine("Ви програли.");
                    }
                    else
                    {
                        Console.WriteLine("Нічія");
                        kesh += sum / 2;
                    }     
                }
                for (int a = 0; a < table.GetLength(0); a++)
                {
                    for (int b = 0; b < table.GetLength(1); b++)
                    {
                        Console.SetCursorPosition(31 + b, 6 + a);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        if (table[a, b] == "#")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.Write(table[a, b]);
                            Console.ResetColor();
                        }
                        else if (table[a, b] == "?")
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(table[a, b]);
                            Console.ResetColor();
                        }
                        else if (table[a, b + 1] == "10" || table[a, b + 1] == "0")
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            if (table[a, b + 2] == "♥" || table[a, b + 2] == "♦")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                            }
                            else if (table[a, b + 2] == "♠" || table[a, b + 2] == "♣")
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                            }
                            Console.BackgroundColor = ConsoleColor.White;
                            table[a, b] = "1";
                            Console.Write(table[a, b]);
                            table[a, b + 1] = "0";
                            Console.ResetColor();
                            continue;
                        }
                        else if (table[a, b + 1] == "♥" || table[a, b + 1] == "♦")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(table[a, b]);
                            Console.ResetColor();
                        }
                        else if (table[a, b] == "♥" || table[a, b] == "♦")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(table[a, b]);
                            Console.ResetColor();
                        }
                        else if (table[a, b + 1] == "♠" || table[a, b + 1] == "♣")
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(table[a, b]);
                            Console.ResetColor();
                        }
                        else if (table[a, b] == "♠" || table[a, b] == "♣")
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(table[a, b]);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(table[a, b]);
                        }
                    }
                    Console.WriteLine();
                }
                Console.ResetColor();
                Console.SetCursorPosition(0, 27);
                Console.WriteLine("Можливі комбінації(від найстаршої): ");
                for (int a = 0; a < kombo.GetLength(0); a++)
                {
                    for (int b = 0; b < kombo.GetLength(1); b++)
                    {
                        Console.SetCursorPosition(0 + b, 28 + a);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        if (kombo[a, b] == "#")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.Write(kombo[a, b]);
                            Console.ResetColor();
                        }
                        else if (kombo[a, b] == "1" && kombo[a, b + 1] == "0" && (kombo[a, b + 2] == "♥" || kombo[a, b + 2] == "♦" || kombo[a, b + 2] == "♠" || kombo[a, b + 2] == "♣"))
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            if (kombo[a, b + 2] == "♥" || kombo[a, b + 2] == "♦")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                            }
                            else if (kombo[a, b + 2] == "♠" || kombo[a, b + 2] == "♣")
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                            }
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(kombo[a, b]);
                            Console.ResetColor();
                            continue;
                        }
                        else if (kombo[a, b + 1] == "♥" || kombo[a, b + 1] == "♦")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(kombo[a, b]);
                            Console.ResetColor();
                        }
                        else if (kombo[a, b] == "♥" || kombo[a, b] == "♦")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(kombo[a, b]);
                            Console.ResetColor();
                        }
                        else if (kombo[a, b + 1] == "♠" || kombo[a, b + 1] == "♣")
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(kombo[a, b]);
                            Console.ResetColor();
                        }
                        else if (kombo[a, b] == "♠" || kombo[a, b] == "♣")
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(kombo[a, b]);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(kombo[a, b]);
                        }
                    }
                    Console.WriteLine();
                }
                Console.ResetColor();
                Console.SetCursorPosition(0, 22);
                Console.WriteLine("Ваш баланс: " + kesh);
                Console.WriteLine();
                Console.Write("Бажаєте ще раз зіграти(y/n): ");
                next = Console.ReadLine();
                if (next != "y" && next != "n")
                {
                    while (true)
                    {
                        Console.Write("Неправильний ввід. Спробуйте знову: ");
                        next = Console.ReadLine();
                        if (next == "y" || next == "n")
                        {
                            break;
                        }
                    }
                }
                if (next == "y")
                {
                    Console.WriteLine("Продовжуємо!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Добре, попутного вітру вам у сфінктер!");
                    break;
                }
                if (kesh <= 0)
                {
                    Console.WriteLine("У вас не залишилось грошей.");
                    break;
                }
                Console.Clear();
            }
        }
    }
}