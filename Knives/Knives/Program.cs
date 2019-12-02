using System;

namespace Knives
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравейте!");
            Console.WriteLine("Моля, въведете тип нож (дамаск/обикновен):");
            string kniveType = Console.ReadLine();
            Console.WriteLine("Моля, въведете размер на острието (см):");
            double bladeLength = double.Parse(Console.ReadLine());

            double bladePrice = bladeLength * 5;
            if (kniveType == "дамаск")
            {
                bladePrice *= 2;
            }

            Console.WriteLine("Моля, въведете размерът на дръжката (см):");
            double handleLength = double.Parse(Console.ReadLine());

            double handlePrice = handleLength;
            Console.WriteLine("Моля, въведете типът дръжка, който предпочитате (fulltang/hidden tang):");
            string handleType = Console.ReadLine();
            if (handleType == "fulltang")
            {
                handlePrice *= 1.5;
            }
            Console.WriteLine("Каква дръжка предпочитате (дърво/микарта):");
            string handleMaterial = Console.ReadLine();

            switch (handleMaterial)
            {
                case "дърво":
                    Console.WriteLine("Вид дърво (обикновено/стабилизирано)");
                    string woodSpecialty = Console.ReadLine();
                    switch (woodSpecialty)
                    {
                        case "стабилизирано":
                            handlePrice *= 5;
                            break;
                    }

                    Console.WriteLine("От колко парчета дърво ще се състои дръжката?");
                    int woodPieces = int.Parse(Console.ReadLine());
                    if (woodPieces > 2)
                    {
                        handlePrice += woodPieces * 2;
                    }
                    break;
            }
            Console.WriteLine("Гард? (да/не):");
            string guardYesNo = Console.ReadLine();
            if (guardYesNo == "да")
            {
                handlePrice += 10;
            }

            Console.WriteLine("Пета? (да/не):");
            string bolsterYesNo = Console.ReadLine();
            if (bolsterYesNo == "да")
            {
                handlePrice += 10;
            }

            Console.WriteLine("Желаете ли някакви декоративни елементи? (да/не):");
            string decorationsYesNo = Console.ReadLine();
            if (decorationsYesNo == "да")
            {
                handlePrice += 10;
                Console.WriteLine("Инкрустации? (да/не):");
                string incrustation = Console.ReadLine();
                if (incrustation == "да")
                {
                    handlePrice += 10;
                }
            }
            Console.WriteLine("Желаете ли кания към ножа? (да/не)");
            string sheathYesNo = Console.ReadLine();
            if (sheathYesNo == "да")
            {
                handlePrice += 50;
                Console.WriteLine("Декорации по канията? (да/не):");
                string sheathDecorations = Console.ReadLine();
                if (sheathYesNo == "да")
                {
                    handlePrice += 30;
                }
            }
            double totalPrice = (bladePrice + handlePrice) * 2;
            Console.WriteLine($"Цена: {totalPrice:F2}");
            Console.WriteLine();
            Console.WriteLine("Press any key to END");

            Console.ReadLine();
        }
    }
}
