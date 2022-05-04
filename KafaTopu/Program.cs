/*
 * B211200300
 * Muhammet İkbal Yakupoğlu
 * Nesneye Dayalı Programlama
 * KafaTopu Oyunu Projesi
 */

using System.Threading.Channels;
using KafaTopu;


// Main Menu
Console.CursorVisible = false;

ConsoleKey consoleKey = new ConsoleKey();
ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();

Console.WriteLine("Kafatopu Oyununa Hoş Geldin..");
Console.WriteLine("Oyunu 3 puan olan oyuncu kazanır.");
Console.WriteLine("Başlamak İçin -Enter- tuşuna, Çıkmak İçin -Esc- tuşuna basınız.");
Console.WriteLine();
Console.WriteLine("1. Oyuncunun Tuşları -> W - Yukarı \t S - Aşağı");
Console.WriteLine("2. Oyuncunun Tuşarı -> Üst ok Tuşu - Yukarı \t Alt Ok Tuşu - Aşağı.\n\n\n");

while (true)
{
    if (Console.KeyAvailable)
    {
        keyInfo = Console.ReadKey(true);
        consoleKey = keyInfo.Key;
    }

    switch (consoleKey)
    {
        case ConsoleKey.Escape:
            Environment.Exit(0);
            break;
        case ConsoleKey.Enter:
            Kafatopu kafatopu = new Kafatopu(30, 119);
            kafatopu.Run();
            Console.ReadKey();
            break;

    }
}



